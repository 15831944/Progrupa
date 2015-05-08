using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_FIKT_ProGrupa
{
    public partial class frmNovKlient : Form
    {
        BrziPonudiDataContext context = new BrziPonudiDataContext();

        public frmNovKlient(frmMenu parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }
        private void reset()
        {
            txtIme.Text = "";
            txtAdresa.Text = "";
            txtGrad.Text = "";
            txtMail.Text = "";
            txtTelefon.Text = "";
            txtWebPage.Text = "";
            txtKomentar.Text = "";
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            grdLicaKontakt.Rows.Clear();
            grdLicaKontakt.Refresh();
        }

        private void btnConfirmK_Click(object sender, EventArgs e)
        {
            bool flag = false; //знаменце за точност на податоците

            //проверка на точноста на внесените податоци
            if (txtIme.Text == "" || txtIme.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtIme.Focus();
            }
            else if (txtAdresa.Text == "" || txtAdresa.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtAdresa.Focus();
            }
            else if (txtGrad.Text == "" || txtGrad.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtGrad.Focus();
            }
            else if (txtTelefon.Text == "" || txtTelefon.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtTelefon.Focus();
            }
            else if (txtMail.Text == "" || txtMail.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtMail.Focus();
            }
            else if (txtWebPage.Text == "" || txtWebPage.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtWebPage.Focus();
            }
            else if (!flag)
            {
                // проверка дали името е слободно
                var queryChekName = (from cn in context.tblKlientis
                                     where cn.ImeFirma == txtIme.Text
                                     select cn).ToList();
                if (queryChekName.Count() > 0)
                {
                    foreach (var chekName in queryChekName)
                    {
                        MessageBox.Show("Фирмата е внесена од претходно. Не се дозволени дупликати!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIme.Focus();
                        txtIme.Text = "";
                        flag = true;
                    }
                }

                else if (!flag)
                {
                    String komentar;
                    if (txtKomentar.Text == "")
                        komentar = "Нема коментар";
                    else
                        komentar = txtKomentar.Text;

                    var k = new tblKlienti
                    {
                        ImeFirma = txtIme.Text,
                        Adresa = txtAdresa.Text,
                        Grad = txtGrad.Text,
                        Telefon = txtTelefon.Text,
                        Email = txtMail.Text,
                        webstrana = txtWebPage.Text,
                        komentar = komentar,
                    };
                    context.tblKlientis.InsertOnSubmit(k);
                    context.SubmitChanges();
                    MessageBox.Show("Податоците за лиентот се успешно внесени!", "Успешен внес", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;
                }
            }
        }

        private void btnConfirmL_Click(object sender, EventArgs e)
        {
            BrziPonudiDataContext context = new BrziPonudiDataContext();
            bool flag = false;
            int idFirma = ((from id in context.tblKlientis
                                    where id.ImeFirma == txtIme.Text
                                    select id.IDFirma).Single());

            for (int i = 0; i < grdLicaKontakt.RowCount - 1; i++)
            {
                String komentar;
                bool status = grdLicaKontakt[5, i].Value as bool? ?? false;
                if (grdLicaKontakt[6, i].Value == null || grdLicaKontakt[6, i].Value.ToString() == string.Empty)//ToString()????
                    komentar = "Нема коментар";
                else
                   komentar = grdLicaKontakt[6, i].Value.ToString();
                try
                {
                    var lk = new tblLicaKontakt
                    {
                       IDFirma = idFirma,
                       Ime = grdLicaKontakt[0, i].Value.ToString(),
                       Prezime = grdLicaKontakt[1, i].Value.ToString(),
                       Pozicija = grdLicaKontakt[2, i].Value.ToString(),
                       Email = grdLicaKontakt[3, i].Value.ToString(),
                       Telefon = grdLicaKontakt[4, i].Value.ToString(),
                       Komentar = komentar,
                       Status = status,
                    };
                    context.tblLicaKontakts.InsertOnSubmit(lk);
                }
                catch (Exception)
                {
                    flag = true;
                    MessageBox.Show("Внесени се невалидни податоци за лицата за контакт.\nПодатоците нема да бидат зачувани додека грешките не се поправени!", "Невалидни Податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }      
                }
                if (!flag)
                {
                    context.SubmitChanges();
                    MessageBox.Show("Податоците за лицата за контакт се успешно внесени!", "Успешен внес", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
        }
    }
}
