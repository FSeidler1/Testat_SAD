using CarRent_Testat_SAD.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CarRent_Testat_SAD.Helper
{
    public class DBHelper
    {
        private static CarRentEntities _CarRentEntities = null;
        private static readonly object _Padlock = new object();

        private static string _ConnString = "Data Source=LAPTOP-126TC3IU\\MSSQLSERVER19;" +
                  "Initial Catalog=MusterAG_Auftragsverwaltung;" +
                  "Integrated Security=SSPI;";

        public static CarRentEntities CarRentEntities
        {
            get
            {
                lock (_Padlock)
                {
                    if (_CarRentEntities == null)
                    {
                        _CarRentEntities = new CarRentEntities();
                    }
                    return _CarRentEntities;
                }
            }
        }

        public bool IsDbExisting()
        {
            if (CheckIfDbExists())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Es wurde keine passende Datenbank gefunden." + Environment.NewLine + Environment.NewLine +
                    "Folgender ConnectionString wurde verwendet: " + Environment.NewLine +
                    _ConnString,
                    "Keine Datenbank gefunden");
            }

            return false;
        }

        private bool CheckIfDbExists()
        {
            try
            {
                using (var context = new CarRentEntities())
                {
                    if (context == null)
                        return false;

                    context.Database.Migrate();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + Environment.NewLine + Environment.NewLine +
                    ex.InnerException + Environment.NewLine + Environment.NewLine +
                    ex.StackTrace,
                    "Fehler");
            }

            return false;
        }

        internal bool CreateTestData()
        {
            try
            {
                //Create some Testentries here

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + Environment.NewLine + Environment.NewLine +
                    ex.InnerException + Environment.NewLine + Environment.NewLine +
                    ex.StackTrace,
                    "Fehler");
                return false;
            }
        }
    }
}
