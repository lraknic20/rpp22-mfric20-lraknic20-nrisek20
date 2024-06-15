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
using static Dropbox.Api.Team.GroupAccessType;
using Application = EntitiesLayer.Entities.Application;

namespace Winatjecaj
{
    // autor: Leon Raknić
    public partial class FormEvaluateApplication : Form
    {
        private CriteriaService criteriaService = new CriteriaService();
        private ApplicationService applicationService = new ApplicationService();
        private Application selectedApplication;
        public FormEvaluateApplication(Application _selectedApplicationService)
        {
            InitializeComponent();
            selectedApplication = _selectedApplicationService;
        }

        private void FormEvaluateApplication_Load(object sender, EventArgs e)
        {
            lblNameAndSurname.Text = selectedApplication.User.ToString();
            LoadCriterias();
        }

        private void LoadCriterias()
        {
            // Učitavanje kriterija iz baze i podešavanje izgleda tablice
            var allCriterias = criteriaService.GetCriteriasForCompetition(selectedApplication.Competition);
            dgvCriteria.DataSource = allCriterias;
            dgvCriteria.Columns["Id"].Visible = false;
            dgvCriteria.Columns["Competitions"].Visible = false;

            DataGridViewColumn gradeColumn = new DataGridViewTextBoxColumn();
            gradeColumn.Name = "ocjena";
            gradeColumn.HeaderText = "Ocjena";
            dgvCriteria.Columns.Insert(3, gradeColumn);

            dgvCriteria.Columns[1].HeaderText = "Naziv";
            dgvCriteria.Columns[2].HeaderText = "Opis";
            dgvCriteria.Columns[4].HeaderText = "Max. ocjena";
            dgvCriteria.Columns["name"].Width = 60;
            dgvCriteria.Columns[3].Width = 30;
            dgvCriteria.Columns["grade"].Width = 45;

            dgvCriteria.Columns[1].ReadOnly = true;
            dgvCriteria.Columns[2].ReadOnly = true;
            dgvCriteria.Columns[4].ReadOnly = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCriteria_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                var gradeCell = dgvCriteria.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int grade;
                if(gradeCell != null)
                {
                    if (int.TryParse(gradeCell.ToString(), out grade))
                    {
                        int maxGrade = int.Parse(dgvCriteria.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
                        if (grade > maxGrade || grade < 0)
                        {
                            MessageBox.Show("Molimo unesite ispravnu vrijednost!");
                            dgvCriteria.CellValueChanged -= dgvCriteria_CellValueChanged;
                            dgvCriteria.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                            dgvCriteria.CellValueChanged += dgvCriteria_CellValueChanged;
                            lblTotalGrade.Text = CalculateTotalGrade().ToString();
                        }
                        else
                        {
                            lblTotalGrade.Text = CalculateTotalGrade().ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Molimo unesite numeričku vrijednost!");
                        dgvCriteria.CellValueChanged -= dgvCriteria_CellValueChanged;
                        dgvCriteria.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        dgvCriteria.CellValueChanged += dgvCriteria_CellValueChanged;
                        lblTotalGrade.Text = CalculateTotalGrade().ToString();
                    }
                }
            }
        }

        private int CalculateTotalGrade()
        {
            int sum = 0;
            for (int i = 0; i < dgvCriteria.Rows.Count; i++)
            {
                int grade;
                var gradeCell = dgvCriteria.Rows[i].Cells[3].Value;
                if(gradeCell != null)
                {
                    if (int.TryParse(gradeCell.ToString(), out grade))
                    {
                        sum += grade;
                    }
                }
            }
            return sum;
        }

        private bool CheckEmptyGrades()
        {
            bool empty = false;
            foreach (DataGridViewRow row in dgvCriteria.Rows)
            {
                if(row.Cells["ocjena"].Value == null)
                {
                    return true;
                }
            }
            return empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!CheckEmptyGrades())
            {
                if (selectedApplication.grade != CalculateTotalGrade())
                {
                    selectedApplication.grade = CalculateTotalGrade();
                    // Spremanje ocjena u bazu
                    bool applicationUpdated = applicationService.UpdateApplication(selectedApplication, "grade");
                    if (applicationUpdated) Close();
                    else MessageBox.Show("Greška pri spremanju ocjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else Close();
            }
            else
            {
                MessageBox.Show("Molimo unesite sve ocjene.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
