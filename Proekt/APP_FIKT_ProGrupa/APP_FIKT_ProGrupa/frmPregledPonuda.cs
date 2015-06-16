using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using Microsoft.Office;
using System.Runtime.InteropServices;

namespace APP_FIKT_ProGrupa
{
    public partial class frmPregledPonuda : Form
    {
        public frmPregledPonuda(frmMenu parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        BrziPonudiDataContext context = new BrziPonudiDataContext();

        private void frmPregledPonuda_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnPrikazi = new DataGridViewButtonColumn();
            grdPregled.Columns.Add(btnPrikazi);
            btnPrikazi.HeaderText = "Прикажи Ставка";
            btnPrikazi.Text = "Прикажи";
            btnPrikazi.UseColumnTextForButtonValue = true;


            // TODO: This line of code loads data into the 'dB_FIKT_ProGrupaDataSet.tblDokumenti' table. You can move, or remove it, as needed.
            this.tblDokumentiTableAdapter.Fill(this.dB_FIKT_ProGrupaDataSet.tblDokumenti);
            for (int i = 0; i<grdPregled.RowCount; i++)
            {
                var firma = context.tblKlientis.Single<tblKlienti>(ee => ee.IDFirma == int.Parse(grdPregled[2, i].Value.ToString()));
                grdPregled["imeFirma", i].Value = firma.ImeFirma.ToString();

                var vrab = context.Vrabotens.Single<Vraboten>(ee => ee.VrabotenID == int.Parse(grdPregled[4, i].Value.ToString()));
                grdPregled["imeVraboten", i].Value = vrab.ImeV.ToString();
            }
            
        }

        private void grdPregled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdStavka.DataSource = null;
            grdStavka.Rows.Clear();
            grdSkrienaStavka.DataSource = null;
            grdSkrienaStavka.Rows.Clear();
            var senderGrid = (DataGridView) sender;
            int brojacProizvod = 0;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex].HeaderText == "Прикажи Ставка" &&
                e.RowIndex >= 0)
            {
                var queryStavka = (from stavka in context.tblStavkas
                                   where int.Parse(grdPregled[0, grdPregled.CurrentRow.Index].Value.ToString()) == stavka.IDPonuda
                                   select stavka);

                
                grdSkrienaStavka.DataSource = queryStavka;
                int brojProizvodi = grdSkrienaStavka.Rows.Count;
                int vkupno = 0;
                for (brojacProizvod = 0; brojacProizvod < brojProizvodi-1; brojacProizvod++ )
                {
                    var proizvod = context.tblProizvodis.Single<tblProizvodi>(ee => ee.IDProizvodPonuda == int.Parse(grdSkrienaStavka[1, brojacProizvod].Value.ToString()));
                    grdStavka.Rows.Add();
                    grdStavka[0, brojacProizvod].Value = grdSkrienaStavka[1, brojacProizvod].Value.ToString();
                    grdStavka[1, brojacProizvod].Value = proizvod.Naziv.ToString();
                    grdStavka[2, brojacProizvod].Value = grdSkrienaStavka[2, brojacProizvod].Value.ToString();
                    grdStavka[3, brojacProizvod].Value = proizvod.EdinicaMerka.ToString();
                    grdStavka[4, brojacProizvod].Value = grdSkrienaStavka[3, brojacProizvod].Value.ToString();
                    grdStavka[5, brojacProizvod].Value = int.Parse(grdSkrienaStavka[2, brojacProizvod].Value.ToString()) * int.Parse(grdSkrienaStavka[3, brojacProizvod].Value.ToString());
                    vkupno = vkupno + int.Parse(grdStavka[5, brojacProizvod].Value.ToString());
                }
                txtVkupno.Text = vkupno.ToString();
                txtDDV.Text = (vkupno * 0.18).ToString();
                txtIznos_DDV.Text = (vkupno + float.Parse(txtDDV.Text)).ToString();
            }
        }
            
        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            int key = int.Parse(grdPregled[0, grdPregled.CurrentRow.Index].Value.ToString());
            prigotviZaPecatenje(key);
        }

        void prigotviZaPecatenje(int key)
        {
            var dok = context.tblDokumentis.Single<tblDokumenti>(ee => ee.IDDokument == key);
            var Klient = context.tblKlientis.Single<tblKlienti>(ee => ee.IDFirma == dok.IDFirma);
            var Vraboten = context.Vrabotens.Single<Vraboten>(ee => ee.VrabotenID == dok.IDVraboteni);
            var templejt = context.tblTemplejts.Single<tblTemplejt>(ee => ee.IDTemplejt == dok.IDTemp);


            Microsoft.Office.Interop.Word.Application wordApp;
            Document wordDoc = new Document();

            Object oMissing = System.Reflection.Missing.Value;

            Object oTemplatePath;// = "D:\\MyTemplate.dotx";
            string oTempName;

            oTempName = templejt.ImeTemp;
            oTemplatePath = templejt.LokacijaTemplejt + '/' + oTempName + ".dotx";

            
            wordApp = new Microsoft.Office.Interop.Word.Application();
            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);




            // context ********
            foreach (Field myMergeField in wordDoc.Fields)
            {
                Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;

                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    // THE TEXT COMES IN THE FORMAT OF
                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT
                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    int endMerge = fieldText.IndexOf("\\");

                    int fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // **** FIELD REPLACEMENT IMPLEMENTATION GOES HERE ****//

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    switch (fieldName)
                    {
                        case "korisnik":
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(Klient.ImeFirma);
                                break;
                            }
                        case "mesto":
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(Klient.Grad);
                                break;
                            }
                        case "adresa":
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(Klient.Adresa);
                                break;
                            }
                        case "vaznost":
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(dok.DataZaOdgovor.ToString());
                                break;
                            }
                        case "izdadenoNa":
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(dok.IzdadenoNa.ToString());
                                break;
                            }
                        case "vrabIme":
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(Vraboten.ImeV);
                                break;
                            }
                        case "vrabPrezime":
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(Vraboten.PrezimeV);
                                break;
                            }
                        case "stavka":
                            {
                                myMergeField.Select();
                                //   wordApp.Selection.TypeText("");
                                Microsoft.Office.Interop.Word.Selection wrdSelect = wordApp.Selection;
                                Microsoft.Office.Interop.Word.Table wrdTable = wordDoc.Tables.Add(wrdSelect.Range, 1, 6, ref oMissing, ref oMissing);

                                wrdTable.Range.ParagraphFormat.RightIndent = wordDoc.Paragraphs.RightIndent;
                                wrdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                                wrdTable.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth075pt;
                                wrdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                                wrdTable.Borders.InsideLineWidth = WdLineWidth.wdLineWidth075pt;

                                wrdTable.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                                wrdTable.Columns[1].SetWidth(50, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[2].SetWidth(150, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[3].SetWidth(60, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[4].SetWidth(50, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[5].SetWidth(50, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[6].SetWidth(50, WdRulerStyle.wdAdjustNone);

                                wrdTable.Cell(1, 1).Range.Text = "Шифра";
                                wrdTable.Cell(1, 2).Range.Text = "Назив";
                                wrdTable.Cell(1, 3).Range.Text = "Количина";
                                wrdTable.Cell(1, 4).Range.Text = "Ед. Мерка";
                                wrdTable.Cell(1, 5).Range.Text = "Цена";
                                wrdTable.Cell(1, 6).Range.Text = "Износ";
                                // wrdTable.Cell(0, 0).Range.SetRange(0,50);

                                for (int i = 0; i < grdStavka.RowCount-1; i++)
                                {
                                    wordDoc.Tables[1].Rows.Add(ref oMissing);
                                    wrdTable.Cell(i + 2, 1).Range.Text = grdStavka[0, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 2).Range.Text = grdStavka[1, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 3).Range.Text = grdStavka[2, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 4).Range.Text = grdStavka[3, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 5).Range.Text = grdStavka[4, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 6).Range.Text = grdStavka[5, i].Value.ToString();
                                }

                                wordDoc.Tables[1].Rows.Add(ref oMissing);
                                wrdTable.Cell(wrdTable.Rows.Count, 1).Merge(wrdTable.Cell(wrdTable.Rows.Count, 5));
                                wrdTable.Cell(wrdTable.Rows.Count, 1).Range.Text = "Износ";
                                wrdTable.Cell(wrdTable.Rows.Count, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                                wrdTable.Cell(wrdTable.Rows.Count, 2).Range.Text = txtVkupno.Text.ToString();

                                wordDoc.Tables[1].Rows.Add(ref oMissing);
                                //    wrdTable.Cell(wrdTable.Rows.Count, 1).Merge(wrdTable.Cell(wrdTable.Rows.Count, 4));
                                wrdTable.Cell(wrdTable.Rows.Count, 1).Range.Text = "ДДВ 18%";
                                wrdTable.Cell(wrdTable.Rows.Count, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                                wrdTable.Cell(wrdTable.Rows.Count, 2).Range.Text = txtDDV.Text.ToString();

                                wordDoc.Tables[1].Rows.Add(ref oMissing);
                                //   wrdTable.Cell(wrdTable.Rows.Count, 1).Merge(wrdTable.Cell(wrdTable.Rows.Count, 4));
                                wrdTable.Cell(wrdTable.Rows.Count, 1).Range.Text = "Вкупно за плаќање";
                                wrdTable.Cell(wrdTable.Rows.Count, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                                wrdTable.Cell(wrdTable.Rows.Count, 2).Range.Text = txtIznos_DDV.Text.ToString();
                                break;
                            }
                        default:
                            {
                                break;
                            }

                    }

                    // header and footer **********
                    bool header = true;
                label1:

                    Microsoft.Office.Interop.Word.Section sec = wordDoc.Sections[1];
                    Microsoft.Office.Interop.Word.Range rng = sec.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    if (!header)
                        rng = sec.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                    foreach (Microsoft.Office.Interop.Word.Field fld in rng.Fields)
                    {
                        rngFieldCode = fld.Code;
                        fieldText = rngFieldCode.Text;
                        // if (fld.Type == Microsoft.Office.Interop.Word.WdFieldType.wdFieldMergeField)
                        if (fieldText.StartsWith(" MERGEFIELD"))
                        {
                            endMerge = fieldText.IndexOf("\\");

                            fieldNameLength = fieldText.Length - endMerge;

                            fieldName = fieldText.Substring(11, endMerge - 11);

                            // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                            fieldName = fieldName.Trim();

                            //   String dataFieldName = fld.Code.Text.Trim();
                            if (fieldName == "IDTemp")
                            {
                                fld.Select();
                                wordApp.Selection.TypeText(dok.IDTemp.ToString());
                            }

                            if (fieldName == "arhiva")
                            {
                                fld.Select();
                                wordApp.Selection.TypeText(dok.Arhivskibroj.ToString());
                            }
                        }
                    }
                    if (!header)
                        goto label2;
                    else
                    {
                        header = false;
                        goto label1;
                    }
                label2:
                    wordDoc.SaveAs(@oTemplatePath + ".docx");
                    wordApp.Documents.Open(@oTemplatePath + ".docx");
                    wordDoc.PrintPreview();
                }
            }
        }

    }
}
