using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDB.Data.Entities
{
    public class Serie : MEntity
    {
        #region Properties
        /********************************************** Properties *****************************************************************/

        public bool Huidig { get; set; }
        public int HuidigSeizoen { get; set; }
        public bool HuidigSeizoenKlaar { get; set; }
        public int HuidigAflevering { get; set; }
        public bool Komedie { get; set; }

        #endregion Properties

    }
}
