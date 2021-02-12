using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NTI_APP
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProcessStartInfo procInfo = new ProcessStartInfo(@"C:/Program Files (x86)/Real Games/Factory IO/Factory IO.exe");
            procInfo.UseShellExecute = true;
            procInfo.FileName = "C:/Program Files (x86)/Real Games/Factory IO/Scenes/Automated Warehouse.factoryio";


            System.Diagnostics.Process factoryIOProcess = null;

            try
            {
                factoryIOProcess = Process.Start(procInfo);
            }
            catch
            {
                MessageBox.Show("Factory I/O openning troubles");
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(factoryIOProcess));

            factoryIOProcess.Kill();
            factoryIOProcess.WaitForExit();
        }
    }
}
