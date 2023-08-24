using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushTripRelocator.Services
{
    public static class DatabaseCommon
    {
        public static readonly string DatabaseName = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\BushTripRelocator\\BushTripRelocator.sqlite";
    }
}
