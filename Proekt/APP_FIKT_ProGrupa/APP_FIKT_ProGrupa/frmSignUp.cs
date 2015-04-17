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
                    MessageBox.Show("Корисничкото име не е слободно", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                }
            }
        }
   
    }
}
