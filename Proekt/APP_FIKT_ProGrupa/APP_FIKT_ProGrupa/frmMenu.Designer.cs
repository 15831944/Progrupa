namespace APP_FIKT_ProGrupa
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPonudi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKreirajPonuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPregledajPonuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTemplejtPonuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVraboten = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVnesiVraboten = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPregledajVraboten = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuproizNepotvrdeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuproizPotvrdeni = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPregproizStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPregproizAktivni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPregproizPasivni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuproizAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKlient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVnesiKlient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIzmeniKlient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPregledajKlient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPregledajPonKlient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrikaziIzvKlient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProizvod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVnesiProizvod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrikaziProizvod = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPonudi,
            this.mnuVraboten,
            this.mnuKlient,
            this.mnuProizvod});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "mnuMenu";
            // 
            // mnuPonudi
            // 
            this.mnuPonudi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKreirajPonuda,
            this.mnuPregledajPonuda,
            this.toolStripMenuItem1,
            this.mnuTemplejtPonuda});
            this.mnuPonudi.Name = "mnuPonudi";
            this.mnuPonudi.Size = new System.Drawing.Size(61, 20);
            this.mnuPonudi.Text = "Понуди";
            // 
            // mnuKreirajPonuda
            // 
            this.mnuKreirajPonuda.Name = "mnuKreirajPonuda";
            this.mnuKreirajPonuda.Size = new System.Drawing.Size(179, 22);
            this.mnuKreirajPonuda.Text = "Креирај понуда";
            // 
            // mnuPregledajPonuda
            // 
            this.mnuPregledajPonuda.Name = "mnuPregledajPonuda";
            this.mnuPregledajPonuda.Size = new System.Drawing.Size(179, 22);
            this.mnuPregledajPonuda.Text = "Преглед на понуди";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // mnuTemplejtPonuda
            // 
            this.mnuTemplejtPonuda.Name = "mnuTemplejtPonuda";
            this.mnuTemplejtPonuda.Size = new System.Drawing.Size(179, 22);
            this.mnuTemplejtPonuda.Text = "Темплејти";
            // 
            // mnuVraboten
            // 
            this.mnuVraboten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVnesiVraboten,
            this.mnuPregledajVraboten});
            this.mnuVraboten.Name = "mnuVraboten";
            this.mnuVraboten.Size = new System.Drawing.Size(71, 20);
            this.mnuVraboten.Text = "Вработен";
            // 
            // mnuVnesiVraboten
            // 
            this.mnuVnesiVraboten.Name = "mnuVnesiVraboten";
            this.mnuVnesiVraboten.Size = new System.Drawing.Size(190, 22);
            this.mnuVnesiVraboten.Text = "Внеси вработен";
            this.mnuVnesiVraboten.Click += new System.EventHandler(this.mnuVnesiVraboten_Click);
            // 
            // mnuPregledajVraboten
            // 
            this.mnuPregledajVraboten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuproizNepotvrdeni,
            this.mnuproizPotvrdeni,
            this.toolStripMenuItem3,
            this.mnuPregproizStatus,
            this.mnuproizAll});
            this.mnuPregledajVraboten.Name = "mnuPregledajVraboten";
            this.mnuPregledajVraboten.Size = new System.Drawing.Size(190, 22);
            this.mnuPregledajVraboten.Text = "Прегледај вработени";
            // 
            // mnuproizNepotvrdeni
            // 
            this.mnuproizNepotvrdeni.Name = "mnuproizNepotvrdeni";
            this.mnuproizNepotvrdeni.Size = new System.Drawing.Size(161, 22);
            this.mnuproizNepotvrdeni.Text = "Непотврдени";
            this.mnuproizNepotvrdeni.Click += new System.EventHandler(this.mnuproizNepotvrdeni_Click);
            // 
            // mnuproizPotvrdeni
            // 
            this.mnuproizPotvrdeni.Name = "mnuproizPotvrdeni";
            this.mnuproizPotvrdeni.Size = new System.Drawing.Size(161, 22);
            this.mnuproizPotvrdeni.Text = "Потврдени";
            this.mnuproizPotvrdeni.Click += new System.EventHandler(this.mnuproizPotvrdeni_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuPregproizStatus
            // 
            this.mnuPregproizStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPregproizAktivni,
            this.mnuPregproizPasivni});
            this.mnuPregproizStatus.Name = "mnuPregproizStatus";
            this.mnuPregproizStatus.Size = new System.Drawing.Size(161, 22);
            this.mnuPregproizStatus.Text = "По статус";
            // 
            // mnuPregproizAktivni
            // 
            this.mnuPregproizAktivni.Name = "mnuPregproizAktivni";
            this.mnuPregproizAktivni.Size = new System.Drawing.Size(122, 22);
            this.mnuPregproizAktivni.Text = "Активни";
            this.mnuPregproizAktivni.Click += new System.EventHandler(this.mnuPregproizAktivni_Click);
            // 
            // mnuPregproizPasivni
            // 
            this.mnuPregproizPasivni.Name = "mnuPregproizPasivni";
            this.mnuPregproizPasivni.Size = new System.Drawing.Size(122, 22);
            this.mnuPregproizPasivni.Text = "Пасивни";
            this.mnuPregproizPasivni.Click += new System.EventHandler(this.mnuPregproizPasivni_Click);
            // 
            // mnuproizAll
            // 
            this.mnuproizAll.Name = "mnuproizAll";
            this.mnuproizAll.Size = new System.Drawing.Size(161, 22);
            this.mnuproizAll.Text = "Сите вработени";
            this.mnuproizAll.Click += new System.EventHandler(this.mnuproizAll_Click);
            // 
            // mnuKlient
            // 
            this.mnuKlient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVnesiKlient,
            this.mnuIzmeniKlient,
            this.mnuPregledajKlient,
            this.mnuPregledajPonKlient,
            this.toolStripMenuItem2,
            this.mnuPrikaziIzvKlient});
            this.mnuKlient.Name = "mnuKlient";
            this.mnuKlient.Size = new System.Drawing.Size(58, 20);
            this.mnuKlient.Text = "Клиент";
            // 
            // mnuVnesiKlient
            // 
            this.mnuVnesiKlient.Name = "mnuVnesiKlient";
            this.mnuVnesiKlient.Size = new System.Drawing.Size(239, 22);
            this.mnuVnesiKlient.Text = "Внеси клиент";
            // 
            // mnuIzmeniKlient
            // 
            this.mnuIzmeniKlient.Name = "mnuIzmeniKlient";
            this.mnuIzmeniKlient.Size = new System.Drawing.Size(239, 22);
            this.mnuIzmeniKlient.Text = "Измени клиент";
            // 
            // mnuPregledajKlient
            // 
            this.mnuPregledajKlient.Name = "mnuPregledajKlient";
            this.mnuPregledajKlient.Size = new System.Drawing.Size(239, 22);
            this.mnuPregledajKlient.Text = "Прегледај клиент";
            // 
            // mnuPregledajPonKlient
            // 
            this.mnuPregledajPonKlient.Name = "mnuPregledajPonKlient";
            this.mnuPregledajPonKlient.Size = new System.Drawing.Size(239, 22);
            this.mnuPregledajPonKlient.Text = "Прегледај понуди за клиент";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(236, 6);
            // 
            // mnuPrikaziIzvKlient
            // 
            this.mnuPrikaziIzvKlient.Name = "mnuPrikaziIzvKlient";
            this.mnuPrikaziIzvKlient.Size = new System.Drawing.Size(239, 22);
            this.mnuPrikaziIzvKlient.Text = "Прикажи извештај за клиенти";
            // 
            // mnuProizvod
            // 
            this.mnuProizvod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVnesiProizvod,
            this.mnuPrikaziProizvod});
            this.mnuProizvod.Name = "mnuProizvod";
            this.mnuProizvod.Size = new System.Drawing.Size(73, 20);
            this.mnuProizvod.Text = "Производ";
            // 
            // mnuVnesiProizvod
            // 
            this.mnuVnesiProizvod.Name = "mnuVnesiProizvod";
            this.mnuVnesiProizvod.Size = new System.Drawing.Size(187, 22);
            this.mnuVnesiProizvod.Text = "Внеси производ";
            this.mnuVnesiProizvod.Click += new System.EventHandler(this.mnuVnesiProizvod_Click);
            // 
            // mnuPrikaziProizvod
            // 
            this.mnuPrikaziProizvod.Name = "mnuPrikaziProizvod";
            this.mnuPrikaziProizvod.Size = new System.Drawing.Size(187, 22);
            this.mnuPrikaziProizvod.Text = "Прикажи производи";
            this.mnuPrikaziProizvod.Click += new System.EventHandler(this.mnuPrikaziProizvod_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPonudi;
        private System.Windows.Forms.ToolStripMenuItem mnuKreirajPonuda;
        private System.Windows.Forms.ToolStripMenuItem mnuPregledajPonuda;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuTemplejtPonuda;
        private System.Windows.Forms.ToolStripMenuItem mnuVraboten;
        private System.Windows.Forms.ToolStripMenuItem mnuVnesiVraboten;
        private System.Windows.Forms.ToolStripMenuItem mnuPregledajVraboten;
        private System.Windows.Forms.ToolStripMenuItem mnuKlient;
        private System.Windows.Forms.ToolStripMenuItem mnuVnesiKlient;
        private System.Windows.Forms.ToolStripMenuItem mnuIzmeniKlient;
        private System.Windows.Forms.ToolStripMenuItem mnuPregledajKlient;
        private System.Windows.Forms.ToolStripMenuItem mnuPregledajPonKlient;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuPrikaziIzvKlient;
        private System.Windows.Forms.ToolStripMenuItem mnuProizvod;
        private System.Windows.Forms.ToolStripMenuItem mnuVnesiProizvod;
        private System.Windows.Forms.ToolStripMenuItem mnuPrikaziProizvod;
        private System.Windows.Forms.ToolStripMenuItem mnuPregproizStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuPregproizAktivni;
        private System.Windows.Forms.ToolStripMenuItem mnuPregproizPasivni;
        private System.Windows.Forms.ToolStripMenuItem mnuproizNepotvrdeni;
        private System.Windows.Forms.ToolStripMenuItem mnuproizPotvrdeni;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuproizAll;
    }
}