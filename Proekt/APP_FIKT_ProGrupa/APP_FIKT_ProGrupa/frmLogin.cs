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


namespace APP_FIKT_ProGrupa
{
    public partial class frmLogin : Form
    {
        //променлива која служи за иклучување на формата по успешната најава
        bool logedIn = false;

        //context od .dbml fajlot za da mozi da pristapuvate do tabelite od bazata i do podatocite vo niv
        BrziPonudiDataContext context = new BrziPonudiDataContext();

        public frmLogin()
        {
            InitializeComponent();
        }

        //метод за логирање, го користиме за да може да се логира со клик или со ентер
        private void logIn()
        {
            //издвојување на поклопените податоци од базата со внесените податоци
            var queryVraboten = (from vrb in context.Vrabotens
                                 where vrb.KorisnickoImeV == txtUserName.Text && vrb.PasswordV == txtPass.Text && vrb.PotvrdenV == true && vrb.StatusV == true
                                 select vrb).ToList();
            //доколку има поклопени податоци, најавата е успешна
            if (queryVraboten.Count() > 0)
            {
                foreach (var vraboten in queryVraboten)
                {
                    logedIn = true;
                    frmMenu menuOpen = new frmMenu(vraboten.AdminV, vraboten.VrabotenID);
                    menuOpen.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Не ви е дозволен пристап до системот.", "Неуспешна најава", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            logIn();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                logIn();
        }

        //преминување од корисничко име на лозинка со користење на ентер
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        //вклучување на нова форма, каде како објект ја праќаме оваа форма за да ја направиме да биде неактивна
        //се додека формата frmSignUp е активна
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp(this);
            frmSignUp.Show();
        }

        

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logedIn)
                Application.Exit();
        }
    }
}
