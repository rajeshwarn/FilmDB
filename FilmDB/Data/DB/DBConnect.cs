using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Data.Entity;
using System.Data.Common;
using System.IO;
using FilmDB.Algemeen;

namespace FilmDB.Data.DB
{
    public class DBConnect
    {
        #region Variables
        /********************************************** Variables ******************************************************************/

        #endregion Variables

        #region Constructor, Load & Closing
        /********************************************** Constructor, Load & Closing ************************************************/

        #endregion Constructor, Load & Closing

        #region Functions
        /********************************************** Functions ******************************************************************/

        public static bool ConnectDB()
        {
            bool bSucces = false;

            try
            {
                Database.SetInitializer(new FDBInitializer());

                SQLiteConnectionStringBuilder mySQLiteConnectionStringBuilder = new SQLiteConnectionStringBuilder();
                mySQLiteConnectionStringBuilder.DataSource = sGlobals.DB_File;

                sGlobals.DB_New = !File.Exists(sGlobals.DB_File);

                SQLiteConnection myConn = new SQLiteConnection(mySQLiteConnectionStringBuilder.ConnectionString);

                sGlobals.DB = new FDB(myConn);
                sGlobals.DB.Database.Initialize(false);

                bSucces = true;
            }
            catch (Exception ex)
            {
                ErrorDump.AddError("DBConnect.cs", "ConnectDB", ex);
            }

            return bSucces;
        }

        #endregion Functions

        #region Properties
        /********************************************** Properties *****************************************************************/

        #endregion Properties

    }
}
