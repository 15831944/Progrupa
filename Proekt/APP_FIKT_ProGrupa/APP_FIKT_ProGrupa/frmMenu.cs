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
        int pregVrabKriterium;
        public frmMenu(bool admin, int vrabotenID)
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
            frmNovVraboten novVrab = new frmNovVraboten(this);
            novVrab.Show();
        }

        private void prikaziPregledVrab()
        { 
            
        }

        private void mnuVrabNepotvrdeni_Click(object sender, EventArgs e)
        {
            frmPregVrab pregVrab = new frmPregVrab(this, 1);
            pregVrab.Show();
        }

        private void mnuVrabPotvrdeni_Click(object sender, EventArgs e)
        {
            frmPregVrab pregVrab = new frmPregVrab(this, 2);
            pregVrab.Show();
        }
        private void mnuPregVrabAktivni_Click(object sender, EventArgs e)
        {
            frmPregVrab pregVrab = new frmPregVrab(this, 3);
            pregVrab.Show();
        }

        private void mnuPregVrabPasivni_Click(object sender, EventArgs e)
        {
            frmPregVrab pregVrab = new frmPregVrab(this, 4);
            pregVrab.Show();
        }

        private void mnuVrabAll_Click(object sender, EventArgs e)
        {
            frmPregVrab pregVrab = new frmPregVrab(this, 5);
            pregVrab.Show();
        }


    }
}
