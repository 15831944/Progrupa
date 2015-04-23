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

namespace APP_FIKT_ProGrupa
{
    public partial class frmLogin : Form
    {
        System.Data.SqlClient.SqlConnection Cnn;
        System.Data.SqlClient.SqlDataAdapter da;
        System.Data.SqlClient.SqlCommandBuilder cb;
        DataSet ds;
        DataRow dr;
        int maxRow;
        bool logedIn = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logedIn)
                Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Cnn = new System.Data.SqlClient.SqlConnection();
            ds = new DataSet();
            Cnn.ConnectionString = "Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=DB_FIKT_ProGrupa;Integrated Security=True";
            Cnn.Open();

            da = new System.Data.SqlClient.SqlDataAdapter("Select * from Vraboten", Cnn);
            da.Fill(ds, "Vraboten");
            Cnn.Close();

            maxRow = ds.Tables["Vraboten"].Rows.Count;
            for (int i = 0; i < maxRow; i++)
            {
                dr = ds.Tables["Vraboten"].Rows[i];
                if (txtUserName.Text == dr.ItemArray.GetValue(8).ToString())
                    if (txtPass.Text == dr.ItemArray.GetValue(9).ToString())
                        if (bool.Parse(dr.ItemArray.GetValue(5).ToString()))
                            if (bool.Parse(dr.ItemArray.GetValue(6).ToString()))
                            {
                                logedIn = true;
                                frmMenu menuOpen = new frmMenu(bool.Parse(dr.ItemArray.GetValue(7).ToString()), int.Parse(dr.ItemArray.GetValue(0).ToString()));
                                menuOpen.Show();
                                this.Close();
                            }
                            else
                                MessageBox.Show("Вашиот профил сеуште не е потврден од администратор.", "Непотврден профил", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (bool.Parse(dr.ItemArray.GetValue(6).ToString()))
                            MessageBox.Show("Вашиот пристап до системот е одземен.", "Забранет пристап", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Вашиот профил сеуште не е потврден од администратор.", "Непотврден профил", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp(this);
            frmSignUp.Show();
        }
    }
}
