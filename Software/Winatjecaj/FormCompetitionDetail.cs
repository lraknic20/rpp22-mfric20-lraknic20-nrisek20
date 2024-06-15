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
    public partial class FormCompetitionDetail : Form
    {
        //Autor: Matija Fric
        private ApplicationService applicationService = new ApplicationService();
        private Competition selectedCompetition;
        private User currentUser;
        public FormCompetitionDetail(Competition _selectedCompetition, User _currentUser)
        {
            InitializeComponent();
            selectedCompetition = _selectedCompetition;
            currentUser = _currentUser;
            LoadInformation();
        }

        private void LoadInformation()
        {
            lbNaziv.Text = selectedCompetition.name;
            tbDescription.Text = selectedCompetition.description;
            tbCreationDate.Text = selectedCompetition.creation_date.ToString();
            tbDueDate.Text = selectedCompetition.due_date.ToString();
            tbDocumentation.Text = selectedCompetition.needed_documentation;
            if (selectedCompetition.opened == true)
            {
                tbOpened.Text = "Da";
                if(selectedCompetition.due_date > DateTime.Now)
                {
                    lbOpen.Text = "Natječaj je otvoren!";
                    lbOpen.ForeColor = Color.Green;
                }
                else
                {
                    lbOpen.Text = "Natječaj je zaotvoren!";
                    lbOpen.ForeColor = Color.Red;
                }
            }
            else
            {
                tbOpened.Text = "Ne";
                lbOpen.Text = "Natječaj je zaotvoren!";
                lbOpen.ForeColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void tbPrijava_Click(object sender, EventArgs e)
        {
            if(selectedCompetition.opened == true && selectedCompetition.due_date > DateTime.Now)
            {
                bool alreadySubmited = CheckIfSubmited(selectedCompetition, currentUser);
                if (alreadySubmited == true)
                {
                    MessageBox.Show("Već ste prijavljeni na ovaj natječaj!");
                }
                else
                {
                    FormApplication formApplication = new FormApplication(selectedCompetition, currentUser);
                    formApplication.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Natječaj je zatvoren!");
            }
        }

        private bool CheckIfSubmited(Competition selectedCompetition, User currentUser)
        {
            bool exists = applicationService.FindApplication(selectedCompetition, currentUser);
            return exists;
        }
    }
}
