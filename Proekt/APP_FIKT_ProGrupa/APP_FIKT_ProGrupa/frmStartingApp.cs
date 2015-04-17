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
    public partial class frmStartingApp : Form
    {
        int time = 0;
        public frmStartingApp()
        {
            InitializeComponent();
        }

        private void frmStartingApp_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 1)
            {
                lblFirma.Visible = true;
                lblMentor.Visible = false;
            }
            else if (time == 2)
            {
                lblFirma.Visible = false;
                lblIzrabotil1.Visible = true;
                lblIzrabotil2.Visible = true;
                lblIzrabotil3.Visible = true;
            }
            else
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                timer1.Enabled = false;
                this.Enabled = false;
                this.Hide();
            }
        }
    }
}
