namespace APP_FIKT_ProGrupa
{
    partial class frmPregVrab
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
            this.grdPregVrab = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPregVrab)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPregVrab
            // 
            this.grdPregVrab.AllowUserToAddRows = false;
            this.grdPregVrab.AllowUserToDeleteRows = false;
            this.grdPregVrab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPregVrab.Location = new System.Drawing.Point(12, 38);
            this.grdPregVrab.Name = "grdPregVrab";
            this.grdPregVrab.Size = new System.Drawing.Size(294, 158);
            this.grdPregVrab.TabIndex = 0;
            this.grdPregVrab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPregVrab_CellContentClick);
            // 
            // frmPregVrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 320);
            this.Controls.Add(this.grdPregVrab);
            this.Name = "frmPregVrab";
            this.Text = "Прегледај Вработени";
            this.Load += new System.EventHandler(this.frmPregVrab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPregVrab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPregVrab;
    }
}