using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmDB.Data.DB;
using FilmDB.Data.Entities;

namespace FilmDB.Algemeen
{
    public class sGlobals
    {
        #region Variables
        /********************************************** Variables ******************************************************************/

        static internal string DB_File = "";
        static internal bool DB_Connected = false;
        static internal bool DB_New = false;
        static internal FDB DB = null;

        #endregion Variables

    }
}
