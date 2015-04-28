using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace APP_FIKT_ProGrupa
{
    class NovaRegistracija
    {
        public void registracija (String ime, String prezime, String email, String telefon, String userName, String pass, String passChek, bool admin, bool status, bool potvrden)
        {

            BrziPonudiDataContext context = new BrziPonudiDataContext();

                //внесување на податоците во базата на податоци
                BrziPonudiDataContext addUser = new BrziPonudiDataContext();
                Vraboten v = new Vraboten();
                v.ImeV = ime;
                v.PrezimeV = prezime;
                v.EmailV = email;
                v.TelefonV = telefon;
                v.KorisnickoImeV = userName;
                v.PasswordV = pass;
                v.AdminV = admin;
                v.StatusV = status;
                v.PotvrdenV = potvrden;
                addUser.Vrabotens.InsertOnSubmit(v);
                addUser.SubmitChanges();
               // MessageBox.Show("Вашите податоци се успешно внесени. По добиена дозвола од администратор, ќе ви биде овозможен пристап до системот!", "Ви честитаме", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
