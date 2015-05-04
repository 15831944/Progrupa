using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace APP_FIKT_ProGrupa
{
    public partial class frmPregProizvod : Form
    {
        BrziPonudiDataContext context = new BrziPonudiDataContext();
        public frmPregProizvod(frmMenu parent)
        {
            InitializeComponent();
            MdiParent = parent;
            napolniTabela();
        }

        private void frmPregProizvod_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            grdPregProizvod.Columns[0].HeaderText = "Шифра";
            grdPregProizvod.Columns[1].HeaderText = "Тип";
            grdPregProizvod.Columns[2].HeaderText = "Назив";
            grdPregProizvod.Columns[3].HeaderText = "Единица мерка";
            grdPregProizvod.Columns[4].HeaderText = "Цена";

            DataGridViewButtonColumn btnPromeni = new DataGridViewButtonColumn();
            grdPregProizvod.Columns.Add(btnPromeni);
            btnPromeni.HeaderText = "Измени податоци";
            btnPromeni.Text = "Измени";
            btnPromeni.UseColumnTextForButtonValue = true;


            int dolzinaGrid = grdPregProizvod.RowHeadersWidth + SystemInformation.VerticalScrollBarWidth + 3;
            for (int i = 0; i < 6; i++)
            {
                column = grdPregProizvod.Columns[i];
                dolzinaGrid += column.Width;
            }
            this.Width = dolzinaGrid + 60;
            grdPregProizvod.Left = 20;
            grdPregProizvod.Top = 20;
            grdPregProizvod.Width = dolzinaGrid;
        }
        protected void napolniTabela()
        {
            var queryProizvod = (from proizvod in context.tblProizvodis
                                 select proizvod);
            if (queryProizvod.Count() > 0)
                grdPregProizvod.DataSource = queryProizvod;
        }

        private void grdPregProizvod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int index = grdPregProizvod.CurrentRow.Index;
                int key = int.Parse(grdPregProizvod["IDProizvodPonuda", grdPregProizvod.CurrentRow.Index].Value.ToString());

                BrziPonudiDataContext context = new BrziPonudiDataContext();
                tblProizvodi proiz = context.tblProizvodis.Single<tblProizvodi>(ee => ee.IDProizvodPonuda == key);

                proiz.Tip = grdPregProizvod["Tip", index].Value.ToString();
                proiz.Naziv = grdPregProizvod["Naziv", index].Value.ToString();
                proiz.EdinicaMerka = grdPregProizvod["Edinicamerka", index].Value.ToString();
                proiz.Cena = int.Parse(grdPregProizvod["Cena", index].Value.ToString());

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
