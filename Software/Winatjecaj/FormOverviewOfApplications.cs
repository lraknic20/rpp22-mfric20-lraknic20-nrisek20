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
using Application = EntitiesLayer.Entities.Application;

namespace Winatjecaj
{
    // autor: Leon Raknić
    public partial class FormOverviewOfApplications : Form
    {
        private ApplicationService applicationService = new ApplicationService();
        private CompetitionService competitionService = new CompetitionService();
        private Competition selectedCompetition;
        public FormOverviewOfApplications(Competition _selectedCompetition)
        {
            InitializeComponent();
            selectedCompetition = _selectedCompetition;
        }

        private void FormOverviewOfApplications_Load(object sender, EventArgs e)
        {
            LoadApplications();
            lblNameOfCompetition.Text = selectedCompetition.name.ToString();
        }

        private void LoadApplications()
        {
            dgvApplications.DataSource = applicationService.GetApplicationsForCompetition(selectedCompetition);
            dgvApplications.Columns["users_id"].Visible = false;
            dgvApplications.Columns["competitions_id"].Visible = false;
            dgvApplications.Columns["competition"].Visible = false;
            dgvApplications.Columns["documentations"].Visible = false;

            dgvApplications.Columns["user"].HeaderText = "Korisnik";
            dgvApplications.Columns["application_date"].HeaderText = "Datum prijave";
            dgvApplications.Columns["grade"].HeaderText = "Ocjena";
            dgvApplications.Columns["application_won"].HeaderText = "Dobitnik";

            dgvApplications.Columns["user"].DisplayIndex = 0;
            dgvApplications.Columns["application_date"].DisplayIndex = 1;

            if (dgvApplications.Columns["Dokumentacija"] == null)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Dokumentacija";
                btnColumn.Text = "Prikaži dokumentaciju";
                btnColumn.UseColumnTextForButtonValue = true;
            
                dgvApplications.Columns.Insert(2, btnColumn);
            }

            dgvApplications.Columns["grade"].DisplayIndex = 3;
            dgvApplications.Columns["application_won"].DisplayIndex = 4;

            dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvApplications.Columns["Dokumentacija"].Index)
            {
                var selectedApplication = dgvApplications.Rows[e.RowIndex].DataBoundItem as Application;
                if(selectedApplication.Documentations.Count > 0)
                {
                    FormDocumentation formDocumentation = new FormDocumentation(selectedCompetition, selectedApplication);
                    formDocumentation.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Dokumentacija ne postoji!");
                }
            }
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            if(dgvApplications.CurrentRow != null)
            {
                if(CheckForWinners())
                {
                    var selectedApplication = dgvApplications.CurrentRow.DataBoundItem as Application;
                    FormEvaluateApplication formEvaluateApplications = new FormEvaluateApplication(selectedApplication);
                    formEvaluateApplications.ShowDialog();
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Pobjednik je već proglašen!");
                }
            }
        }

        private void btnDeclareWinner_Click(object sender, EventArgs e)
        {
            if (dgvApplications.CurrentRow != null)
            {
                if(CheckGrades())
                {
                    if (CheckForWinners())
                    {
                        var selectedApplication = dgvApplications.CurrentRow.DataBoundItem as Application;
                        selectedApplication.application_won = true;
                        bool applicationUpdated = applicationService.UpdateApplication(selectedApplication, "won");
                        selectedCompetition.opened = false;
                        bool competitionUpdated = competitionService.UpdateCompetition(selectedCompetition);
                        if (applicationUpdated && competitionUpdated) LoadApplications();
                        else MessageBox.Show("Greška pri spremanju pobjednika.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Već postoji pobjednik natječaja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nisu ocjenjene sve prijave!");
                }
            }
        }

        private bool CheckGrades()
        {
            int zeroCounter = 0;

            foreach (DataGridViewRow row in dgvApplications.Rows)
            {
                if ((int)row.Cells["grade"].Value == 0)
                {
                    zeroCounter++;
                }
            }
            if (zeroCounter > 0) return false;
            else return true;
        }

        private bool CheckForWinners()
        {
            int trueCounter = 0;

            foreach (DataGridViewRow row in dgvApplications.Rows)
            {
                if ((bool)row.Cells["application_won"].Value == true)
                {
                    trueCounter++;
                }
            }
            if (trueCounter >= 1) return false;
            else return true;
        }

        private void btnCancelWinner_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApplications.Rows)
            {
                if ((bool)row.Cells["application_won"].Value == true)
                {
                    var selectedApplication = row.DataBoundItem as Application;
                    selectedApplication.application_won = false;
                    bool applicationUpdated = applicationService.UpdateApplication(selectedApplication, "won");
                    selectedCompetition.opened = true;
                    bool competitionUpdated = competitionService.UpdateCompetition(selectedCompetition);
                    if (applicationUpdated && competitionUpdated) LoadApplications();
                    else MessageBox.Show("Greška pri brisanju pobjednika.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}