namespace APP_FIKT_ProGrupa
{
    partial class frmNovKlient
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmL = new System.Windows.Forms.Button();
            this.grdLicaKontakt = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirmK = new System.Windows.Forms.Button();
            this.txtWebPage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLicaKontakt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(810, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "*Внесете податоци за клиентот во следните полиња. Само полињата за коментар не се" +
    " задолжителни. Полињата не смее да започнуваат со празно место.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmL);
            this.groupBox1.Controls.Add(this.grdLicaKontakt);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(16, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 177);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лица за контакт";
            // 
            // btnConfirmL
            // 
            this.btnConfirmL.Location = new System.Drawing.Point(292, 140);
            this.btnConfirmL.Name = "btnConfirmL";
            this.btnConfirmL.Size = new System.Drawing.Size(186, 23);
            this.btnConfirmL.TabIndex = 19;
            this.btnConfirmL.Text = "Внеси лица за контакт";
            this.btnConfirmL.UseVisualStyleBackColor = true;
            this.btnConfirmL.Click += new System.EventHandler(this.btnConfirmL_Click);
            // 
            // grdLicaKontakt
            // 
            this.grdLicaKontakt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLicaKontakt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Pozicija,
            this.Email,
            this.Telefon,
            this.Status,
            this.Komentar});
            this.grdLicaKontakt.Location = new System.Drawing.Point(12, 19);
            this.grdLicaKontakt.Name = "grdLicaKontakt";
            this.grdLicaKontakt.Size = new System.Drawing.Size(766, 115);
            this.grdLicaKontakt.TabIndex = 18;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Име";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Презиме";
            this.Prezime.Name = "Prezime";
            // 
            // Pozicija
            // 
            this.Pozicija.HeaderText = "Позиција";
            this.Pozicija.Name = "Pozicija";
            // 
            // Email
            // 
            this.Email.HeaderText = "Е-маил";
            this.Email.Name = "Email";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Телефон";
            this.Telefon.Name = "Telefon";
            // 
            // Status
            // 
            this.Status.HeaderText = "Активен";
            this.Status.Name = "Status";
            // 
            // Komentar
            // 
            this.Komentar.HeaderText = "Коментар";
            this.Komentar.Name = "Komentar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGrad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtKomentar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnConfirmK);
            this.groupBox2.Controls.Add(this.txtWebPage);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAdresa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIme);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клиенти";
            // 
            // txtGrad
            // 
            this.txtGrad.AccessibleDescription = "/";
            this.txtGrad.Location = new System.Drawing.Point(467, 24);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(117, 20);
            this.txtGrad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "//";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Град";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(87, 87);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(497, 20);
            this.txtKomentar.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Коментар";
            // 
            // btnConfirmK
            // 
            this.btnConfirmK.Location = new System.Drawing.Point(666, 85);
            this.btnConfirmK.Name = "btnConfirmK";
            this.btnConfirmK.Size = new System.Drawing.Size(116, 23);
            this.btnConfirmK.TabIndex = 16;
            this.btnConfirmK.Text = "Внеси клиент";
            this.btnConfirmK.UseVisualStyleBackColor = true;
            this.btnConfirmK.Click += new System.EventHandler(this.btnConfirmK_Click);
            // 
            // txtWebPage
            // 
            this.txtWebPage.Location = new System.Drawing.Point(292, 55);
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.Size = new System.Drawing.Size(117, 20);
            this.txtWebPage.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Веб страна";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(87, 55);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(116, 20);
            this.txtMail.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Е-маил";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(665, 24);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(117, 20);
            this.txtTelefon.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            // 
            // txtAdresa
            // 
            this.txtAdresa.AccessibleDescription = "/";
            this.txtAdresa.Location = new System.Drawing.Point(292, 24);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(117, 20);
            this.txtAdresa.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "//";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адреса";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(87, 24);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(117, 20);
            this.txtIme.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Име";
            // 
            // frmNovKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "frmNovKlient";
            this.Text = "Внеси Клиент";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLicaKontakt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdLicaKontakt;
        private System.Windows.Forms.Button btnConfirmL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConfirmK;
        private System.Windows.Forms.TextBox txtWebPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozicija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label7;
    }
}