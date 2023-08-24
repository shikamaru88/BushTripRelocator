using System.Runtime.InteropServices;

namespace BushTripRelocator.Models
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct FuelData
    {
        public double leftTankQuantity;
        public double rightTankQuantity;
        public double fuelLeftCapacity;
        public double fuelRightCapacity;
    }
}
