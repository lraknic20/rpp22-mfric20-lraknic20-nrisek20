using BusinessLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winatjecaj
{
    // Autor: nrisek
    public partial class FormRegistration : Form
    {
        UserService service = new UserService();
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string oib = tbOib.Text;
            string name = tbName.Text;
            string lastName = tbLastName.Text;
            string adress = tbAdress.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string checkData = CheckEnteredData(oib, email, name, lastName, adress, phone, username, password);

            if (checkData == "")
            {
                int userExists = service.CheckUser(email, username);
                if(userExists == 0)
                {
                    // Korisnik ne postoji, kreiraj korisnički račun
                    User newUser = new User
                    {
                        oib = oib,
                        first_name = name,
                        last_name = lastName,
                        adress = adress,
                        phone = phone,
                        email = email,
                        username = username,
                        password = password,
                        roles_id = 6, // 1 = korisnik, 2 = admin, 6 = deaktiviran
                    };
                    bool userAccountCreated = service.CreateUserAccount(newUser);
                    if (userAccountCreated)
                    {
                        SendEmailToAdmin(newUser);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška kod kreiranja korisničkog računa. Pokušajte ponovo.");
                    }
                }
                else if(userExists == 1)
                {
                    MessageBox.Show("Korisnik s unesenom email adresom već postoji.");
                }
                else
                {
                    MessageBox.Show("Korisnik s unesenim korisničkim imenom već postoji.");
                }
            }
            else
            {
                MessageBox.Show(""+checkData);
            }
        }

        private void SendEmailToAdmin(User newUser)
        {
            var success = service.SendEmailToAdmin(newUser);
            if (success)
            {
                MessageBox.Show("Korisnički račun je kreiran, prijava će biti moguća tek nakon aktivacije istog. Molimo Vas da pričekate dok ga administrator sustava ne aktivira.");
            }
            else
            {
                MessageBox.Show("Greška kod slanja koda. Pokušajte ponovo.");
            }
        }

        private string CheckEnteredData(string oib, string email, string name, string lastName, string adress, string phone, string username, string password)
        {
            string message = "";
            if (oib.Length != 11 || !IsNumeric(oib)) message += "Unesite ispravan OIB.\n";
            if (!IsValidEmail(email)) message += "Unesite ispravnu email adresu.\n";
            if (name == "") message += "Unesite ime.\n";
            if (lastName == "") message += "Unesite prezime.\n";
            if (adress == "") message += "Unesite adresu.\n";
            if (phone == "" || !IsNumeric(phone)) message += "Unesite ispravan broj telefona.\n";
            if (username == "") message += "Unesite korisničko ime.\n";
            if (password == "") message += "Unesite lozinku.\n";
            return message;
        }

        public bool IsNumeric(string str)
        {
            return str.All(char.IsDigit);
        }

        public bool IsValidEmail(string email)
        {
            return service.SendWelcomeMail(email);
        }
    }
}
