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

            var queryVraboten = (from vrb in context.Vrabotens
                                 where vrb.VrabotenID == -1
                                 select vrb);
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

            int dolzinaGrid = grdPregVrab.RowHeadersWidth + SystemInformation.VerticalScrollBarWidth+3;
            for (int i = 0; i < 10; i++)
            {
                column = grdPregVrab.Columns[i];
                dolzinaGrid += column.Width;
            }

            this.Width = dolzinaGrid + 60;
            grdPregVrab.Left = 20;
            grdPregVrab.Width = dolzinaGrid ;
        }

        protected void napolniTabela ()
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
            {
                grdPregVrab.DataSource = queryVraboten;
            }
            else
            {
                MessageBox.Show("Нема вработени по избраниот критериум.", "Нема податоци", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
