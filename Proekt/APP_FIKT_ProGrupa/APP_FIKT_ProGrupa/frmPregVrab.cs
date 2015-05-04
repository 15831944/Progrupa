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
using System.Data.Linq;

namespace APP_FIKT_ProGrupa
{
    public partial class frmPregVrab : Form
    {
        private int kriterium;
        BrziPonudiDataContext context = new BrziPonudiDataContext();
        

        public frmPregVrab(frmMenu parent, int kriterium)
        {
            InitializeComponent();
            MdiParent = parent;
            this.kriterium = kriterium;
            napolniTabela();
        }

        private void frmPregVrab_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            grdPregVrab.Columns[0].HeaderText = "Шифра";
            grdPregVrab.Columns[1].HeaderText = "Име";
            grdPregVrab.Columns[2].HeaderText = "Презиме";
            grdPregVrab.Columns[3].HeaderText = "Е-маил";
            grdPregVrab.Columns[4].HeaderText = "Телефон";
            grdPregVrab.Columns[5].HeaderText = "Активен";
            grdPregVrab.Columns[6].HeaderText = "Потврден";
            grdPregVrab.Columns[7].HeaderText = "Администратор";
            grdPregVrab.Columns[8].HeaderText = "Корисничко име";
            grdPregVrab.Columns[9].HeaderText = "Лозинка";
            grdPregVrab.Columns[0].ReadOnly= true;

            DataGridViewButtonColumn btnPromeni = new DataGridViewButtonColumn();
            grdPregVrab.Columns.Add(btnPromeni);
            btnPromeni.HeaderText = "Измени податоци";
            btnPromeni.Text = "Измени";
            btnPromeni.UseColumnTextForButtonValue = true;

            int dolzinaGrid = grdPregVrab.RowHeadersWidth + SystemInformation.VerticalScrollBarWidth + 3;
            for (int i = 0; i < 11; i++)
            {
                column = grdPregVrab.Columns[i];
                dolzinaGrid += column.Width;
            }

            this.Width = dolzinaGrid + 60;
            grdPregVrab.Left = 20;
            grdPregVrab.Top = 20;
            grdPregVrab.Width = dolzinaGrid;
        }

        protected void napolniTabela()
        {
            var queryVraboten = (from vrb in context.Vrabotens
                                 where vrb.VrabotenID == -1
                                 select vrb);

            if (kriterium == 1) //1 - sifra za nepotvrdeni
            {
                queryVraboten = (from vrb in context.Vrabotens
                                 where vrb.PotvrdenV == false
                                 select vrb);
            }
            else if (kriterium == 2) //2 - sifra za potvrdeni
            {
                queryVraboten = (from vrb in context.Vrabotens
                                 where vrb.PotvrdenV == true
                                 select vrb);
            }
            else if (kriterium == 3) //3 - sifra za aktivni
            {
                queryVraboten = (from vrb in context.Vrabotens
                                 where vrb.StatusV == true
                                 select vrb);
            }
            else if (kriterium == 4) //4 - sifra za pasivni
            {
                queryVraboten = (from vrb in context.Vrabotens
                                 where vrb.StatusV == false
                                 select vrb);
            }
            else if (kriterium == 5) //5 - sifra za site vraboteni
            {
                queryVraboten = (from vrb in context.Vrabotens
                                 select vrb);
            }

            if (queryVraboten.Count() > 0)
                grdPregVrab.DataSource = queryVraboten;
        }

        private void grdPregVrab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int index = grdPregVrab.CurrentRow.Index;
                int key = int.Parse(grdPregVrab["VrabotenID", grdPregVrab.CurrentRow.Index].Value.ToString());
                
                BrziPonudiDataContext context = new BrziPonudiDataContext();
                Vraboten vrab = context.Vrabotens.Single<Vraboten>(ee => ee.VrabotenID == key);

                    vrab.ImeV = grdPregVrab["ImeV", index].Value.ToString();
                    vrab.PrezimeV = grdPregVrab["PrezimeV", index].Value.ToString();
                    vrab.EmailV = grdPregVrab["EmailV", index].Value.ToString();
                    vrab.TelefonV = grdPregVrab["TelefonV", index].Value.ToString();
                    vrab.StatusV = bool.Parse(grdPregVrab["StatusV", index].Value.ToString());
                    vrab.PotvrdenV = bool.Parse(grdPregVrab["PotvrdenV", index].Value.ToString());
                    vrab.AdminV = bool.Parse(grdPregVrab["AdminV", index].Value.ToString());
                    vrab.KorisnickoImeV = grdPregVrab["KorisnickoImeV", index].Value.ToString();
                    vrab.PasswordV = grdPregVrab["PasswordV", index].Value.ToString();
                    // Insert any additional changes to column values.

                try
                {
                    context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    // Provide for exceptions.
                }
            }
        }
    }
}
