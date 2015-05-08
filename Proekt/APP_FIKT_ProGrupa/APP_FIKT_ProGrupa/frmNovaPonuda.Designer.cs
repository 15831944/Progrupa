namespace APP_FIKT_ProGrupa
{
    partial class frmNovaPonuda
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
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.dtVaznost = new System.Windows.Forms.DateTimePicker();
            this.cmbKlient = new System.Windows.Forms.ComboBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTemp
            // 
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(12, 12);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(121, 21);
            this.cmbTemp.TabIndex = 0;
            // 
            // dtVaznost
            // 
            this.dtVaznost.Location = new System.Drawing.Point(12, 66);
            this.dtVaznost.Name = "dtVaznost";
            this.dtVaznost.Size = new System.Drawing.Size(200, 20);
            this.dtVaznost.TabIndex = 2;
            // 
            // cmbKlient
            // 
            this.cmbKlient.FormattingEnabled = true;
            this.cmbKlient.Location = new System.Drawing.Point(12, 39);
            this.cmbKlient.Name = "cmbKlient";
            this.cmbKlient.Size = new System.Drawing.Size(121, 21);
            this.cmbKlient.TabIndex = 1;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(12, 147);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(75, 23);
            this.btnKreiraj.TabIndex = 3;
            this.btnKreiraj.Text = "button1";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // frmNovaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 262);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.cmbKlient);
            this.Controls.Add(this.dtVaznost);
            this.Controls.Add(this.cmbTemp);
            this.Name = "frmNovaPonuda";
            this.Text = "frmNovaPonuda";
            this.Load += new System.EventHandler(this.frmNovaPonuda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTemp;
        private System.Windows.Forms.DateTimePicker dtVaznost;
        private System.Windows.Forms.ComboBox cmbKlient;
        private System.Windows.Forms.Button btnKreiraj;
    }
}