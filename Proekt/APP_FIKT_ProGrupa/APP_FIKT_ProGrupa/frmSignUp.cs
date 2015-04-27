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
    public partial class frmSignUp : Form
    {
        /*
        System.Data.SqlClient.SqlConnection Cnn;
        System.Data.SqlClient.SqlDataAdapter da;
        System.Data.SqlClient.SqlCommandBuilder cb;
        DataSet ds;
        DataRow dr;
        */
        BrziPonudiDataContext context = new BrziPonudiDataContext();

        frmLogin frm;

        public frmSignUp(frmLogin frm)
        {
            this.frm = frm;
            this.frm.Enabled = false; //формата frmLogin е неактивна
            InitializeComponent();
        }

        private void frmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true; //формата drmLogin e активна
        }

        private void txtUser_Validated(object sender, EventArgs e)
        {}

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool flag = false; //знаменце за точност на податоците
            //проверка на точноста на внесените податоци
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
            else if (txtUserName.Text == "" || txtUserName.Text[0] == ' ') { 
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtUserName.Focus();
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

            /*
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
                dr[8] = txtUserName.Text;
                dr[9] = txtPass.Text;
                ds.Tables["Vraboten"].Rows.Add(dr);
                da.Update(ds, "Vraboten");
                MessageBox.Show("Вашите податоци се успешно внесени. По добиена дозвола од администратор, ќе ви биде овозможен пристап до системот!", "Ви честитаме", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
             */
            else if (!flag)
            { 
                // проверка дали корисничкото име е слободно
                 var queryChekUserName = (from cun in context.Vrabotens
                                      where cun.KorisnickoImeV == txtUserName.Text select cun).ToList();
                 if (queryChekUserName.Count() > 0)
                 {
                    foreach (var chekUserName in queryChekUserName)
                    {
                       MessageBox.Show("Корисничкото име не е слободно!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       txtUserName.Focus();
                       txtUserName.Text = "";
                       flag = true;
                    }
                }
            }
            else if (!flag)
            {
                //внесување на податоците во базата на податоци
                BrziPonudiDataContext addUser = new BrziPonudiDataContext();
                Vraboten v = new Vraboten();
                v.ImeV = txtIme.Text;
                v.PrezimeV = txtPrezime.Text;
                v.EmailV = txtMail.Text;
                v.TelefonV = txtTel.Text;
                v.KorisnickoImeV = txtUserName.Text;
                v.PasswordV = txtPass.Text;
                v.AdminV = false;
                v.StatusV = false;
                v.PotvrdenV = false;
                addUser.Vrabotens.InsertOnSubmit(v);
                addUser.SubmitChanges();
                MessageBox.Show("Вашите податоци се успешно внесени. По добиена дозвола од администратор, ќе ви биде овозможен пристап до системот!", "Ви честитаме", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
          }
    }
}
