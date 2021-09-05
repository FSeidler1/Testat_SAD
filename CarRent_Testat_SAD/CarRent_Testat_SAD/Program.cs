using CarRent_Testat_SAD.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent_Testat_SAD
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBHelper dBHelper = new DBHelper();
            if (dBHelper.IsDbExisting())
            {
                Application.Run(new BackendMainView());
            }
            else
            {
                MessageBox.Show("Keine Datenbank gfunden, das Programm wird beendet.");
                Application.Exit();
            }
        }
    }
}
