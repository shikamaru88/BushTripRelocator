using BushTripRelocator.Enums;
using BushTripRelocator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BushTripRelocator.Services
{
    public interface ISimConnectService
    {

        bool Connect();

        void SetUiHandler(Form ui);

        bool IsConnected();

        SimData GetSimData();

        void LoadCheckpointToSim(SimData simData);

        void LoadTimeToSim(TimeData timeData);

        void IncrSimRate();

        void DecrSimRate();

        void LoadFuelToSim(FuelData fuelData);

        void Disconnect();

    }
}
