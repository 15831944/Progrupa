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
                        case "arhiva":
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText("Vivek");
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
                        case "IDTemp":
                            {

                                break;
                            }
                        default:
                            {
                                myMergeField.Select();
                                wordApp.Selection.TypeText(indexTemp.ToString());
                                break;
                            }
                    }
                }

            }
            wordDoc.SaveAs(@oTemplatePath + ".docx");
            wordApp.Documents.Open(@oTemplatePath + ".docx");

        }
    }
}
