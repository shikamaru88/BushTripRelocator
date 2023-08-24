using System;
using System.Runtime.InteropServices;

namespace BushTripRelocator.Models
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct SimData
    {
        public EnvironmentData environmentData;
        public FuelData fuelData;
        public LocationData locationData;
        public TimeData timeData;
        public bool validData;
    }
}
