using BushTripRelocator.Services;
using BushTripRelocator.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BushTripRelocator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDatabaseService databaseService = new DatabaseServiceImplementation();
            ISimConnectService simConnectService = new SimConnectServiceImplementation();
            Form form = new MainUI(databaseService, simConnectService);

            simConnectService.SetUiHandler(form);

            Application.Run(form);
        }
    }
}
