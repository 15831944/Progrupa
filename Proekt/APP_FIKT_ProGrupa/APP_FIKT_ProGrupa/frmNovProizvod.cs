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
    public partial class frmNovProizvod : Form
    {
        BrziPonudiDataContext context = new BrziPonudiDataContext();
        int cena;
        bool cenaInt = false;
        public frmNovProizvod(frmMenu parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool flag = false; //знаменце за точност на податоците
            if (txtTip.Text == "" || txtTip.Text[0] == ' ') 
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtTip.Focus();
            }
            else if (txtNaziv.Text == "" || txtNaziv.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtNaziv.Focus();
            }
            else if (txtEMerka.Text == "" || txtEMerka.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtEMerka.Focus();
            }
            else if (txtCena.Text == "" || txtCena.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtCena.Focus();
            }
            else if (!(cenaInt = int.TryParse(txtCena.Text, out cena)))
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtCena.Focus();
            }
            else if (!flag)
            {
                var p = new tblProizvodi
                {
                    Tip = txtTip.Text,
                    Naziv = txtNaziv.Text,
                    EdinicaMerka = txtEMerka.Text,
                    Cena = cena,
                };
                context.tblProizvodis.InsertOnSubmit(p);
                context.SubmitChanges();
                MessageBox.Show("Податоците за новиот производ се успешно внесени!", "Производот е внесен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTip.Text = "";
                txtNaziv.Text = "";
                txtEMerka.Text = "";
                txtCena.Text = "";
               
                txtTip.Focus();
            }
        }
    }
}
