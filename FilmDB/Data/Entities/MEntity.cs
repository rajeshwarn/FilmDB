using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDB.Data.Entities
{
    public class MEntity : Entity
    {
        #region Properties
        /********************************************** Properties *****************************************************************/

        public string Titel { get; set; }
        public string Omschrijving { get; set; }
        public string IMDBCijfer { get; set; }
        public string IMDBLink { get; set; }
        public bool Historisch { get; set; }
        public bool Afgewezen { get; set; }

        #endregion Properties

    }
}
