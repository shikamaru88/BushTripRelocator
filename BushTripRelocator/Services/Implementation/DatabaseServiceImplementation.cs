using BushTripRelocator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BushTripRelocator.Services
{
    public class DatabaseServiceImplementation : IDatabaseService
    {
        public void DeleteCheckpoint(string checkpointName)
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseCommon.DatabaseName}"))
            {
                connection.Open();

                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@key", checkpointName);

                    cmd.CommandText = "DELETE FROM checkpointData WHERE id = @key";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SimData FindCheckpointById(string checkpointId)
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseCommon.DatabaseName}"))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@id", checkpointId);
                    cmd.CommandText = "SELECT data FROM checkpointData WHERE id = @id";

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            var d = rdr.GetString(0);
                            var data = JsonConvert.DeserializeObject<SimData>(d);
                            data.validData = true;
                            return data;
                        }
                    }
                }
            }

            return new SimData { validData = false };
        }

        public List<string> FindCheckpoints()
        {
            var result = new List<string>();
            using (var connection = new SQLiteConnection($"Data Source={DatabaseCommon.DatabaseName}"))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT id FROM checkpointData ORDER BY id";

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(rdr.GetString(0));
                        }
                    }
                }
            }

            return result;
        }

        public void InitDatabase()
        {
            if (!File.Exists(DatabaseCommon.DatabaseName))
            {
                SQLiteConnection.CreateFile(DatabaseCommon.DatabaseName);
            }

            using (var connection = new SQLiteConnection($"Data Source={DatabaseCommon.DatabaseName}"))
            {
                connection.Open();

                CreateCheckpointTable(connection);
            }
        }

        public void SaveData(string checkpointName, SimData simData)
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseCommon.DatabaseName}"))
            {
                connection.Open();

                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@key", checkpointName+":"+simData.environmentData.title);
                    cmd.Parameters.AddWithValue("@data", JsonConvert.SerializeObject(simData));

                    cmd.CommandText = "DELETE FROM checkpointData WHERE id = @key";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO checkpointData (id, data) VALUES (@key, @data)";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void CreateCheckpointTable(SQLiteConnection connection)
        {
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS checkpointData (
                    id VARCHAR(256) NOT NULL PRIMARY KEY,
                    data TEXT
                    )
                ";

                cmd.ExecuteNonQuery();
            }
        }

    }
}
