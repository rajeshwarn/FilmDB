using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmDB.Algemeen;
using FilmDB.Data.DB;
using FilmDB.Data.Entities;
using System.IO;
using Janus.Windows.GridEX;

namespace FilmDB
{
    public partial class FormMain : Form
    {
        #region Variables
        /********************************************** Variables ******************************************************************/

        private FormSeries m_FormSeries = null;

        #endregion Variables

        #region Constructor, Load & Closing
        /********************************************** Constructor, Load & Closing ************************************************/

        public FormMain()
        {
            InitializeComponent();
            Init();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            m_FormSeries.Show();           
        }

        private void Init()
        {
            sGlobals.DB_File = Path.Combine(@"G:\", "FDB", "FDB.sqlite");
            sGlobals.DB_Connected = DBConnect.ConnectDB();

            try
            {
                List<Serie> mySeries = sGlobals.DB.Series.ToList();
                List<Film> myFilms = sGlobals.DB.Films.ToList();
                List<Instelling> myInstellingen = sGlobals.DB.Instellingen.ToList();
            }
            catch (Exception ex)
            {
                ErrorDump.AddError("FormMain.cs", "Init", ex);
            }

            //tcTab.SelectedTab = tabFilm;

            try
            {
                m_FormSeries = new FormSeries();
                m_FormSeries.TopLevel = false;
                m_FormSeries.WindowState = FormWindowState.Maximized;
                pnlSeries.Controls.Add(m_FormSeries);
            }
            catch (Exception ex)
            {
                ErrorDump.AddError("FormMain.cs", "Shown", ex);
            }
        }

        #endregion Constructor, Load & Closing





        #region Button Events
        /********************************************** Button Events **************************************************************/

        #endregion Button Events

        #region Control Events
        /********************************************** Control Events *************************************************************/

        #endregion Control Events

        #region Functions
        /********************************************** Functions ******************************************************************/

        #endregion Functions

        #region Properties
        /********************************************** Properties *****************************************************************/

        #endregion Properties
    }
}
