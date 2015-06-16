namespace APP_FIKT_ProGrupa
{
    partial class frmPregledPonuda
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
            this.grdPregled = new System.Windows.Forms.DataGridView();
            this.iDDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arhivskibrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVraboteniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeVraboten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZaOdgovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalendarskaGodinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdadenoNaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDokumentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FIKT_ProGrupaDataSet = new APP_FIKT_ProGrupa.DB_FIKT_ProGrupaDataSet();
            this.tblDokumentiTableAdapter = new APP_FIKT_ProGrupa.DB_FIKT_ProGrupaDataSetTableAdapters.tblDokumentiTableAdapter();
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
            this.grdSkrienaStavka = new System.Windows.Forms.DataGridView();
            this.btnKreiraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FIKT_ProGrupaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStavka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSkrienaStavka)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPregled
            // 
            this.grdPregled.AllowUserToDeleteRows = false;
            this.grdPregled.AutoGenerateColumns = false;
            this.grdPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPregled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDokumentDataGridViewTextBoxColumn,
            this.arhivskibrojDataGridViewTextBoxColumn,
            this.iDFirmaDataGridViewTextBoxColumn,
            this.imeFirma,
            this.iDVraboteniDataGridViewTextBoxColumn,
            this.imeVraboten,
            this.dataZaOdgovorDataGridViewTextBoxColumn,
            this.kalendarskaGodinaDataGridViewTextBoxColumn,
            this.izdadenoNaDataGridViewTextBoxColumn,
            this.iDTempDataGridViewTextBoxColumn});
            this.grdPregled.DataSource = this.tblDokumentiBindingSource;
            this.grdPregled.Location = new System.Drawing.Point(12, 12);
            this.grdPregled.Name = "grdPregled";
            this.grdPregled.ReadOnly = true;
            this.grdPregled.Size = new System.Drawing.Size(948, 155);
            this.grdPregled.TabIndex = 0;
            this.grdPregled.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPregled_CellContentClick);
            // 
            // iDDokumentDataGridViewTextBoxColumn
            // 
            this.iDDokumentDataGridViewTextBoxColumn.DataPropertyName = "IDDokument";
            this.iDDokumentDataGridViewTextBoxColumn.HeaderText = "ID Документ";
            this.iDDokumentDataGridViewTextBoxColumn.Name = "iDDokumentDataGridViewTextBoxColumn";
            this.iDDokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDokumentDataGridViewTextBoxColumn.Width = 60;
            // 
            // arhivskibrojDataGridViewTextBoxColumn
            // 
            this.arhivskibrojDataGridViewTextBoxColumn.DataPropertyName = "Arhivskibroj";
            this.arhivskibrojDataGridViewTextBoxColumn.HeaderText = "Архивски број";
            this.arhivskibrojDataGridViewTextBoxColumn.Name = "arhivskibrojDataGridViewTextBoxColumn";
            this.arhivskibrojDataGridViewTextBoxColumn.ReadOnly = true;
            this.arhivskibrojDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDFirmaDataGridViewTextBoxColumn
            // 
            this.iDFirmaDataGridViewTextBoxColumn.DataPropertyName = "IDFirma";
            this.iDFirmaDataGridViewTextBoxColumn.HeaderText = "ID Фирма";
            this.iDFirmaDataGridViewTextBoxColumn.Name = "iDFirmaDataGridViewTextBoxColumn";
            this.iDFirmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFirmaDataGridViewTextBoxColumn.Width = 80;
            // 
            // imeFirma
            // 
            this.imeFirma.HeaderText = "Име Фирма";
            this.imeFirma.Name = "imeFirma";
            this.imeFirma.ReadOnly = true;
            this.imeFirma.Width = 80;
            // 
            // iDVraboteniDataGridViewTextBoxColumn
            // 
            this.iDVraboteniDataGridViewTextBoxColumn.DataPropertyName = "IDVraboteni";
            this.iDVraboteniDataGridViewTextBoxColumn.HeaderText = "ID Вработен";
            this.iDVraboteniDataGridViewTextBoxColumn.Name = "iDVraboteniDataGridViewTextBoxColumn";
            this.iDVraboteniDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVraboteniDataGridViewTextBoxColumn.Width = 80;
            // 
            // imeVraboten
            // 
            this.imeVraboten.HeaderText = "Име Вработен";
            this.imeVraboten.Name = "imeVraboten";
            this.imeVraboten.ReadOnly = true;
            this.imeVraboten.Width = 80;
            // 
            // dataZaOdgovorDataGridViewTextBoxColumn
            // 
            this.dataZaOdgovorDataGridViewTextBoxColumn.DataPropertyName = "DataZaOdgovor";
            this.dataZaOdgovorDataGridViewTextBoxColumn.HeaderText = "Дата за одговор";
            this.dataZaOdgovorDataGridViewTextBoxColumn.Name = "dataZaOdgovorDataGridViewTextBoxColumn";
            this.dataZaOdgovorDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataZaOdgovorDataGridViewTextBoxColumn.Width = 80;
            // 
            // kalendarskaGodinaDataGridViewTextBoxColumn
            // 
            this.kalendarskaGodinaDataGridViewTextBoxColumn.DataPropertyName = "KalendarskaGodina";
            this.kalendarskaGodinaDataGridViewTextBoxColumn.HeaderText = "Календарска година";
            this.kalendarskaGodinaDataGridViewTextBoxColumn.Name = "kalendarskaGodinaDataGridViewTextBoxColumn";
            this.kalendarskaGodinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kalendarskaGodinaDataGridViewTextBoxColumn.Width = 80;
            // 
            // izdadenoNaDataGridViewTextBoxColumn
            // 
            this.izdadenoNaDataGridViewTextBoxColumn.DataPropertyName = "IzdadenoNa";
            this.izdadenoNaDataGridViewTextBoxColumn.HeaderText = "Издадено на";
            this.izdadenoNaDataGridViewTextBoxColumn.Name = "izdadenoNaDataGridViewTextBoxColumn";
            this.izdadenoNaDataGridViewTextBoxColumn.ReadOnly = true;
            this.izdadenoNaDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDTempDataGridViewTextBoxColumn
            // 
            this.iDTempDataGridViewTextBoxColumn.DataPropertyName = "IDTemp";
            this.iDTempDataGridViewTextBoxColumn.HeaderText = "Темплејт";
            this.iDTempDataGridViewTextBoxColumn.Name = "iDTempDataGridViewTextBoxColumn";
            this.iDTempDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTempDataGridViewTextBoxColumn.Width = 80;
            // 
            // tblDokumentiBindingSource
            // 
            this.tblDokumentiBindingSource.DataMember = "tblDokumenti";
            this.tblDokumentiBindingSource.DataSource = this.dB_FIKT_ProGrupaDataSet;
            // 
            // dB_FIKT_ProGrupaDataSet
            // 
            this.dB_FIKT_ProGrupaDataSet.DataSetName = "DB_FIKT_ProGrupaDataSet";
            this.dB_FIKT_ProGrupaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDokumentiTableAdapter
            // 
            this.tblDokumentiTableAdapter.ClearBeforeFill = true;
            // 
            // txtIznos_DDV
            // 
            this.txtIznos_DDV.Enabled = false;
            this.txtIznos_DDV.Location = new System.Drawing.Point(738, 220);
            this.txtIznos_DDV.Name = "txtIznos_DDV";
            this.txtIznos_DDV.Size = new System.Drawing.Size(222, 20);
            this.txtIznos_DDV.TabIndex = 19;
            // 
            // txtDDV
            // 
            this.txtDDV.Enabled = false;
            this.txtDDV.Location = new System.Drawing.Point(860, 190);
            this.txtDDV.Name = "txtDDV";
            this.txtDDV.Size = new System.Drawing.Size(100, 20);
            this.txtDDV.TabIndex = 18;
            // 
            // txtVkupno
            // 
            this.txtVkupno.Enabled = false;
            this.txtVkupno.Location = new System.Drawing.Point(670, 190);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.Size = new System.Drawing.Size(100, 20);
            this.txtVkupno.TabIndex = 17;
            this.txtVkupno.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Вкупно за плаќање";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ДДВ 18%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Износ";
            // 
            // grdStavka
            // 
            this.grdStavka.AllowUserToDeleteRows = false;
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
            this.grdStavka.Location = new System.Drawing.Point(12, 190);
            this.grdStavka.Name = "grdStavka";
            this.grdStavka.ReadOnly = true;
            this.grdStavka.Size = new System.Drawing.Size(529, 104);
            this.grdStavka.TabIndex = 20;
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
            // grdSkrienaStavka
            // 
            this.grdSkrienaStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSkrienaStavka.Location = new System.Drawing.Point(165, 155);
            this.grdSkrienaStavka.Name = "grdSkrienaStavka";
            this.grdSkrienaStavka.Size = new System.Drawing.Size(240, 150);
            this.grdSkrienaStavka.TabIndex = 21;
            this.grdSkrienaStavka.Visible = false;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(628, 271);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(332, 23);
            this.btnKreiraj.TabIndex = 22;
            this.btnKreiraj.Text = "Прикажи за печатење";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // frmPregledPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 319);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.grdSkrienaStavka);
            this.Controls.Add(this.grdStavka);
            this.Controls.Add(this.txtIznos_DDV);
            this.Controls.Add(this.txtDDV);
            this.Controls.Add(this.txtVkupno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdPregled);
            this.Name = "frmPregledPonuda";
            this.Text = "Преглед на Понуди";
            this.Load += new System.EventHandler(this.frmPregledPonuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDokumentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FIKT_ProGrupaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStavka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSkrienaStavka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPregled;
        private DB_FIKT_ProGrupaDataSet dB_FIKT_ProGrupaDataSet;
        private System.Windows.Forms.BindingSource tblDokumentiBindingSource;
        private DB_FIKT_ProGrupaDataSetTableAdapters.tblDokumentiTableAdapter tblDokumentiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arhivskibrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVraboteniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeVraboten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZaOdgovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalendarskaGodinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdadenoNaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIznos_DDV;
        private System.Windows.Forms.TextBox txtDDV;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdStavka;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMerka;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdIznos;
        private System.Windows.Forms.DataGridView grdSkrienaStavka;
        private System.Windows.Forms.Button btnKreiraj;
    }
}