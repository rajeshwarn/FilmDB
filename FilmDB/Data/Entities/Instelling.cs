using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmDB.Data.Entities
{
    public class Instelling : Entity
    {
        #region Properties
        /********************************************** Properties *****************************************************************/

        public string Setting { get; set; }
        public string Waarde { get; set; }

        #endregion Properties

    }
}
