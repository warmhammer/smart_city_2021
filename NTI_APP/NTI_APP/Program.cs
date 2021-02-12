using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

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
            var cb = new MySqlConnectionStringBuilder();
            cb.Server = "localhost";
            cb.UserID = "root";
            cb.Password = "123";
            cb.Database = "baumancitydb";
            MySqlConnection conn = new MySqlConnection(cb.ConnectionString);
            //string connStr = "server=localhost;user=root;database=baumancitydb;password=123;";
            //MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

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
            Application.Run(new MainForm(factoryIOProcess, conn));

            if (factoryIOProcess != null)
            { 
                factoryIOProcess.Kill();
                factoryIOProcess.WaitForExit();
            }
        }
    }
}
