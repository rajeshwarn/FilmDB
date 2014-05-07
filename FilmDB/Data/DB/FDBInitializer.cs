using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;
using FilmDB.Data.Entities;
using FilmDB.Algemeen;

namespace FilmDB.Data.DB
{
    public class FDBInitializer : IDatabaseInitializer<FDB>
    {
        #region Variables
        /********************************************** Variables ******************************************************************/

        #endregion Variables

        #region Constructor, Load & Closing
        /********************************************** Constructor, Load & Closing ************************************************/

        public void InitializeDatabase(FDB DB)
        {
            try
            {
                if (sGlobals.DB_New)
                {
                    string myFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "SQL", "Create.SQL");
                    string mySQL = File.ReadAllText(myFile);

                    DB.Database.ExecuteSqlCommand(mySQL);
                }


                //if versie ongelijk dan update
            }
            catch (Exception ex)
            {
                ErrorDump.AddError("FDBInitializer.cs", "InitializeDatabase", ex);
            }
        }

        #endregion Constructor, Load & Closing

        #region Functions
        /********************************************** Functions ******************************************************************/

        #endregion Functions

        #region Properties
        /********************************************** Properties *****************************************************************/

        #endregion Properties

    }
}
