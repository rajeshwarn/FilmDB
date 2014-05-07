namespace FilmDB
{
    partial class FormMain
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
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tabSeries = new System.Windows.Forms.TabPage();
            this.tabFilms = new System.Windows.Forms.TabPage();
            this.pnlSeries = new System.Windows.Forms.Panel();
            this.tcTabs.SuspendLayout();
            this.tabSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tabSeries);
            this.tcTabs.Controls.Add(this.tabFilms);
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(1131, 706);
            this.tcTabs.TabIndex = 3;
            // 
            // tabSeries
            // 
            this.tabSeries.Controls.Add(this.pnlSeries);
            this.tabSeries.Location = new System.Drawing.Point(4, 22);
            this.tabSeries.Name = "tabSeries";
            this.tabSeries.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeries.Size = new System.Drawing.Size(1123, 680);
            this.tabSeries.TabIndex = 0;
            this.tabSeries.Text = "Series";
            this.tabSeries.UseVisualStyleBackColor = true;
            // 
            // tabFilms
            // 
            this.tabFilms.Location = new System.Drawing.Point(4, 22);
            this.tabFilms.Name = "tabFilms";
            this.tabFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilms.Size = new System.Drawing.Size(192, 74);
            this.tabFilms.TabIndex = 1;
            this.tabFilms.Text = "Films";
            this.tabFilms.UseVisualStyleBackColor = true;
            // 
            // pnlSeries
            // 
            this.pnlSeries.BackColor = System.Drawing.Color.Transparent;
            this.pnlSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeries.Location = new System.Drawing.Point(3, 3);
            this.pnlSeries.Name = "pnlSeries";
            this.pnlSeries.Size = new System.Drawing.Size(1117, 674);
            this.pnlSeries.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 706);
            this.Controls.Add(this.tcTabs);
            this.Name = "FormMain";
            this.Text = "FDB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tcTabs.ResumeLayout(false);
            this.tabSeries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tabSeries;
        private System.Windows.Forms.Panel pnlSeries;
        private System.Windows.Forms.TabPage tabFilms;


    }
}