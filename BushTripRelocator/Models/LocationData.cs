using System;
using System.Runtime.InteropServices;

namespace BushTripRelocator.Models
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct LocationData
    {
        public double latitude;
        public double longitude;
        public Int32 altitude;
        public double heading;
    }
}
