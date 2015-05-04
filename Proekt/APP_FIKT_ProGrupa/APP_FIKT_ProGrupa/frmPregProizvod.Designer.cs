namespace APP_FIKT_ProGrupa
{
    partial class frmPregProizvod
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
            this.grdPregProizvod = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPregProizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPregProizvod
            // 
            this.grdPregProizvod.AllowUserToAddRows = false;
            this.grdPregProizvod.AllowUserToDeleteRows = false;
            this.grdPregProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPregProizvod.Location = new System.Drawing.Point(31, 35);
            this.grdPregProizvod.Name = "grdPregProizvod";
            this.grdPregProizvod.Size = new System.Drawing.Size(240, 150);
            this.grdPregProizvod.TabIndex = 0;
            this.grdPregProizvod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPregProizvod_CellContentClick);
            // 
            // frmPregProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.grdPregProizvod);
            this.Name = "frmPregProizvod";
            this.Text = "frmPregProizvod";
            this.Load += new System.EventHandler(this.frmPregProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPregProizvod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPregProizvod;
    }
}