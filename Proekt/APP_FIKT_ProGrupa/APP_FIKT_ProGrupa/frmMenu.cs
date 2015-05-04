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
    public partial class frmMenu : Form
    {
        bool admin;
        BrziPonudiDataContext context = new BrziPonudiDataContext();
        public frmMenu(bool admin, int proizvodiD)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void прегледНаПонудиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (!admin)
            {
                mnuVraboten.Visible = false;
            }
        }

        private void mnuVnesiVraboten_Click(object sender, EventArgs e)
        {
            frmNovVraboten novproiz = new frmNovVraboten(this);
            novproiz.Show();
        }

        private void prikazi(int kriterium)
        {
            switch (kriterium)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    {
                        frmPregVrab pregProiz = new frmPregVrab(this, kriterium);
                        pregProiz.Show();
                        break;
                    }
                case 6:
                    { 
                        frmPregProizvod pregProiz = new frmPregProizvod(this);
                        pregProiz.Show();
                        break;
                    }
                default:
                    {
                       MessageBox.Show("Не се пронајдени податоци.", "Нема податоци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }   
        }

        private void mnuproizNepotvrdeni_Click(object sender, EventArgs e)
        {
            var queryPregproiz = (from vrb in context.Vrabotens
                                 where vrb.PotvrdenV == false
                                 select vrb);
            if (queryPregproiz.Count() > 0)
                prikazi(1);
            else
                prikazi(-1);
        }

        private void mnuproizPotvrdeni_Click(object sender, EventArgs e)
        {
            var queryPregproiz = (from vrb in context.Vrabotens
                                 where vrb.PotvrdenV == true
                                 select vrb);
            if (queryPregproiz.Count() > 0)
                prikazi(2);
            else
                prikazi(-1);
        }
        private void mnuPregproizAktivni_Click(object sender, EventArgs e)
        {
            var queryPregproiz = (from vrb in context.Vrabotens
                                 where vrb.StatusV == true
                                 select vrb);
            if (queryPregproiz.Count() > 0)
                prikazi(3);
            else
                prikazi(-1);
        }

        private void mnuPregproizPasivni_Click(object sender, EventArgs e)
        {
            var queryPregproiz = (from vrb in context.Vrabotens
                                 where vrb.StatusV == false
                                 select vrb);
            if (queryPregproiz.Count() > 0)
                prikazi(4);
            else
                prikazi(-1);
        }

        private void mnuproizAll_Click(object sender, EventArgs e)
        {
            var queryPregproiz = (from vrb in context.Vrabotens
                                 select vrb);
            if (queryPregproiz.Count() > 0)
                prikazi(5);
            else
                prikazi(-1);
        }

        private void mnuVnesiProizvod_Click(object sender, EventArgs e)
        {
            frmNovProizvod novProizvod = new frmNovProizvod(this);
            novProizvod.Show();
        }

        private void mnuPrikaziProizvod_Click(object sender, EventArgs e)
        {
            var queryPrikaziProizvod = (from proizvod in context.tblProizvodis
                                        select proizvod);
            if (queryPrikaziProizvod.Count() > 0)
                prikazi(6);
            else
                prikazi(-1);
        }


    }
}
