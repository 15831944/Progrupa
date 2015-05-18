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
    public partial class frmNovaPonuda : Form
    {
        BrziPonudiDataContext context = new BrziPonudiDataContext();

        Microsoft.Office.Interop.Word.Application wordApp;
        Document wordDoc = new Document();

        int indexTemp;
        int indexKlient;
        int vrabotenID;

        public frmNovaPonuda(frmMenu parent, int vrabotenID)
        {
            this.vrabotenID = vrabotenID;
            InitializeComponent();
            MdiParent = parent;
        }

        private void frmNovaPonuda_Load(object sender, EventArgs e)
        {
            var queryTemp = (from temp in context.tblTemplejts
                             select temp).ToList();
            if (queryTemp.Count() > 0)
            {
                foreach (var templejt in queryTemp)
                    cmbTemp.Items.Add(templejt.ImeTemp);
            }

            var queryKlient = (from klient in context.tblKlientis
                               select klient).ToList();
            if (queryKlient.Count() > 0)
            {
                foreach (var Klient in queryKlient)
                    cmbKlient.Items.Add(Klient.ImeFirma);
            }

            var queryProizvod = (from proizvod in context.tblProizvodis
                               select proizvod).ToList();
            if (queryKlient.Count() > 0)
            {
                foreach (var Proizvod in queryProizvod)
                    cmbProizvod.Items.Add(Proizvod.Naziv);
            }

            dtVaznost.MinDate = DateTime.Now;
        }

        private string najdiMesec (int mesec)
        {
            string imeMesec;
            switch (mesec)
            {
                case 1:
                    {
                        imeMesec = "јануари";
                        return imeMesec;
                    }
                case 2:
                    {
                        imeMesec = "февруари";
                        return imeMesec;
                    }
                case 3:
                    {
                        imeMesec = "март";
                        return imeMesec;
                    }
                case 4:
                    {
                        imeMesec = "април";
                        return imeMesec;
                    }
                case 5:
                    {
                        imeMesec = "мај";
                        return imeMesec;
                    }
                case 6:
                    {
                        imeMesec = "јуни";
                        return imeMesec;
                    }
                case 7:
                    {
                        imeMesec = "јули";
                        return imeMesec;
                    }
                case 8:
                    {
                        imeMesec = "август";
                        return imeMesec;
                    }
                case 9:
                    {
                        imeMesec = "септември";
                        return imeMesec;
                    }
                case 10:
                    {
                        imeMesec = "октомври";
                        return imeMesec;
                    }
                case 11:
                    {
                        imeMesec = "ноември";
                        return imeMesec;
                    }
                case 12:
                    {
                        imeMesec = "декенври";
                        return imeMesec;
                    }
                default:
                    {
                        return "";
                    }
            }
        }

        private void cmbProizvod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var proizvod = context.tblProizvodis.Single<tblProizvodi>(ee => ee.Naziv == cmbProizvod.Text);
            txtCena.Text = proizvod.Cena.ToString();
        }

        private void btnProizvodAdd_Click(object sender, EventArgs e)
        {
            var proizvod = context.tblProizvodis.Single<tblProizvodi>(ee => ee.Naziv == cmbProizvod.Text);
            grdStavka.Rows.Add();
            grdStavka[0, grdStavka.RowCount-1].Value = proizvod.IDProizvodPonuda.ToString();
            grdStavka[1, grdStavka.RowCount-1].Value = proizvod.Naziv.ToString();
            grdStavka[2, grdStavka.RowCount-1].Value = txtKolicina.Text.ToString();
            grdStavka[3, grdStavka.RowCount-1].Value = txtCena.Text.ToString();
            grdStavka[4, grdStavka.RowCount-1].Value = int.Parse(txtKolicina.Text.ToString()) * int.Parse(txtCena.Text.ToString());
            txtVkupno.Text = (int.Parse(txtVkupno.Text) + int.Parse(txtKolicina.Text) * int.Parse(txtCena.Text)).ToString();
            txtDDV.Text = (float.Parse(txtVkupno.Text) * 0.18).ToString();
            txtIznos_DDV.Text = (int.Parse(txtVkupno.Text) + float.Parse(txtDDV.Text)).ToString();
            txtKolicina.Text = "1";
            cmbProizvod.Text = "";
            txtCena.Text = "";
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {

            Object oMissing = System.Reflection.Missing.Value;

            Object oTemplatePath;// = "D:\\MyTemplate.dotx";
            string oTempName;

            try
            {
                var templejt = context.tblTemplejts.Single<tblTemplejt>(ee => ee.ImeTemp == cmbTemp.Text);
                indexTemp = templejt.IDTemplejt;

                var klient = context.tblKlientis.Single<tblKlienti>(ee => ee.ImeFirma == cmbKlient.Text);
                indexKlient = klient.IDFirma;

                oTempName = templejt.ImeTemp;
                oTemplatePath = templejt.LokacijaTemplejt + '/' + oTempName + ".dotx";

            }
            catch (Exception)
            {
                MessageBox.Show("Нема доволно аргументи за креирање на понуда!", "Недоволно аргументи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Vraboten = context.Vrabotens.Single<Vraboten>(ee => ee.VrabotenID == vrabotenID);
            var Klient = context.tblKlientis.Single<tblKlienti>(ee => ee.ImeFirma == cmbKlient.Text);

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
                                int mesec = int.Parse(dtVaznost.Value.Month.ToString());
                                myMergeField.Select();
                                wordApp.Selection.TypeText(dtVaznost.Value.Day.ToString() + " " + najdiMesec(mesec) + " " + dtVaznost.Value.Year.ToString());
                                break;
                            }
                        case "izdadenoNa":
                            {
                                int mesec = int.Parse(DateTime.Now.Month.ToString());
                                myMergeField.Select();
                                wordApp.Selection.TypeText(DateTime.Now.Day.ToString() + " " + najdiMesec(mesec) + " " + DateTime.Now.Year.ToString());
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
                                Microsoft.Office.Interop.Word.Table wrdTable = wordDoc.Tables.Add(wrdSelect.Range, 1, 5, ref oMissing, ref oMissing);

                                wrdTable.Range.ParagraphFormat.RightIndent = wordDoc.Paragraphs.RightIndent;
                                wrdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                                wrdTable.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth075pt;
                                wrdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                                wrdTable.Borders.InsideLineWidth = WdLineWidth.wdLineWidth075pt;

                                wrdTable.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                                wrdTable.Columns[1].SetWidth(50, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[2].SetWidth(180, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[3].SetWidth(60, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[4].SetWidth(60, WdRulerStyle.wdAdjustNone);
                                wrdTable.Columns[5].SetWidth(60, WdRulerStyle.wdAdjustNone);

                                wrdTable.Cell(1, 1).Range.Text = "Шифра";
                                wrdTable.Cell(1, 2).Range.Text = "Назив";
                                wrdTable.Cell(1, 3).Range.Text = "Количина";
                                wrdTable.Cell(1, 4).Range.Text = "Цена";
                                wrdTable.Cell(1, 5).Range.Text = "Износ";
                                // wrdTable.Cell(0, 0).Range.SetRange(0,50);

                                for (int i = 0; i < grdStavka.RowCount; i++)
                                {
                                    wordDoc.Tables[1].Rows.Add(ref oMissing);
                                    wrdTable.Cell(i + 2, 1).Range.Text = grdStavka[0, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 2).Range.Text = grdStavka[1, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 3).Range.Text = grdStavka[2, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 4).Range.Text = grdStavka[3, i].Value.ToString();
                                    wrdTable.Cell(i + 2, 5).Range.Text = grdStavka[4, i].Value.ToString();
                                }

                                wordDoc.Tables[1].Rows.Add(ref oMissing);
                                wrdTable.Cell(wrdTable.Rows.Count, 1).Merge(wrdTable.Cell(wrdTable.Rows.Count, 4));
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
                    }
                }

            var addArhivski = new tblArhiva();
            context.tblArhivas.InsertOnSubmit(addArhivski);
            context.SubmitChanges();
         //   context = new BrziPonudiDataContext();
            var posledenArhivski = addArhivski.IDArhivskiBroj;
         //   int idArhivski = addArhivski.IDArhivskiBroj; 
            //imame indextemp od prethodno;
            int godina = DateTime.Now.Year;
            string arhivskiBR = posledenArhivski.ToString() + "-" + indexTemp + "-" + godina.ToString();
            addArhivski.Arhivskibroj = arhivskiBR;
            var dokument = new tblDokumenti()
            {
                Arhivskibroj = arhivskiBR,
                IDFirma = indexKlient,
                IDVraboteni = vrabotenID,
                DataZaOdgovor = dtVaznost.Value,
                KalendarskaGodina = godina.ToString(),
                IzdadenoNa = DateTime.Now,
                IDTemp = indexTemp,
            };
            context.tblDokumentis.InsertOnSubmit(dokument);
            context.SubmitChanges();


        //    context = new BrziPonudiDataContext();
        //    dokument = context.tblDokumentis.LastOrDefault();
            var posledenDokument = dokument.IDDokument;
            for (int stavkaProizvodi = 0; stavkaProizvodi < grdStavka.RowCount; stavkaProizvodi++)
            {
                var stavka = new tblStavka()
                {
                    IDProizvodPonuda = int.Parse(grdStavka[0, stavkaProizvodi].Value.ToString()),
                    Kolicina = grdStavka[2, stavkaProizvodi].Value.ToString(),
                    Cena = grdStavka[3, stavkaProizvodi].Value.ToString(),
                    IDPonuda = posledenDokument,
                };
                context.tblStavkas.InsertOnSubmit(stavka);
            }
            context.SubmitChanges();
            // header and footer **********
            bool header = true;
        label1:

            Microsoft.Office.Interop.Word.Section sec = wordDoc.Sections[1];
            Microsoft.Office.Interop.Word.Range rng = sec.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            if (!header)
                rng = sec.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

            foreach (Microsoft.Office.Interop.Word.Field fld in rng.Fields)
            {
                Range rngFieldCode = fld.Code;
                String fieldText = rngFieldCode.Text;
                // if (fld.Type == Microsoft.Office.Interop.Word.WdFieldType.wdFieldMergeField)
                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    int endMerge = fieldText.IndexOf("\\");

                    int fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    //   String dataFieldName = fld.Code.Text.Trim();
                    if (fieldName == "IDTemp")
                    {
                        fld.Select();
                        wordApp.Selection.TypeText(indexTemp.ToString());
                    }

                    if (fieldName == "arhiva")
                    {
                        fld.Select();
                        wordApp.Selection.TypeText(arhivskiBR);
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
