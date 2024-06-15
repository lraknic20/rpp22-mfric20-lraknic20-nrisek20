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
using Winatjecaj.Exceptions;

namespace Winatjecaj
{
    // Autor: nrisek
    public partial class FormAccountActivation : Form
    {
        UserService userService = new UserService();
        public FormAccountActivation()
        {
            InitializeComponent();
        }

        private void FormAccountActivation_Load(object sender, EventArgs e)
        {
            LoadDeactivatedAccounts();
        }

        private void LoadDeactivatedAccounts()
        {
            var deactivatedAccounts = userService.GetDeactivatedAccounts();
            if(deactivatedAccounts != null )
            {
                dgvDeactivatedAccounts.DataSource = deactivatedAccounts;               
                HideHeaders(dgvDeactivatedAccounts);
                RenameHeaders(dgvDeactivatedAccounts);
                FitColumnHeaders(dgvDeactivatedAccounts);
            }
        }

        private void HideHeaders(DataGridView dgv)
        {
            dgv.Columns["Applications"].Visible = false;
            dgv.Columns["Role"].Visible = false;
            dgv.Columns["password"].Visible = false;
            dgv.Columns["roles_id"].Visible = false;
        }

        private void FitColumnHeaders(DataGridView dgv)
        {
            dgv.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["oib"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["first_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["last_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["adress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void RenameHeaders(DataGridView dgv)
        {
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["oib"].HeaderText = "OIB";
            dgv.Columns["first_name"].HeaderText = "Ime";
            dgv.Columns["last_name"].HeaderText = "Prezime";
            dgv.Columns["email"].HeaderText = "Email";
            dgv.Columns["phone"].HeaderText = "Broj telefona";
            dgv.Columns["username"].HeaderText = "Korisničko ime";
            dgv.Columns["adress"].HeaderText = "Adresa";
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                var account = dgvDeactivatedAccounts.CurrentRow.DataBoundItem as User;
                bool accountActivated = userService.ActivateAccount(account);
                if (accountActivated)
                { 
                    LoadDeactivatedAccounts();
                    var subject = "Winatječaj - Račun aktiviran";
                    var body = "Korisnički račun s korisničkim imenom "+ account.username +" Vam je aktiviran. Možete se prijaviti u sustav.";
                    userService.SendEmail(account, subject, body);
                }
            }
            catch (AccountNotSelectedException ex)
            {
                MessageBox.Show(ex.message);
            }
        }
    }
}
