using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite.EF6;
using System.Reflection;

namespace FilmDB.Data.DB
{
    public class SQLiteConfiguration : DbConfiguration
    {
        #region Variables
        /********************************************** Variables ******************************************************************/

        #endregion Variables

        #region Constructor, Load & Closing
        /********************************************** Constructor, Load & Closing ************************************************/

        public SQLiteConfiguration()
        {
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
            Type t = Type.GetType("System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6");
            FieldInfo fi = t.GetField("Instance", BindingFlags.NonPublic | BindingFlags.Static);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)fi.GetValue(null));
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
