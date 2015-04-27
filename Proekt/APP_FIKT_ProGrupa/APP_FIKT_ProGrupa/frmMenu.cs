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

    }
}
