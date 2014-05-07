using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmDB.Algemeen;

namespace FilmDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                FormMain fm = new FormMain();
                fm.Visible = false;

                Application.Run(fm);
            }
            catch (Exception ex)
            {
                ErrorDump.AddError("Program.cs", "Main", ex);
            }
        }
    }
}
