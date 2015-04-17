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
    public partial class frmSignUp : Form
    {
        System.Data.SqlClient.SqlConnection Cnn;
        System.Data.SqlClient.SqlDataAdapter da;
        System.Data.SqlClient.SqlCommandBuilder cb;
        DataSet ds;
        DataRow dr;
        int maxRow;

        frmLogin frm;

        public frmSignUp(frmLogin frm)
        {
            this.frm = frm;
            this.frm.Enabled = false;
            InitializeComponent();
        }

        private void frmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {}

        private void txtUser_Validated(object sender, EventArgs e)
        {   
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (txtIme.Text == "" || txtIme.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtIme.Focus();
            }
            else if (txtPrezime.Text == "" || txtPrezime.Text[0] == ' ') { 
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtPrezime.Focus();
            }
            else if (txtMail.Text == "" || txtMail.Text[0] == ' ') { 
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtMail.Focus();
            }
            else if (txtTel.Text == "" || txtTel.Text[0] == ' ') { 
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtTel.Focus();
            }
            else if (txtUser.Text == "" || txtUser.Text[0] == ' ') { 
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtUser.Focus();
            }
            else if (txtPass.Text == "" || txtPass.Text[0] == ' ') { 
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtPass.Focus();
            }
            else if (txtPassConfirm.Text == "" || txtPassConfirm.Text[0] == ' ') { 
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtPassConfirm.Focus();
            }
            else if (txtPass.Text != txtPassConfirm.Text)
            {
                MessageBox.Show("Несофпаѓање при потврдувањето на лозинката!","Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtPassConfirm.Text = "";
                txtPass.Focus();
                flag = true;
            }
            
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
                if (txtUser.Text == dr.ItemArray.GetValue(8).ToString())
                {
                    MessageBox.Show("Корисничкото име не е слободно!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                    txtUser.Text = "";
                    flag = true;
                }
            }
            if (!flag)
            {
                cb = new System.Data.SqlClient.SqlCommandBuilder(da);
                dr = ds.Tables["Vraboten"].NewRow();
                dr[0] = maxRow;
                dr[1] = txtIme.Text;
                dr[2] = txtPrezime.Text;
                dr[3] = txtMail.Text;
                dr[4] = txtTel.Text;
                dr[5] = 0;
                dr[6] = 0;
                dr[7] = 0;
                dr[8] = txtUser.Text;
                dr[9] = txtPass.Text;
                ds.Tables["Vraboten"].Rows.Add(dr);
                da.Update(ds, "Vraboten");
                MessageBox.Show("Вашите податоци се успешно внесени. По добиена дозвола од администратор, ќе ви биде овозможен пристап до системот!", "Ви честитаме", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
   
    }
}
