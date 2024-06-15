using BusinessLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winatjecaj
{
    // Autor: nrisek
    public partial class FormEnterCode : Form
    {
        UserService service = new UserService();
        User loggedInUser;
        public FormEnterCode(User _loggedInUser)
        {
            InitializeComponent();
            loggedInUser = _loggedInUser;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            var success = service.SendCode(loggedInUser);
            if(success)
            {
                lbMessage.Text = "Kod je poslan na Vašu email adresu ("+loggedInUser.email+"). (Ukoliko ne vidite poruku, provjerite 'Spam'.)";
            }
            else
            {
                MessageBox.Show("Greška kod slanja koda. Pokušajte ponovo.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var canParse = int.TryParse(tbCode.Text, out int code);
            if(canParse)
            {
                var matchingCode = service.CheckCode(code);
                if (matchingCode)
                {
                    //Prikaži početni zaslon aplikacije, proslijedi user-a
                    FormCompetition frm = new FormCompetition(loggedInUser);
                    frm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Unesen je neispravan kod. Prijava neuspješna.");
                }
            }
            else
            {
                MessageBox.Show("Unesite brojčanu vrijednost.");
            }
        }
    }
}
