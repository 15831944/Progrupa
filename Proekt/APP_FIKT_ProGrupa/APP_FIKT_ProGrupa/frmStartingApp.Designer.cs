namespace APP_FIKT_ProGrupa
{
    partial class frmStartingApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartingApp));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMentor = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblIzrabotil1 = new System.Windows.Forms.Label();
            this.lblIzrabotil2 = new System.Windows.Forms.Label();
            this.lblIzrabotil3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMentor
            // 
            this.lblMentor.AutoSize = true;
            this.lblMentor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblMentor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMentor.Location = new System.Drawing.Point(81, 240);
            this.lblMentor.Name = "lblMentor";
            this.lblMentor.Size = new System.Drawing.Size(194, 13);
            this.lblMentor.TabIndex = 0;
            this.lblMentor.Text = "Ментор: д-р Елена Влаху-Ѓоргиевска";
            this.lblMentor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblFirma.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFirma.Location = new System.Drawing.Point(170, 240);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(102, 13);
            this.lblFirma.TabIndex = 1;
            this.lblFirma.Text = "Фирма: Про Група";
            this.lblFirma.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFirma.Visible = false;
            // 
            // lblIzrabotil1
            // 
            this.lblIzrabotil1.AutoSize = true;
            this.lblIzrabotil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblIzrabotil1.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIzrabotil1.Location = new System.Drawing.Point(104, 214);
            this.lblIzrabotil1.Name = "lblIzrabotil1";
            this.lblIzrabotil1.Size = new System.Drawing.Size(168, 13);
            this.lblIzrabotil1.TabIndex = 2;
            this.lblIzrabotil1.Text = "Изработиле: Златко Петковски";
            this.lblIzrabotil1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblIzrabotil1.Visible = false;
            // 
            // lblIzrabotil2
            // 
            this.lblIzrabotil2.AutoSize = true;
            this.lblIzrabotil2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblIzrabotil2.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIzrabotil2.Location = new System.Drawing.Point(159, 227);
            this.lblIzrabotil2.Name = "lblIzrabotil2";
            this.lblIzrabotil2.Size = new System.Drawing.Size(113, 13);
            this.lblIzrabotil2.TabIndex = 3;
            this.lblIzrabotil2.Text = "??Тоде Ангелоски??";
            this.lblIzrabotil2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblIzrabotil2.Visible = false;
            // 
            // lblIzrabotil3
            // 
            this.lblIzrabotil3.AutoSize = true;
            this.lblIzrabotil3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblIzrabotil3.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIzrabotil3.Location = new System.Drawing.Point(154, 240);
            this.lblIzrabotil3.Name = "lblIzrabotil3";
            this.lblIzrabotil3.Size = new System.Drawing.Size(118, 13);
            this.lblIzrabotil3.TabIndex = 4;
            this.lblIzrabotil3.Text = "Христина Тренчевска";
            this.lblIzrabotil3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblIzrabotil3.Visible = false;
            // 
            // frmStartingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblIzrabotil3);
            this.Controls.Add(this.lblIzrabotil2);
            this.Controls.Add(this.lblIzrabotil1);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.lblMentor);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStartingApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStartingApp";
            this.Load += new System.EventHandler(this.frmStartingApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMentor;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblIzrabotil1;
        private System.Windows.Forms.Label lblIzrabotil2;
        private System.Windows.Forms.Label lblIzrabotil3;
    }
}

