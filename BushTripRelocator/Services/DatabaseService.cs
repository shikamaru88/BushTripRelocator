using BushTripRelocator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushTripRelocator.Services
{
    public interface IDatabaseService
    {
        void InitDatabase();
        void SaveData(string checkpointName, SimData simData);

        List<string> FindCheckpoints();

        SimData FindCheckpointById(string checkpointId);

        void DeleteCheckpoint(string checkpointName);
    }
}
