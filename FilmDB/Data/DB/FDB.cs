using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Data.Common;
using FilmDB.Data.Entities;

namespace FilmDB.Data.DB
{

    [DbConfigurationType(typeof(SQLiteConfiguration))] 
    public class FDB : DbContext
    {
        #region Constructor, Load & Closing
        /********************************************** Constructor, Load & Closing ************************************************/

        public FDB(DbConnection Conn) : base(Conn, true)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        #endregion Constructor, Load & Closing

        #region Functions
        /********************************************** Functions ******************************************************************/

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        #endregion Functions

        #region Entities
        /********************************************** Entities *****************************************************************/

        public DbSet<Film> Films { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Instelling> Instellingen { get; set; }
       
        #endregion Entities


    }

}