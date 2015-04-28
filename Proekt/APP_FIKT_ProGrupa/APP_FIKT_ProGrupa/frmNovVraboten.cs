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
    public partial class frmNovVraboten : Form
    {
        BrziPonudiDataContext context = new BrziPonudiDataContext();

        public frmNovVraboten(frmMenu parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

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
            else if (txtPrezime.Text == "" || txtPrezime.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtPrezime.Focus();
            }
            else if (txtMail.Text == "" || txtMail.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtMail.Focus();
            }
            else if (txtTel.Text == "" || txtTel.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtTel.Focus();
            }
            else if (txtUserName.Text == "" || txtUserName.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtUserName.Focus();
            }
            else if (txtPass.Text == "" || txtPass.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtPass.Focus();
            }
            else if (txtPassConfirm.Text == "" || txtPassConfirm.Text[0] == ' ')
            {
                MessageBox.Show("Внесени се невалидни податоци!", "Невалидни податоци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = true;
                txtPassConfirm.Focus();
            }
            else if (txtPass.Text != txtPassConfirm.Text)
            {
                MessageBox.Show("Несофпаѓање при потврдувањето на лозинката!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtPassConfirm.Text = "";
                txtPass.Focus();
                flag = true;
            }

            else if (!flag)
            {
                // проверка дали корисничкото име е слободно
                var queryChekUserName = (from cun in context.Vrabotens
                                         where cun.KorisnickoImeV == txtUserName.Text
                                         select cun).ToList();
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
                else if (!flag)
                {
                    //внесување на податоците во базата на податоци
                    bool isAdmin = false;
                    bool isPotvrden = false;
                    bool isAktiven = false;
                    if (cbAdmin.Checked)
                        isAdmin = true;
                    if (cbPotvrden.Checked)
                        isPotvrden = true;
                    if (cbAktiven.Checked)
                        isAktiven = true;

                    var v = new Vraboten
                    {
                        ImeV = txtIme.Text,
                        PrezimeV = txtPrezime.Text,
                        EmailV = txtMail.Text,
                        TelefonV = txtTel.Text,
                        KorisnickoImeV = txtUserName.Text,
                        PasswordV = txtPass.Text,
                        AdminV = isAdmin,
                        StatusV = isAktiven,
                        PotvrdenV = isPotvrden,
                    };
                    context.Vrabotens.InsertOnSubmit(v);
                    context.SubmitChanges();
                    MessageBox.Show("Вашите податоци се успешно внесени. По добиена дозвола од администратор, ќе ви биде овозможен пристап до системот!", "Ви честитаме", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIme.Text = "";
                    txtPrezime.Text = "";
                    txtMail.Text = "";
                    txtTel.Text = "";
                    txtUserName.Text = "";
                    txtPass.Text = "";
                    txtPassConfirm.Text = "";
                    cbAdmin.Checked = false;
                    cbAktiven.Checked = false;
                    cbPotvrden.Checked = false;
                    txtIme.Focus();
                }
            }
        }
    }
}
