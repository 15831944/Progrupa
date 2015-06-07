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
            this.cmbKlient = new System.Windows.Forms.ComboBox();
            this.dtVaznost = new System.Windows.Forms.DateTimePicker();
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIznos_DDV = new System.Windows.Forms.TextBox();
            this.txtDDV = new System.Windows.Forms.TextBox();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grdStavka = new System.Windows.Forms.DataGridView();
            this.grdSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMerka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdIznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMerka = new System.Windows.Forms.TextBox();
            this.btnProizvodAdd = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStavka)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKlient
            // 
            this.cmbKlient.FormattingEnabled = true;
            this.cmbKlient.Location = new System.Drawing.Point(15, 25);
            this.cmbKlient.Name = "cmbKlient";
            this.cmbKlient.Size = new System.Drawing.Size(200, 21);
            this.cmbKlient.TabIndex = 0;
            // 
            // dtVaznost
            // 
            this.dtVaznost.Location = new System.Drawing.Point(15, 111);
            this.dtVaznost.Name = "dtVaznost";
            this.dtVaznost.Size = new System.Drawing.Size(200, 20);
            this.dtVaznost.TabIndex = 2;
            // 
            // cmbTemp
            // 
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(15, 65);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(200, 21);
            this.cmbTemp.TabIndex = 1;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(247, 340);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(75, 23);
            this.btnKreiraj.TabIndex = 3;
            this.btnKreiraj.Text = "Креирај";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изберете фирма за која е наменета понудата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Изберете темплејт за понудата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Изберете датум за одговор на понудата";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIznos_DDV);
            this.groupBox1.Controls.Add(this.txtDDV);
            this.groupBox1.Controls.Add(this.txtVkupno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.grdStavka);
            this.groupBox1.Location = new System.Drawing.Point(15, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 189);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ставка";
            // 
            // txtIznos_DDV
            // 
            this.txtIznos_DDV.Enabled = false;
            this.txtIznos_DDV.Location = new System.Drawing.Point(119, 159);
            this.txtIznos_DDV.Name = "txtIznos_DDV";
            this.txtIznos_DDV.Size = new System.Drawing.Size(222, 20);
            this.txtIznos_DDV.TabIndex = 13;
            // 
            // txtDDV
            // 
            this.txtDDV.Enabled = false;
            this.txtDDV.Location = new System.Drawing.Point(241, 129);
            this.txtDDV.Name = "txtDDV";
            this.txtDDV.Size = new System.Drawing.Size(100, 20);
            this.txtDDV.TabIndex = 12;
            // 
            // txtVkupno
            // 
            this.txtVkupno.Enabled = false;
            this.txtVkupno.Location = new System.Drawing.Point(51, 129);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.Size = new System.Drawing.Size(100, 20);
            this.txtVkupno.TabIndex = 11;
            this.txtVkupno.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вкупно за плаќање";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ДДВ 18%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Износ";
            // 
            // grdStavka
            // 
            this.grdStavka.AllowUserToAddRows = false;
            this.grdStavka.AllowUserToResizeColumns = false;
            this.grdStavka.AllowUserToResizeRows = false;
            this.grdStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStavka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdSifra,
            this.grdNaziv,
            this.grdKolicina,
            this.grdMerka,
            this.grdCena,
            this.grdIznos});
            this.grdStavka.Location = new System.Drawing.Point(6, 19);
            this.grdStavka.Name = "grdStavka";
            this.grdStavka.ReadOnly = true;
            this.grdStavka.Size = new System.Drawing.Size(529, 104);
            this.grdStavka.TabIndex = 0;
            // 
            // grdSifra
            // 
            this.grdSifra.FillWeight = 50F;
            this.grdSifra.HeaderText = "Шифра";
            this.grdSifra.Name = "grdSifra";
            this.grdSifra.ReadOnly = true;
            this.grdSifra.Width = 50;
            // 
            // grdNaziv
            // 
            this.grdNaziv.FillWeight = 200F;
            this.grdNaziv.HeaderText = "Назив";
            this.grdNaziv.Name = "grdNaziv";
            this.grdNaziv.ReadOnly = true;
            this.grdNaziv.Width = 120;
            // 
            // grdKolicina
            // 
            this.grdKolicina.HeaderText = "Количина";
            this.grdKolicina.Name = "grdKolicina";
            this.grdKolicina.ReadOnly = true;
            this.grdKolicina.Width = 70;
            // 
            // grdMerka
            // 
            this.grdMerka.HeaderText = "Ед. мерка";
            this.grdMerka.Name = "grdMerka";
            this.grdMerka.ReadOnly = true;
            this.grdMerka.Width = 90;
            // 
            // grdCena
            // 
            this.grdCena.HeaderText = "Цена";
            this.grdCena.Name = "grdCena";
            this.grdCena.ReadOnly = true;
            this.grdCena.Width = 70;
            // 
            // grdIznos
            // 
            this.grdIznos.HeaderText = "Износ";
            this.grdIznos.Name = "grdIznos";
            this.grdIznos.ReadOnly = true;
            this.grdIznos.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMerka);
            this.groupBox2.Controls.Add(this.btnProizvodAdd);
            this.groupBox2.Controls.Add(this.txtCena);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtKolicina);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbProizvod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(259, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 122);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додај производ";
            // 
            // txtMerka
            // 
            this.txtMerka.Enabled = false;
            this.txtMerka.Location = new System.Drawing.Point(175, 41);
            this.txtMerka.Name = "txtMerka";
            this.txtMerka.Size = new System.Drawing.Size(94, 20);
            this.txtMerka.TabIndex = 16;
            // 
            // btnProizvodAdd
            // 
            this.btnProizvodAdd.Location = new System.Drawing.Point(9, 93);
            this.btnProizvodAdd.Name = "btnProizvodAdd";
            this.btnProizvodAdd.Size = new System.Drawing.Size(160, 23);
            this.btnProizvodAdd.TabIndex = 15;
            this.btnProizvodAdd.Text = "Додај производ во ставка";
            this.btnProizvodAdd.UseVisualStyleBackColor = true;
            this.btnProizvodAdd.Click += new System.EventHandler(this.btnProizvodAdd_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(69, 66);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Цена";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(69, 41);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 12;
            this.txtKolicina.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Количина";
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(69, 16);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(200, 21);
            this.cmbProizvod.TabIndex = 9;
            this.cmbProizvod.SelectedIndexChanged += new System.EventHandler(this.cmbProizvod_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Производ";
            // 
            // frmNovaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.cmbTemp);
            this.Controls.Add(this.dtVaznost);
            this.Controls.Add(this.cmbKlient);
            this.Name = "frmNovaPonuda";
            this.Text = "Креирај понуда";
            this.Load += new System.EventHandler(this.frmNovaPonuda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStavka)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKlient;
        private System.Windows.Forms.DateTimePicker dtVaznost;
        private System.Windows.Forms.ComboBox cmbTemp;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIznos_DDV;
        private System.Windows.Forms.TextBox txtDDV;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdStavka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProizvodAdd;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMerka;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMerka;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdIznos;
    }
}