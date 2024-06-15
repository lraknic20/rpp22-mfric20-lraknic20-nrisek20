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
    public partial class FormLogin : Form
    {
        UserService service = new UserService();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(CheckEnteredData() == true )
            {
                var user = service.GetUser(tbUsername.Text, tbPassword.Text);
                if(user != null )
                {
                    if(!user.isActivated())
                    {
                        MessageBox.Show("Korisnički račun nije aktiviran!");
                    }
                    else
                    {
                        FormEnterCode frm = new FormEnterCode(user);
                        frm.Show();
                        Hide();
                    }    
                }
                else
                {
                    MessageBox.Show("Korisnički račun s unesenim podacima ne postoji!");
                }
            }
            else
            {
                MessageBox.Show("Unesite sve potrebne podatke!");
            }
        }

        private bool CheckEnteredData()
        {
            if(tbPassword.Text == "" || tbUsername.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegistration frm = new FormRegistration();
            frm.ShowDialog();
        }
    }
}
