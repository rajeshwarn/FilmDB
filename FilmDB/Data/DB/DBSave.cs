using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmDB.Algemeen;
using FilmDB.Data.Entities;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Data.Metadata.Edm;

namespace FilmDB.Data.DB
{
    public class DBSave
    {
        #region Variables
        /********************************************** Variables ******************************************************************/

        #endregion Variables

        #region Constructor, Load & Closing
        /********************************************** Constructor, Load & Closing ************************************************/

        public DBSave()
        {

        }

        #endregion Constructor, Load & Closing

        #region Functions
        /********************************************** Functions ******************************************************************/

        private static bool SaveEntity<T>(T[] entity) where T : Entity
        {
            bool bSucces = false;

            try
            {
                if (sGlobals.DB_Connected)
                {

                    sGlobals.DB.Set<T>().AddOrUpdate<T>(entity);
                    sGlobals.DB.SaveChanges();

                    bSucces = true;
                }
            }
            catch (Exception ex)
            {
                ErrorDump.AddError("DBSave.cs", "SaveEntity", ex);

            }

            return bSucces;
        }
    
        public static bool SaveInstelling(Instelling Instelling)
        {
            return SaveEntity<Instelling>(new Instelling[] { Instelling });
        }

        public static bool SaveInstellingen(Instelling[] Instellingen)
        {
            return SaveEntity<Instelling>(Instellingen);
        }

        public static bool SaveFilm(Film Film)
        {
            return SaveEntity<Film>(new Film[] { Film });
        }

        public static bool SaveFilms(Film[] Films)
        {
            return SaveEntity<Film>(Films);
        }

        public static bool SaveSerie(Serie Serie)
        {
            return SaveEntity<Serie>(new Serie[] { Serie });
        }

        public static bool SaveSeries(Serie[] Series)
        {
            return SaveEntity<Serie>(Series);
        }


        #endregion Functions

        #region Properties
        /********************************************** Properties *****************************************************************/

        #endregion Properties

    }
}
