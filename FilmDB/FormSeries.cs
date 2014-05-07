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
    public partial class FormSeries : Form
    {
        #region Variables
        /********************************************** Variables ******************************************************************/

        public enum EditMode
        {
            New,
            Edit,
            None
        }

        private EditMode m_EditMode = EditMode.None;

        private bool m_Changed = false;

        private Serie m_HuidigeSerie = null;

        private bool m_IgnoreCheck = false;

        #endregion Variables

        #region Constructor, Load & Closing
        /********************************************** Constructor, Load & Closing ************************************************/

        public FormSeries()
        {
            InitializeComponent();
            RefreshSeries();
        }


        private void FormSeries_Load(object sender, EventArgs e)
        {

        }

        #endregion Constructor, Load & Closing

        #region Button Events
        /********************************************** Button Events **************************************************************/

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Toevoegen();
        }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            Wijzigen();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Annuleren();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Opslaan();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            OpenLink();
        }

        #endregion Button Events

        #region Control Events
        /********************************************** Control Events *************************************************************/

        private void VeldChanged(object sender, EventArgs e)
        {
            m_Changed = true;
            SetButtons();
        }

        private void geSeries_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            RefreshSeries();
        }



        private void chkHuidig_CheckedChanged(object sender, EventArgs e)
        {
            /*
            txtHuidigSeizoen.Enabled =
            txtHuidigeAflevering.Enabled =
            chkHuidigSeizoenKlaar.Enabled =
                chkHuidig.Checked && m_EditMode != EditMode.None;
            */

        }

        private void chkAfgewezen_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (chkAfgewezen.Checked)
            {
                chkHistorisch.Checked = true;
            }
            */

        }

        private void EditCheckedChanged(object sender, EventArgs e)
        {
            Janus.Windows.EditControls.UICheckBox myCheckBox = (Janus.Windows.EditControls.UICheckBox)sender;

            if (!m_IgnoreCheck && m_EditMode == EditMode.None)
            {               
                myCheckBox.CheckedChanged -= EditCheckedChanged;

                myCheckBox.Checked = !myCheckBox.Checked;

                myCheckBox.CheckedChanged += EditCheckedChanged;
            }
            else
            {
                if (m_EditMode != EditMode.None)
                {
                    if (myCheckBox.Name == "chkAfgewezen" && myCheckBox.Checked)
                    {
                        chkHistorisch.Checked = true;
                    }
                }

                if (myCheckBox.Name == "chkHuidig" && !myCheckBox.Checked)
                {
                    chkHuidigSeizoenKlaar.Checked = false;
                    txtHuidigSeizoen.Text = "0";
                    txtHuidigeAflevering.Text = "0";
                }

                m_Changed = true;
            }
        }

        #endregion Control Events

        #region Functions
        /********************************************** Functions ******************************************************************/

        private void RefreshSeries()
        {
            Int64 myID = -10;

            if (!OnFilterRow() && geSeries.CurrentRow != null)
            {
                myID = Convert.ToInt64(geSeries.CurrentRow.Cells["ID"].Value);
            }

            geSeries.DataSource = null;

            if (sGlobals.DB_Connected)
            {
                List<Serie> mySeries = new List<Serie>();

                if (chkFilterHuidig.Checked || chkFilterKomedie.Checked)
                {
                    mySeries = sGlobals.DB.Series.Where(s => s.Huidig == chkFilterHuidig.Checked && s.Komedie == chkFilterKomedie.Checked && s.Historisch == chkFilterHistorisch.Checked && s.Afgewezen == chkFilterAfgewezen.Checked).ToList();
                }
                else
                {
                    mySeries = sGlobals.DB.Series.Where(s => s.Historisch == chkFilterHistorisch.Checked && s.Afgewezen == chkFilterAfgewezen.Checked).ToList();
                }

                geSeries.DataSource = mySeries;
                geSeries.SetDataBinding(mySeries, "Series");
            }

            if (geSeries.RowCount > 0)
            {
                if (!geSeries.Find(new GridEXFilterCondition(geSeries.RootTable.Columns["ID"], ConditionOperator.Equal, myID), -1, 1))
                {
                    geSeries.Row = 0;
                }
            }

            geSeries.Focus();
        }

        private void Toevoegen()
        {
            m_HuidigeSerie = new Serie();
            m_HuidigeSerie.Huidig = chkFilterHuidig.Checked;
            m_HuidigeSerie.Komedie = chkFilterKomedie.Checked;
            m_EditMode = EditMode.New;
            LaadHuidigeSerie();

            EnableVelden(true);
            SetButtons();
        }

        private void Wijzigen()
        {
            Int64 myID = Convert.ToInt64(geSeries.CurrentRow.Cells["ID"].Value);

            m_HuidigeSerie = sGlobals.DB.Series.Where(s => s.ID == myID).Single();
            m_EditMode = EditMode.Edit;
            LaadHuidigeSerie();

            EnableVelden(true);
            SetButtons();
        }

        private void Opslaan()
        {
            SaveHuidigeSerie();

            m_HuidigeSerie = null;
            m_EditMode = EditMode.None;

            EnableVelden(false);
            RefreshSeries();
            SetButtons();
        }

        private void Annuleren()
        {
            WisVelden();
            m_HuidigeSerie = null;

            EnableVelden(false);
            m_EditMode = EditMode.None;

            SelectionChanged();
            geSeries.Focus();

            SetButtons();
        }

        private void SetButtons()
        {
            btnToevoegen.Enabled = m_EditMode == EditMode.None;
            btnWijzigen.Enabled = m_EditMode == EditMode.None && !OnFilterRow() && geSeries.CurrentRow != null;
            btnOpslaan.Enabled = btnAnnuleren.Enabled = m_EditMode != EditMode.None && m_Changed;
        }

        private bool OnFilterRow()
        {
            return (geSeries.CurrentRow != null && (geSeries.CurrentRow == geSeries.FilterRow || geSeries.CurrentRow.Position == -2 || geSeries.CurrentRow.Cells["ID"].Value == null || geSeries.CurrentRow.Cells["ID"].Value == DBNull.Value));
        }

        private void LaadHuidigeSerie()
        {
            m_IgnoreCheck = true;

            txtTitel.Text = m_HuidigeSerie.Titel;
            rtbOmschrijving.Text = m_HuidigeSerie.Omschrijving;
            txtLink.Text = m_HuidigeSerie.IMDBLink;
            txtCijfer.Text = m_HuidigeSerie.IMDBCijfer;
            chkHuidig.Checked = m_HuidigeSerie.Huidig;
            //txtHuidigSeizoen.Text = m_HuidigeSerie.HuidigSeizoen == 0 ? "" : m_HuidigeSerie.HuidigSeizoen.ToString();
            //txtHuidigeAflevering.Text = m_HuidigeSerie.HuidigAflevering == 0 ? "" : m_HuidigeSerie.HuidigAflevering.ToString();
            txtHuidigSeizoen.Text = m_HuidigeSerie.HuidigSeizoen.ToString();
            txtHuidigeAflevering.Text = m_HuidigeSerie.HuidigAflevering.ToString();
            chkHuidigSeizoenKlaar.Checked = m_HuidigeSerie.HuidigSeizoenKlaar;
            chkKomedie.Checked = m_HuidigeSerie.Komedie;
            chkHistorisch.Checked = m_HuidigeSerie.Historisch;
            chkAfgewezen.Checked = m_HuidigeSerie.Afgewezen;

            m_IgnoreCheck = false;
        }

        private void SaveHuidigeSerie()
        {
            m_HuidigeSerie.Titel = txtTitel.Text;
            m_HuidigeSerie.Omschrijving = rtbOmschrijving.Text;
            m_HuidigeSerie.IMDBLink = txtLink.Text;
            m_HuidigeSerie.IMDBCijfer = txtCijfer.Text;
            m_HuidigeSerie.Huidig = chkHuidig.Checked;
            //m_HuidigeSerie.HuidigSeizoen = !string.IsNullOrEmpty(txtHuidigSeizoen.Text) ? Convert.ToInt32(txtHuidigSeizoen.Text) : 0;
            //m_HuidigeSerie.HuidigAflevering = !string.IsNullOrEmpty(txtHuidigeAflevering.Text) ? Convert.ToInt32(txtHuidigeAflevering.Text) : 0;
            m_HuidigeSerie.HuidigSeizoen = !string.IsNullOrEmpty(txtHuidigSeizoen.Text) ? Convert.ToInt32(txtHuidigSeizoen.Text) : 0;
            m_HuidigeSerie.HuidigAflevering = !string.IsNullOrEmpty(txtHuidigeAflevering.Text) ? Convert.ToInt32(txtHuidigeAflevering.Text) : 0;
            m_HuidigeSerie.HuidigSeizoenKlaar = chkHuidigSeizoenKlaar.Checked;
            m_HuidigeSerie.Komedie = chkKomedie.Checked;
            m_HuidigeSerie.Historisch = chkHistorisch.Checked;
            m_HuidigeSerie.Afgewezen = chkAfgewezen.Checked;

            DBSave.SaveSerie(m_HuidigeSerie);
        }

        private void EnableVelden(bool Enable)
        {
            /*
            lblTitel.Enabled =
            txtTitel.Enabled =
            lblOmschrijving.Enabled =
            rtbOmschrijving.Enabled =
            lblLink.Enabled =
            txtLink.Enabled =
            lblCijfer.Enabled =
            txtCijfer.Enabled =
            chkHuidig.Enabled =
            lblHuidigSeizoen.Enabled =
            txtHuidigSeizoen.Enabled =
            lblHuidigAflevering.Enabled =
            txtHuidigeAflevering.Enabled =
            chkHuidigSeizoenKlaar.Enabled =
            chkKomedie.Enabled =
            chkHistorisch.Enabled =
            chkAfgewezen.Enabled = 
                Enable;
            */


            txtTitel.ReadOnly =
            rtbOmschrijving.ReadOnly =
            txtLink.ReadOnly =
            txtCijfer.ReadOnly =
            txtHuidigSeizoen.ReadOnly =
            txtHuidigeAflevering.ReadOnly =
                !Enable;


            /*
            chkHuidig.ReadOnly =
            chkKomedie.ReadOnly =
            chkHistorisch.ReadOnly =
            chkAfgewezen.ReadOnly =
            */
                
        }

        private void WisVelden()
        {
            m_IgnoreCheck = true;

            txtTitel.Text =
            rtbOmschrijving.Text = 
            txtLink.Text = 
            txtCijfer.Text = 
            txtHuidigSeizoen.Text =
            txtHuidigeAflevering.Text = 
                "";

            chkHuidig.Checked =
            chkHuidigSeizoenKlaar.Checked =
            chkKomedie.Checked =
            chkHistorisch.Checked =
            chkAfgewezen.Checked =
                false;

            m_Changed = false;
            m_IgnoreCheck = false;
        }

        private void SelectionChanged()
        {
            if (!OnFilterRow() && geSeries.SelectedItems.Count > 0)
            {
                Int64 myID = Convert.ToInt64(geSeries.CurrentRow.Cells["ID"].Value);
                m_HuidigeSerie = sGlobals.DB.Series.Where(s => s.ID == myID).Single();
                LaadHuidigeSerie();
            }
            else
            {
                WisVelden();
            }

            SetButtons();
        }

        private void OpenLink()
        {

        }

        #endregion Functions




        #region Properties
        /********************************************** Properties *****************************************************************/


        #endregion Properties
    }
}
