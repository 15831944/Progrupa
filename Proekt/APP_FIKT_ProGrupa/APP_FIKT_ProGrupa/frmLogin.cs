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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Cnn = new System.Data.SqlClient.SqlConnection();
            ds = new DataSet();
            Cnn.ConnectionString = "Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=DB_FIKT_ProGrupa;Integrated Security=True";
            Cnn.Open();

            da = new System.Data.SqlClient.SqlDataAdapter("Select * from Vraboten", Cnn);
            da.Fill(ds, "Vraboten");
            Cnn.Close();

            maxRow = ds.Tables["Vraboten"].Rows.Count;
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maxRow; i++)
            {
                dr = ds.Tables["Vraboten"].Rows[i];
                if (txtUserName.Text == dr.ItemArray.GetValue(8).ToString())
                    if (txtPass.Text == dr.ItemArray.GetValue(9).ToString())
                        if (bool.Parse(dr.ItemArray.GetValue(5).ToString()) && bool.Parse(dr.ItemArray.GetValue(6).ToString()))
                            MessageBox.Show("Congratulations");
            }
        }
    }
}
