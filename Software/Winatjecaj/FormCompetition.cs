
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
    
    public partial class FormCompetition : Form
    {
        //Autor: Matija Fric
        private CompetitionService competitionService = new CompetitionService();
        private UserService userService = new UserService();
        private ApplicationService applicationService = new ApplicationService();
        private string filter = "";
        private string sort = "";
        private User currentUser; 
        public FormCompetition(User _currentUser)
        {
            InitializeComponent();
            currentUser = _currentUser;
        }

        private void FormCompetition_Load(object sender, EventArgs e)
        {
            if (!currentUser.isAdmin())
            {
                btnAccountActivation.Visible = false;
                btnCreateCompetition.Visible = false;
                btnOverviewOfApplications.Visible = false;
            }
            LoadCompetitions(filter, sort);
            LoadSort();
        }

        private void LoadSort()
        {
            cmbSort.Items.Add("ID");
            cmbSort.Items.Add("Naziv");
            cmbSort.Items.Add("Datum kreiranja");
            cmbSort.Items.Add("Datum dospijeća");
            cmbSort.Items.Add("Otvoren");
        }

        private void LoadCompetitions(string filter, string sort)
        {
            //dohvaćanje svih natječaja
            var allCompetitions = competitionService.GetAllCompetitions(filter, sort);
            dgvCompetitions.DataSource = allCompetitions;
            //skrivanje nepotrebnog saržaja
            dgvCompetitions.Columns["description"].Visible = false;
            dgvCompetitions.Columns["Applications"].Visible = false;
            dgvCompetitions.Columns["Criteria"].Visible = false;
            //uređivanje širine stupaca
            dgvCompetitions.Columns[0].Width = 40;
            dgvCompetitions.Columns[1].Width = 200;
            dgvCompetitions.Columns[3].Width = 150;
            dgvCompetitions.Columns[4].Width = 152;
            dgvCompetitions.Columns[5].Width = 230;
            //promjena naslova na hrvatski
            dgvCompetitions.Columns[0].HeaderText = "ID";
            dgvCompetitions.Columns[1].HeaderText = "Naziv";
            dgvCompetitions.Columns[3].HeaderText = "Datum kreiranja";
            dgvCompetitions.Columns[4].HeaderText = "Datum dospijeća";
            dgvCompetitions.Columns[5].HeaderText = "Potrebna dokumentacija";
            dgvCompetitions.Columns[6].HeaderText = "Otvoren";
        }

        private void dgvCompetitions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //služi za promjenu boje ako je datum u prošlosti
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                DateTime dateValue = (DateTime)e.Value;
                if (dateValue < DateTime.Now)
                {
                    DataGridViewRow row = dgvCompetitions.Rows[e.RowIndex];
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            //služi za promjenu boje ako je natječaj zatvoren
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                if (e.Value.ToString() != "True")
                {
                    DataGridViewRow row = dgvCompetitions.Rows[e.RowIndex];
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = tbFilter.Text;
            if(filter != "")
            {
                LoadCompetitions(filter, sort);
            }
            else
            {
                MessageBox.Show("Unesite tekst za filtriranje!");
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            filter = "";
            sort = "";
            LoadCompetitions(filter, sort);
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = cmbSort.Text;
            Console.WriteLine(sort);
            LoadCompetitions(filter, sort);
        }
        // Autor: nrisek
        private void pbProfil_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(currentUser);
            formProfile.ShowDialog();
            currentUser = userService.GetUser(currentUser.username);
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (currentUser.isAdmin())
            {
                MessageBox.Show("Admini se ne mogu prijaviti na natječaje!");
            }
            else
            {
                var selectedCompetition = dgvCompetitions.CurrentRow.DataBoundItem as Competition;
                if(selectedCompetition != null && selectedCompetition.opened == true && selectedCompetition.due_date > DateTime.Now)
                {
                    bool alreadySubmited = CheckIfSubmited(selectedCompetition, currentUser);
                    if(alreadySubmited == true)
                    {
                        MessageBox.Show("Već ste prijavljeni na ovaj natječaj!");
                    }
                    else
                    {
                        FormApplication formApplication = new FormApplication(selectedCompetition, currentUser);
                        formApplication.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Natječaj je zatvoren!");
                }
            }

        }

        private bool CheckIfSubmited(Competition selectedCompetition, User currentUser)
        {
            bool exists = applicationService.FindApplication(selectedCompetition, currentUser);
            return exists;
        }
        // Autor: nrisek
        private void btnAccountActivation_Click(object sender, EventArgs e)
        {
            FormAccountActivation form = new FormAccountActivation();
            form.ShowDialog();
        }

        private void btnCreateCompetition_Click(object sender, EventArgs e)
        {
            FormCreateCompetition form = new FormCreateCompetition();
            form.ShowDialog();
            LoadCompetitions(filter, sort);
        }
        
        private void btnDetalji_Click(object sender, EventArgs e)
        {
            var selectedCompetition = dgvCompetitions.CurrentRow.DataBoundItem as Competition;
            if(selectedCompetition != null)
            {
                FormCompetitionDetail formCompetitionDetail = new FormCompetitionDetail(selectedCompetition, currentUser);
                formCompetitionDetail.ShowDialog();
            }
        }

        private void btnOverviewOfApplications_Click(object sender, EventArgs e)
        {
            var selectedCompetition = dgvCompetitions.CurrentRow.DataBoundItem as Competition;
            if (selectedCompetition != null)
            {
                FormOverviewOfApplications formOverviewOfApplications = new FormOverviewOfApplications(selectedCompetition);
                formOverviewOfApplications.ShowDialog();
                LoadCompetitions(filter, sort);
            }
        }
    }
}
