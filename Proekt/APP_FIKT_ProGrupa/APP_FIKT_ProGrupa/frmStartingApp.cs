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
            timer1.Enabled = false;
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Enabled = false;
            this.Hide();
        }
    }
}
