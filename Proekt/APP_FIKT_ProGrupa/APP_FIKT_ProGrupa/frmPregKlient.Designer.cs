namespace APP_FIKT_ProGrupa
{
    partial class frmPregKlient
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
            this.grdPregKlient = new System.Windows.Forms.DataGridView();
            this.grdPregLicaKontakt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPregKlient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPregLicaKontakt)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPregKlient
            // 
            this.grdPregKlient.AllowUserToAddRows = false;
            this.grdPregKlient.AllowUserToDeleteRows = false;
            this.grdPregKlient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPregKlient.Location = new System.Drawing.Point(12, 45);
            this.grdPregKlient.Name = "grdPregKlient";
            this.grdPregKlient.Size = new System.Drawing.Size(538, 150);
            this.grdPregKlient.TabIndex = 0;
            this.grdPregKlient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPregKlient_CellContentClick);
            // 
            // grdPregLicaKontakt
            // 
            this.grdPregLicaKontakt.AllowUserToDeleteRows = false;
            this.grdPregLicaKontakt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPregLicaKontakt.Location = new System.Drawing.Point(12, 251);
            this.grdPregLicaKontakt.Name = "grdPregLicaKontakt";
            this.grdPregLicaKontakt.Size = new System.Drawing.Size(538, 150);
            this.grdPregLicaKontakt.TabIndex = 1;
            this.grdPregLicaKontakt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPregLicaKontakt_CellContentClick);
            // 
            // frmPregKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 413);
            this.Controls.Add(this.grdPregLicaKontakt);
            this.Controls.Add(this.grdPregKlient);
            this.Name = "frmPregKlient";
            this.Text = "frmPregKlient";
            this.Load += new System.EventHandler(this.frmPregKlient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPregKlient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPregLicaKontakt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPregKlient;
        private System.Windows.Forms.DataGridView grdPregLicaKontakt;
    }
}