namespace FilmDB
{
    partial class FormSeries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout geSeries_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeries));
            this.geSeries = new Janus.Windows.GridEX.GridEX();
            this.pnlSerieDetail = new System.Windows.Forms.Panel();
            this.chkAfgewezen = new Janus.Windows.EditControls.UICheckBox();
            this.chkHistorisch = new Janus.Windows.EditControls.UICheckBox();
            this.chkKomedie = new Janus.Windows.EditControls.UICheckBox();
            this.chkHuidigSeizoenKlaar = new Janus.Windows.EditControls.UICheckBox();
            this.lblHuidigAflevering = new System.Windows.Forms.Label();
            this.txtHuidigeAflevering = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblHuidigSeizoen = new System.Windows.Forms.Label();
            this.txtHuidigSeizoen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCijfer = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.chkHuidig = new Janus.Windows.EditControls.UICheckBox();
            this.btnLink = new DevComponents.DotNetBar.ButtonX();
            this.txtCijfer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLink = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rtbOmschrijving = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.txtTitel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnlSerieKnoppen = new System.Windows.Forms.Panel();
            this.btnToevoegen = new DevComponents.DotNetBar.ButtonX();
            this.btnWijzigen = new DevComponents.DotNetBar.ButtonX();
            this.btnAnnuleren = new DevComponents.DotNetBar.ButtonX();
            this.btnOpslaan = new DevComponents.DotNetBar.ButtonX();
            this.pnlSerieFilter = new System.Windows.Forms.Panel();
            this.chkFilterHistorisch = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkFilterAfgewezen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkFilterKomedie = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkFilterHuidig = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.geSeries)).BeginInit();
            this.pnlSerieDetail.SuspendLayout();
            this.pnlSerieKnoppen.SuspendLayout();
            this.pnlSerieFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // geSeries
            // 
            this.geSeries.AllowColumnDrag = false;
            this.geSeries.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.geSeries.ColumnAutoResize = true;
            geSeries_DesignTimeLayout.LayoutString = resources.GetString("geSeries_DesignTimeLayout.LayoutString");
            this.geSeries.DesignTimeLayout = geSeries_DesignTimeLayout;
            this.geSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geSeries.FilterMode = Janus.Windows.GridEX.FilterMode.Manual;
            this.geSeries.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.geSeries.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.geSeries.GroupByBoxVisible = false;
            this.geSeries.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.geSeries.Location = new System.Drawing.Point(0, 57);
            this.geSeries.Name = "geSeries";
            this.geSeries.Size = new System.Drawing.Size(304, 536);
            this.geSeries.TabIndex = 6;
            this.geSeries.SelectionChanged += new System.EventHandler(this.geSeries_SelectionChanged);
            // 
            // pnlSerieDetail
            // 
            this.pnlSerieDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlSerieDetail.Controls.Add(this.chkAfgewezen);
            this.pnlSerieDetail.Controls.Add(this.chkHistorisch);
            this.pnlSerieDetail.Controls.Add(this.chkKomedie);
            this.pnlSerieDetail.Controls.Add(this.chkHuidigSeizoenKlaar);
            this.pnlSerieDetail.Controls.Add(this.lblHuidigAflevering);
            this.pnlSerieDetail.Controls.Add(this.txtHuidigeAflevering);
            this.pnlSerieDetail.Controls.Add(this.lblHuidigSeizoen);
            this.pnlSerieDetail.Controls.Add(this.txtHuidigSeizoen);
            this.pnlSerieDetail.Controls.Add(this.lblCijfer);
            this.pnlSerieDetail.Controls.Add(this.lblLink);
            this.pnlSerieDetail.Controls.Add(this.lblOmschrijving);
            this.pnlSerieDetail.Controls.Add(this.lblTitel);
            this.pnlSerieDetail.Controls.Add(this.chkHuidig);
            this.pnlSerieDetail.Controls.Add(this.btnLink);
            this.pnlSerieDetail.Controls.Add(this.txtCijfer);
            this.pnlSerieDetail.Controls.Add(this.txtLink);
            this.pnlSerieDetail.Controls.Add(this.rtbOmschrijving);
            this.pnlSerieDetail.Controls.Add(this.txtTitel);
            this.pnlSerieDetail.Controls.Add(this.pnlSerieKnoppen);
            this.pnlSerieDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSerieDetail.Location = new System.Drawing.Point(304, 57);
            this.pnlSerieDetail.Name = "pnlSerieDetail";
            this.pnlSerieDetail.Size = new System.Drawing.Size(710, 536);
            this.pnlSerieDetail.TabIndex = 5;
            // 
            // chkAfgewezen
            // 
            this.chkAfgewezen.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkAfgewezen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkAfgewezen.Location = new System.Drawing.Point(8, 419);
            this.chkAfgewezen.Name = "chkAfgewezen";
            this.chkAfgewezen.ShowFocusRectangle = false;
            this.chkAfgewezen.Size = new System.Drawing.Size(136, 18);
            this.chkAfgewezen.TabIndex = 31;
            this.chkAfgewezen.Text = "Afgewezen";
            this.chkAfgewezen.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.chkAfgewezen.CheckedChanged += new System.EventHandler(this.EditCheckedChanged);
            // 
            // chkHistorisch
            // 
            this.chkHistorisch.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkHistorisch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkHistorisch.Location = new System.Drawing.Point(8, 395);
            this.chkHistorisch.Name = "chkHistorisch";
            this.chkHistorisch.ShowFocusRectangle = false;
            this.chkHistorisch.Size = new System.Drawing.Size(136, 18);
            this.chkHistorisch.TabIndex = 30;
            this.chkHistorisch.Text = "Historisch";
            this.chkHistorisch.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.chkHistorisch.CheckedChanged += new System.EventHandler(this.EditCheckedChanged);
            // 
            // chkKomedie
            // 
            this.chkKomedie.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkKomedie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkKomedie.Location = new System.Drawing.Point(8, 353);
            this.chkKomedie.Name = "chkKomedie";
            this.chkKomedie.ShowFocusRectangle = false;
            this.chkKomedie.Size = new System.Drawing.Size(136, 18);
            this.chkKomedie.TabIndex = 29;
            this.chkKomedie.Text = "Komedie";
            this.chkKomedie.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.chkKomedie.CheckedChanged += new System.EventHandler(this.EditCheckedChanged);
            // 
            // chkHuidigSeizoenKlaar
            // 
            this.chkHuidigSeizoenKlaar.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkHuidigSeizoenKlaar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkHuidigSeizoenKlaar.Location = new System.Drawing.Point(8, 312);
            this.chkHuidigSeizoenKlaar.Name = "chkHuidigSeizoenKlaar";
            this.chkHuidigSeizoenKlaar.ShowFocusRectangle = false;
            this.chkHuidigSeizoenKlaar.Size = new System.Drawing.Size(136, 18);
            this.chkHuidigSeizoenKlaar.TabIndex = 28;
            this.chkHuidigSeizoenKlaar.Text = "Huidig seizoen klaar";
            this.chkHuidigSeizoenKlaar.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.chkHuidigSeizoenKlaar.CheckedChanged += new System.EventHandler(this.EditCheckedChanged);
            // 
            // lblHuidigAflevering
            // 
            this.lblHuidigAflevering.AutoSize = true;
            this.lblHuidigAflevering.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHuidigAflevering.Location = new System.Drawing.Point(7, 290);
            this.lblHuidigAflevering.Name = "lblHuidigAflevering";
            this.lblHuidigAflevering.Size = new System.Drawing.Size(92, 13);
            this.lblHuidigAflevering.TabIndex = 26;
            this.lblHuidigAflevering.Text = "Huidige aflevering";
            // 
            // txtHuidigeAflevering
            // 
            // 
            // 
            // 
            this.txtHuidigeAflevering.Border.Class = "TextBoxBorder";
            this.txtHuidigeAflevering.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHuidigeAflevering.Location = new System.Drawing.Point(130, 285);
            this.txtHuidigeAflevering.Name = "txtHuidigeAflevering";
            this.txtHuidigeAflevering.PreventEnterBeep = true;
            this.txtHuidigeAflevering.ReadOnly = true;
            this.txtHuidigeAflevering.Size = new System.Drawing.Size(46, 20);
            this.txtHuidigeAflevering.TabIndex = 25;
            // 
            // lblHuidigSeizoen
            // 
            this.lblHuidigSeizoen.AutoSize = true;
            this.lblHuidigSeizoen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHuidigSeizoen.Location = new System.Drawing.Point(7, 263);
            this.lblHuidigSeizoen.Name = "lblHuidigSeizoen";
            this.lblHuidigSeizoen.Size = new System.Drawing.Size(76, 13);
            this.lblHuidigSeizoen.TabIndex = 24;
            this.lblHuidigSeizoen.Text = "Huidig seizoen";
            // 
            // txtHuidigSeizoen
            // 
            // 
            // 
            // 
            this.txtHuidigSeizoen.Border.Class = "TextBoxBorder";
            this.txtHuidigSeizoen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHuidigSeizoen.Location = new System.Drawing.Point(130, 258);
            this.txtHuidigSeizoen.Name = "txtHuidigSeizoen";
            this.txtHuidigSeizoen.PreventEnterBeep = true;
            this.txtHuidigSeizoen.ReadOnly = true;
            this.txtHuidigSeizoen.Size = new System.Drawing.Size(46, 20);
            this.txtHuidigSeizoen.TabIndex = 23;
            // 
            // lblCijfer
            // 
            this.lblCijfer.AutoSize = true;
            this.lblCijfer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCijfer.Location = new System.Drawing.Point(7, 195);
            this.lblCijfer.Name = "lblCijfer";
            this.lblCijfer.Size = new System.Drawing.Size(30, 13);
            this.lblCijfer.TabIndex = 22;
            this.lblCijfer.Text = "Cijfer";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLink.Location = new System.Drawing.Point(7, 166);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 21;
            this.lblLink.Text = "Link";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOmschrijving.Location = new System.Drawing.Point(7, 42);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(67, 13);
            this.lblOmschrijving.TabIndex = 20;
            this.lblOmschrijving.Text = "Omschrijving";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitel.Location = new System.Drawing.Point(7, 14);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(27, 13);
            this.lblTitel.TabIndex = 19;
            this.lblTitel.Text = "Titel";
            // 
            // chkHuidig
            // 
            this.chkHuidig.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkHuidig.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkHuidig.Location = new System.Drawing.Point(8, 230);
            this.chkHuidig.Name = "chkHuidig";
            this.chkHuidig.ShowFocusRectangle = false;
            this.chkHuidig.Size = new System.Drawing.Size(136, 18);
            this.chkHuidig.TabIndex = 18;
            this.chkHuidig.Text = "Huidig";
            this.chkHuidig.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.chkHuidig.CheckedChanged += new System.EventHandler(this.EditCheckedChanged);
            // 
            // btnLink
            // 
            this.btnLink.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLink.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLink.Enabled = false;
            this.btnLink.Location = new System.Drawing.Point(679, 162);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(22, 20);
            this.btnLink.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLink.TabIndex = 12;
            this.btnLink.Text = "..";
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // txtCijfer
            // 
            // 
            // 
            // 
            this.txtCijfer.Border.Class = "TextBoxBorder";
            this.txtCijfer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCijfer.Location = new System.Drawing.Point(130, 190);
            this.txtCijfer.Name = "txtCijfer";
            this.txtCijfer.PreventEnterBeep = true;
            this.txtCijfer.ReadOnly = true;
            this.txtCijfer.Size = new System.Drawing.Size(46, 20);
            this.txtCijfer.TabIndex = 11;
            // 
            // txtLink
            // 
            this.txtLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtLink.Border.Class = "TextBoxBorder";
            this.txtLink.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLink.Location = new System.Drawing.Point(130, 162);
            this.txtLink.Name = "txtLink";
            this.txtLink.PreventEnterBeep = true;
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(542, 20);
            this.txtLink.TabIndex = 9;
            // 
            // rtbOmschrijving
            // 
            this.rtbOmschrijving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.rtbOmschrijving.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtbOmschrijving.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtbOmschrijving.Location = new System.Drawing.Point(130, 41);
            this.rtbOmschrijving.Name = "rtbOmschrijving";
            this.rtbOmschrijving.ReadOnly = true;
            this.rtbOmschrijving.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.rtbOmschrijving.Size = new System.Drawing.Size(571, 113);
            this.rtbOmschrijving.TabIndex = 7;
            // 
            // txtTitel
            // 
            this.txtTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTitel.Border.Class = "TextBoxBorder";
            this.txtTitel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTitel.Location = new System.Drawing.Point(130, 12);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.PreventEnterBeep = true;
            this.txtTitel.ReadOnly = true;
            this.txtTitel.Size = new System.Drawing.Size(571, 20);
            this.txtTitel.TabIndex = 4;
            this.txtTitel.TextChanged += new System.EventHandler(this.VeldChanged);
            // 
            // pnlSerieKnoppen
            // 
            this.pnlSerieKnoppen.BackColor = System.Drawing.Color.Transparent;
            this.pnlSerieKnoppen.Controls.Add(this.btnToevoegen);
            this.pnlSerieKnoppen.Controls.Add(this.btnWijzigen);
            this.pnlSerieKnoppen.Controls.Add(this.btnAnnuleren);
            this.pnlSerieKnoppen.Controls.Add(this.btnOpslaan);
            this.pnlSerieKnoppen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSerieKnoppen.Location = new System.Drawing.Point(0, 502);
            this.pnlSerieKnoppen.Name = "pnlSerieKnoppen";
            this.pnlSerieKnoppen.Size = new System.Drawing.Size(710, 34);
            this.pnlSerieKnoppen.TabIndex = 2;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnToevoegen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnToevoegen.Location = new System.Drawing.Point(7, 5);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWijzigen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWijzigen.Enabled = false;
            this.btnWijzigen.Location = new System.Drawing.Point(88, 5);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnWijzigen.TabIndex = 2;
            this.btnWijzigen.Text = "Wijzigen";
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAnnuleren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuleren.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAnnuleren.Enabled = false;
            this.btnAnnuleren.Location = new System.Drawing.Point(547, 5);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleren.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAnnuleren.TabIndex = 1;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOpslaan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpslaan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOpslaan.Enabled = false;
            this.btnOpslaan.Location = new System.Drawing.Point(628, 5);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOpslaan.TabIndex = 0;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // pnlSerieFilter
            // 
            this.pnlSerieFilter.BackColor = System.Drawing.Color.Transparent;
            this.pnlSerieFilter.Controls.Add(this.chkFilterHistorisch);
            this.pnlSerieFilter.Controls.Add(this.chkFilterAfgewezen);
            this.pnlSerieFilter.Controls.Add(this.chkFilterKomedie);
            this.pnlSerieFilter.Controls.Add(this.chkFilterHuidig);
            this.pnlSerieFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSerieFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlSerieFilter.Name = "pnlSerieFilter";
            this.pnlSerieFilter.Size = new System.Drawing.Size(1014, 57);
            this.pnlSerieFilter.TabIndex = 4;
            // 
            // chkFilterHistorisch
            // 
            this.chkFilterHistorisch.AutoSize = true;
            // 
            // 
            // 
            this.chkFilterHistorisch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFilterHistorisch.FocusCuesEnabled = false;
            this.chkFilterHistorisch.Location = new System.Drawing.Point(137, 8);
            this.chkFilterHistorisch.Name = "chkFilterHistorisch";
            this.chkFilterHistorisch.Size = new System.Drawing.Size(71, 15);
            this.chkFilterHistorisch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFilterHistorisch.TabIndex = 3;
            this.chkFilterHistorisch.Text = "Historisch";
            this.chkFilterHistorisch.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkFilterAfgewezen
            // 
            this.chkFilterAfgewezen.AutoSize = true;
            // 
            // 
            // 
            this.chkFilterAfgewezen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFilterAfgewezen.FocusCuesEnabled = false;
            this.chkFilterAfgewezen.Location = new System.Drawing.Point(137, 29);
            this.chkFilterAfgewezen.Name = "chkFilterAfgewezen";
            this.chkFilterAfgewezen.Size = new System.Drawing.Size(77, 15);
            this.chkFilterAfgewezen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFilterAfgewezen.TabIndex = 2;
            this.chkFilterAfgewezen.Text = "Afgewezen";
            this.chkFilterAfgewezen.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkFilterKomedie
            // 
            this.chkFilterKomedie.AutoSize = true;
            // 
            // 
            // 
            this.chkFilterKomedie.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFilterKomedie.FocusCuesEnabled = false;
            this.chkFilterKomedie.Location = new System.Drawing.Point(14, 29);
            this.chkFilterKomedie.Name = "chkFilterKomedie";
            this.chkFilterKomedie.Size = new System.Drawing.Size(66, 15);
            this.chkFilterKomedie.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFilterKomedie.TabIndex = 1;
            this.chkFilterKomedie.Text = "Komedie";
            this.chkFilterKomedie.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkFilterHuidig
            // 
            this.chkFilterHuidig.AutoSize = true;
            // 
            // 
            // 
            this.chkFilterHuidig.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFilterHuidig.FocusCuesEnabled = false;
            this.chkFilterHuidig.Location = new System.Drawing.Point(14, 8);
            this.chkFilterHuidig.Name = "chkFilterHuidig";
            this.chkFilterHuidig.Size = new System.Drawing.Size(54, 15);
            this.chkFilterHuidig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFilterHuidig.TabIndex = 0;
            this.chkFilterHuidig.Text = "Huidig";
            this.chkFilterHuidig.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // FormSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1014, 593);
            this.ControlBox = false;
            this.Controls.Add(this.geSeries);
            this.Controls.Add(this.pnlSerieDetail);
            this.Controls.Add(this.pnlSerieFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSeries";
            this.Text = "FormSeries";
            this.Load += new System.EventHandler(this.FormSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geSeries)).EndInit();
            this.pnlSerieDetail.ResumeLayout(false);
            this.pnlSerieDetail.PerformLayout();
            this.pnlSerieKnoppen.ResumeLayout(false);
            this.pnlSerieFilter.ResumeLayout(false);
            this.pnlSerieFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX geSeries;
        private System.Windows.Forms.Panel pnlSerieDetail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitel;
        private System.Windows.Forms.Panel pnlSerieKnoppen;
        private DevComponents.DotNetBar.ButtonX btnToevoegen;
        private DevComponents.DotNetBar.ButtonX btnWijzigen;
        private DevComponents.DotNetBar.ButtonX btnAnnuleren;
        private DevComponents.DotNetBar.ButtonX btnOpslaan;
        private System.Windows.Forms.Panel pnlSerieFilter;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFilterHistorisch;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFilterAfgewezen;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFilterKomedie;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFilterHuidig;
        private DevComponents.DotNetBar.ButtonX btnLink;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCijfer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLink;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtbOmschrijving;
        private Janus.Windows.EditControls.UICheckBox chkHuidigSeizoenKlaar;
        private System.Windows.Forms.Label lblHuidigAflevering;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHuidigeAflevering;
        private System.Windows.Forms.Label lblHuidigSeizoen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHuidigSeizoen;
        private System.Windows.Forms.Label lblCijfer;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblTitel;
        private Janus.Windows.EditControls.UICheckBox chkHuidig;
        private Janus.Windows.EditControls.UICheckBox chkAfgewezen;
        private Janus.Windows.EditControls.UICheckBox chkHistorisch;
        private Janus.Windows.EditControls.UICheckBox chkKomedie;
    }
}