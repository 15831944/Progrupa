using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Linq;

namespace APP_FIKT_ProGrupa
{
    public partial class frmPregKlient : Form
    {
        BrziPonudiDataContext context = new BrziPonudiDataContext();
        int dolzinaGrid;
        int idfirma;
        bool novoLice = false;

        public frmPregKlient(frmMenu parent)
        {
            InitializeComponent();
            MdiParent = parent;
            napolniTabela(1, -1);
        }

        private void frmPregKlient_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            grdPregKlient.Columns[0].HeaderText = "Шифра";
            grdPregKlient.Columns[1].HeaderText = "Име";
            grdPregKlient.Columns[2].HeaderText = "Адреса";
            grdPregKlient.Columns[3].HeaderText = "Град";
            grdPregKlient.Columns[4].HeaderText = "Телефон";
            grdPregKlient.Columns[5].HeaderText = "Е-маил";
            grdPregKlient.Columns[6].HeaderText = "Веб страна";
            grdPregKlient.Columns[7].HeaderText = "Коментар";
            grdPregKlient.Columns[0].ReadOnly = true;

            grdPregLicaKontakt.Columns[0].HeaderText = "Шифра";
            grdPregLicaKontakt.Columns[1].HeaderText = "Шифра на фирма";
            grdPregLicaKontakt.Columns[2].HeaderText = "Име";
            grdPregLicaKontakt.Columns[3].HeaderText = "Презиме";
            grdPregLicaKontakt.Columns[4].HeaderText = "Позиција";
            grdPregLicaKontakt.Columns[5].HeaderText = "Е-маил";
            grdPregLicaKontakt.Columns[6].HeaderText = "Телефон";
            grdPregLicaKontakt.Columns[7].HeaderText = "Коментар";
            grdPregLicaKontakt.Columns[8].HeaderText = "Активен";
            grdPregLicaKontakt.Columns[0].ReadOnly = true;
            grdPregLicaKontakt.Columns[1].ReadOnly = true;
            grdPregLicaKontakt.Visible = false;


            DataGridViewButtonColumn btnPromeniL = new DataGridViewButtonColumn();
            grdPregLicaKontakt.Columns.Add(btnPromeniL);
            btnPromeniL.HeaderText = "Измени податоци";
            btnPromeniL.Text = "Измени";
            btnPromeniL.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn btnPrikaziL = new DataGridViewButtonColumn();
            grdPregKlient.Columns.Add(btnPrikaziL);
            btnPrikaziL.HeaderText = "Лица за контакт";
            btnPrikaziL.Text = "Прикажи";
            btnPrikaziL.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnPromeni = new DataGridViewButtonColumn();
            grdPregKlient.Columns.Add(btnPromeni);
            btnPromeni.HeaderText = "Измени податоци";
            btnPromeni.Text = "Измени";
            btnPromeni.UseColumnTextForButtonValue = true;

            

            dolzinaGrid = grdPregKlient.RowHeadersWidth + SystemInformation.VerticalScrollBarWidth + 3;
            
            column = grdPregKlient.Columns[0];
            dolzinaGrid += column.Width * 10;
            this.Width = dolzinaGrid + 60;
            grdPregLicaKontakt.Left = 20;
            grdPregLicaKontakt.Width = dolzinaGrid;
            grdPregKlient.Left = 20;
            grdPregKlient.Width = dolzinaGrid;

        }
        private void napolniTabela(int kriterium, int firma)
        {
            BrziPonudiDataContext context = new BrziPonudiDataContext();
            switch (kriterium)
            {
                case 1:
                {
                    var queryKlient = (from klient in context.tblKlientis
                               select klient);
                    if (queryKlient.Count() > 0)
                        grdPregKlient.DataSource = queryKlient;
                    else
                        MessageBox.Show("Не се пронајдени податоци.", "Нема податоци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var queryLicaKontakt = (from licaKontakt in context.tblLicaKontakts
                                            select licaKontakt);
                    if (queryLicaKontakt.Count() > 0)
                        grdPregLicaKontakt.DataSource = queryLicaKontakt;
                    break;
                }
                case 2:
                    {
                        var queryLicaKontakt = (from licaKontakt in context.tblLicaKontakts
                                                where firma == licaKontakt.IDFirma 
                                                select licaKontakt);
                        if (queryLicaKontakt.Count() > 0)
                        {
                            grdPregLicaKontakt.DataSource = queryLicaKontakt;
                            grdPregLicaKontakt.Visible = true;
                        }
                        else
                        {
                            grdPregLicaKontakt.DataSource = queryLicaKontakt;
                            grdPregLicaKontakt.Visible = true;
                            MessageBox.Show("Не се пронајдени податоци.", "Нема податоци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           // grdPregLicaKontakt.Visible = false;
                        }
                        break;
                    }
                default:
                {
                    MessageBox.Show("Не се пронајдени податоци.", "Нема податоци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                } 
            } 
        }

        private void grdPregLicaKontakt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            String komentar; 

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    int index = grdPregLicaKontakt.CurrentRow.Index;
                    int key = int.Parse(grdPregLicaKontakt["IDLicaZaKontakt", grdPregLicaKontakt.CurrentRow.Index].Value.ToString());
                    BrziPonudiDataContext context = new BrziPonudiDataContext();
                    var lk = new tblLicaKontakt();

                    if (key != 0)
                        lk = context.tblLicaKontakts.Single<tblLicaKontakt>(ee => ee.IDLicaZaKontakt == key);
                    else
                    {
                        novoLice = true;
                    }
                    
                        //???  незнам зошто со индекс 7 го зема телефонскиот број наместо коментарот
                    if (grdPregLicaKontakt[8, index].Value == null || grdPregLicaKontakt[8, index].Value.ToString() == string.Empty)//ToString()????
                        komentar = "Нема коментар";
                    else
                        komentar = grdPregLicaKontakt[8, index].Value.ToString();

                    
                    lk.IDFirma = idfirma;
                    lk.Ime = grdPregLicaKontakt["Ime", index].Value.ToString();
                    lk.Prezime = grdPregLicaKontakt["Prezime", index].Value.ToString();
                    lk.Pozicija = grdPregLicaKontakt["Pozicija", index].Value.ToString();
                    lk.Email = grdPregLicaKontakt["Email", index].Value.ToString();
                    lk.Telefon = grdPregLicaKontakt["Telefon", index].Value.ToString();
                    lk.Komentar = komentar;
                    lk.Status = bool.Parse(grdPregLicaKontakt["Status", index].Value.ToString());
                    // Insert any additional changes to column values.

                    if (novoLice)
                        context.tblLicaKontakts.InsertOnSubmit(lk);
                    context.SubmitChanges();
                    MessageBox.Show("Податоците за лицето " + grdPregLicaKontakt["Ime", index].Value.ToString() + " се успешно променети!", "Успешна промена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (novoLice)
                        napolniTabela(2, idfirma);
                    novoLice = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Внесени се невалидни податоци и промените за лицето нема да бидат зачувани!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Provide for exceptions.
                }
            }
        }

        private void grdPregKlient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            BrziPonudiDataContext context = new BrziPonudiDataContext();
            String komentar;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex].HeaderText == "Измени податоци" &&
                e.RowIndex >= 0)
            {
                try
                {
                    int index = grdPregKlient.CurrentRow.Index;
                    int key = int.Parse(grdPregKlient["IDFirma", grdPregKlient.CurrentRow.Index].Value.ToString());

                    var kl = context.tblKlientis.Single<tblKlienti>(ee => ee.IDFirma== key);
                   
                    //???  незнам зошто со индекс 7 го зема телефонскиот број наместо коментарот
                    if (grdPregKlient[9, index].Value == null || grdPregKlient[9, index].Value.ToString() == string.Empty)//ToString()????
                        komentar = "Нема коментар";
                    else
                        komentar = grdPregKlient[9, index].Value.ToString();


                    kl.ImeFirma = grdPregKlient["ImeFirma", index].Value.ToString();
                    kl.Adresa = grdPregKlient["Adresa", index].Value.ToString();
                    kl.Grad = grdPregKlient["Grad", index].Value.ToString();
                    kl.Telefon = grdPregKlient["Telefon", index].Value.ToString();
                    kl.Email = grdPregKlient["Email", index].Value.ToString();
                    kl.webstrana = grdPregKlient["webstrana", index].Value.ToString();
                    kl.komentar = komentar;
                    // Insert any additional changes to column values.

                    context.SubmitChanges();
                    MessageBox.Show("Податоците за фирмата " + grdPregKlient["ImeFirma", index].Value.ToString() + " се успешно променети!", "Успешна промена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Внесени се невалидни податоци и промените за лицето нема да бидат зачувани!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Provide for exceptions.
                }
            }


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex].HeaderText == "Лица за контакт" &&
                e.RowIndex >= 0)
            {
                int index = grdPregKlient.CurrentRow.Index;
                idfirma = int.Parse(grdPregKlient["IDFirma", grdPregKlient.CurrentRow.Index].Value.ToString());
                napolniTabela(2, idfirma);
            }
        }
    }
}
