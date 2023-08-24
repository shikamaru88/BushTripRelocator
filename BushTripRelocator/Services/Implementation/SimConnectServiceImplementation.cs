using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BushTripRelocator.Enums;
using BushTripRelocator.Models;
using Microsoft.FlightSimulator.SimConnect;

namespace BushTripRelocator.Services.Implementation
{
    public class SimConnectServiceImplementation : ISimConnectService
    {
        private MainUI uiHandler;
        private SimConnect simConnect;
        public const int WM_USER_SIMCONNECT = 0x0402;
        private EnvironmentData environmentData = new EnvironmentData();
        private FuelData fuelData = new FuelData();
        private LocationData locationData = new LocationData();

        public SimConnectServiceImplementation()
        {
            
        }

        public bool Connect()
        {
            if (simConnect == null)
            {
                try
                {
                    simConnect = new SimConnect("MainUI", uiHandler.Handle, WM_USER_SIMCONNECT, null, 0);
                    SetupConnection();
                    return true;
                }
                catch /*(COMException ex)*/
                {
                    return false;
                }
            }

            return true;

        }

        public void SetUiHandler(Form ui)
        {
            this.uiHandler = (MainUI)ui;
        }

        public bool IsConnected()
        {
            if(simConnect != null) 
            {
                try
                {
                    simConnect.ReceiveMessage();

                    return true;
                }
                catch /*(Exception ex)*/
                {
                    return false;
                }

            }

            return false;
           
        }

        private void SetupEventsHandlers()
        {
            simConnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(SimConnect_OnRecvOpen);
            simConnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(SimConnect_OnRecvQuit);
            simConnect.OnRecvSimobjectData += new SimConnect.RecvSimobjectDataEventHandler(SimConnect_OnRecvSimobjectData);
            simConnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(SimConnect_OnRecvException);
        }

        private void SetupEnvironmentData()
        {
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.ENVIRONMENT_DATA, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simConnect.RegisterDataDefineStruct<EnvironmentData>(DATA_DEFINITIONS.ENVIRONMENT_DATA);
            simConnect.RequestDataOnSimObject(DATA_REQUEST_TYPES.ENVIRONMENT_DATA_REQUEST, DATA_DEFINITIONS.ENVIRONMENT_DATA, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.SECOND, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);
        }

        private void SetupFuelData()
        {
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.FUEL_DATA, "FUEL TANK LEFT MAIN QUANTITY", "gallons", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.FUEL_DATA, "FUEL TANK RIGHT MAIN QUANTITY", "gallons", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.FUEL_DATA, "FUEL LEFT CAPACITY", "gallons", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.FUEL_DATA, "FUEL LEFT CAPACITY", "gallons", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simConnect.RegisterDataDefineStruct<FuelData>(DATA_DEFINITIONS.FUEL_DATA);
            simConnect.RequestDataOnSimObject(DATA_REQUEST_TYPES.FUEL_DATA_REQUEST, DATA_DEFINITIONS.FUEL_DATA, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.SECOND, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);
        }

        private void SetupLocationData()
        {
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.LOCATION_DATA, "PLANE LATITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.LOCATION_DATA, "PLANE LONGITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.LOCATION_DATA, "PLANE ALTITUDE", "feet", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simConnect.AddToDataDefinition(DATA_DEFINITIONS.LOCATION_DATA, "PLANE HEADING DEGREES MAGNETIC", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simConnect.RegisterDataDefineStruct<LocationData>(DATA_DEFINITIONS.LOCATION_DATA);
            simConnect.RequestDataOnSimObject(DATA_REQUEST_TYPES.LOCATION_DATA_REQUEST, DATA_DEFINITIONS.LOCATION_DATA, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.SECOND, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);

        }
        
        private void MapSimEvents()
        {
            simConnect.MapClientEventToSimEvent(EVENT_IDS.CLOCK_HOURS_SET, "CLOCK_HOURS_SET");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.CLOCK_MINUTES_SET, "CLOCK_MINUTES_SET");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.CLOCK_SECONDS_SET, "CLOCK_SECONDS_SET");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.SIM_RATE_INCR, "SIM_RATE_INCR");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.SIM_RATE_DECR, "SIM_RATE_DECR");

            simConnect.MapClientEventToSimEvent(EVENT_IDS.NAV_LIGHTS_OFF, "NAV_LIGHTS_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.LANDING_LIGHTS_OFF, "LANDING_LIGHTS_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.BEACON_LIGHTS_OFF, "BEACON_LIGHTS_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.STROBES_OFF, "STROBES_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.TAXI_LIGHTS_OFF, "TAXI_LIGHTS_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.PITOT_HEAT_OFF, "PITOT_HEAT_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.AVIONICS_MASTER_1_OFF, "AVIONICS_MASTER_1_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.ALTERNATOR_OFF, "ALTERNATOR_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.MASTER_BATTERY_OFF, "MASTER_BATTERY_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.MIXTURE_LEAN, "MIXTURE_LEAN");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.MAGNETO_OFF, "MAGNETO_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.FLAPS_UP, "FLAPS_UP");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.FUEL_SELECTOR_1_OFF, "FUEL_SELECTOR_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.FUEL_SELECTOR_2_OFF, "FUEL_SELECTOR_2_OFF");
            simConnect.MapClientEventToSimEvent(EVENT_IDS.PROP_PITCH_HI, "PROP_PITCH_HI");
        }

        private void CloseConnection()
        {
            if (simConnect != null)
            {

                // Dispose serves the same purpose as SimConnect_Close()
                simConnect.Dispose();
                simConnect = null;
                uiHandler.SetConnectionClosed();
            }
        }

        private void SetupConnection()
        {
            SetupEventsHandlers();
            SetupEnvironmentData();
            SetupFuelData();
            SetupLocationData();
            MapSimEvents();
        }

        private void SimConnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            switch ((DATA_REQUEST_TYPES)data.dwRequestID)
            {
                case DATA_REQUEST_TYPES.FUEL_DATA_REQUEST:
                    fuelData = (FuelData)data.dwData[0];
                    uiHandler.UpdateFuelData(fuelData);
                    break;

                case DATA_REQUEST_TYPES.ENVIRONMENT_DATA_REQUEST:
                    environmentData = (EnvironmentData)data.dwData[0];
                    uiHandler.UpdateEnvironmentalDataForm(environmentData);
                    break;

                case DATA_REQUEST_TYPES.LOCATION_DATA_REQUEST:
                    locationData = (LocationData)data.dwData[0];
                    
                    break;

                default:
                    break;
            }
        }

        private void SimConnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            uiHandler.SetConnectionOpened();
        }

        private void SimConnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            CloseConnection();
        }

        private void SimConnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            SIMCONNECT_EXCEPTION eException = (SIMCONNECT_EXCEPTION)data.dwException;
            Debug.WriteLine("SimConnect_OnRecvException: " + eException.ToString());
        }

        public SimData GetSimData()
        {
            SimData data = new SimData();
            data.environmentData = environmentData;
            data.locationData = locationData;
            data.fuelData   = fuelData;

            return data;
        }

        public void LoadCheckpointToSim(SimData simData, bool coldAndDark)
        {
            var locationData = new LocationData { altitude = simData.locationData.altitude, heading = simData.locationData.heading, latitude = simData.locationData.latitude, longitude = simData.locationData.longitude };
            simConnect.SetDataOnSimObject(DATA_DEFINITIONS.LOCATION_DATA, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, locationData);

            if (coldAndDark )
            {
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.NAV_LIGHTS_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.LANDING_LIGHTS_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.BEACON_LIGHTS_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.STROBES_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.TAXI_LIGHTS_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.PITOT_HEAT_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.AVIONICS_MASTER_1_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.ALTERNATOR_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.MASTER_BATTERY_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.MIXTURE_LEAN, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.MAGNETO_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FLAPS_UP, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FUEL_SELECTOR_1_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FUEL_SELECTOR_2_OFF, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.PROP_PITCH_HI, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            }

        }

        public void LoadTimeToSim(TimeData timeData)
        {
            simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.CLOCK_HOURS_SET, (uint) timeData.hours, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.CLOCK_MINUTES_SET, (uint) timeData.minutes, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.CLOCK_SECONDS_SET, (uint) timeData.seconds, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

        }

        public void IncrSimRate()
        {
            simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.SIM_RATE_INCR, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

        }

        public void DecrSimRate()
        {
            simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.SIM_RATE_DECR, 0, GROUP_ID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

        }

        public void LoadFuelToSim(FuelData fuelData)
        {
            var fuelDataL = new FuelData { leftTankQuantity= fuelData.leftTankQuantity, rightTankQuantity = fuelData.rightTankQuantity };
            simConnect.SetDataOnSimObject(DATA_DEFINITIONS.FUEL_DATA, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, fuelDataL);

        }

        public void Disconnect()
        {
            CloseConnection();
            uiHandler.SetConnectionClosed();
        }
    }
}
