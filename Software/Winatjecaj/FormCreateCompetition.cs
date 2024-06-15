using BusinessLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.Design;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winatjecaj
{
    // autor: Leon Raknić
    public partial class FormCreateCompetition : Form
    {
        private CompetitionService competitionService = new CompetitionService();
        private CriteriaService criteriaService = new CriteriaService();
        public FormCreateCompetition()
        {
            InitializeComponent();
        }

        private void FormCreateCompetition_Load(object sender, EventArgs e)
        {
            LoadCriterias();

            // Podešavanje tablice za dokumentaciju
            dgvDocumentation.Columns.Add("opis", "Opis");
            dgvDocumentation.Columns["opis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDocumentation.RowHeadersVisible = false;
            dgvDocumentation.AllowUserToAddRows = false;

            // Podešavanje formata due date
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDueDate.MinDate = DateTime.Today;
        }

        private void LoadCriterias(bool addCheckBox = true)
        {
            // Učitavanje kriterija iz baze i podešavanje izgleda tablice
            var allCriterias = criteriaService.GetAllCriterias();
            dgvCriteria.DataSource = allCriterias;
            dgvCriteria.Columns["Id"].Visible = false;
            dgvCriteria.Columns["Competitions"].Visible = false;

            dgvCriteria.Columns[1].HeaderText = "Naziv";
            dgvCriteria.Columns[2].HeaderText = "Opis";
            dgvCriteria.Columns[3].HeaderText = "Ocjena";
            dgvCriteria.Columns["name"].Width = 60;
            dgvCriteria.Columns["grade"].Width = 45;

            // Dodavanje potvrdnog okvira pokraj svakog kriterija
            if (addCheckBox)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                dgvCriteria.Columns.Insert(0, checkBoxColumn);
                dgvCriteria.Columns[0].Width = 20;
            }

            dgvCriteria.RowHeadersVisible = false;
        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            FormAddCriteria form = new FormAddCriteria();
            form.ShowDialog();
            bool addCheckBox = false;
            LoadCriterias(addCheckBox);
        }

        private void btnDeleteCriteria_Click(object sender, EventArgs e)
        {
            int checkedRows = 0;
            Criterion selectedCriteria = null;
            foreach (DataGridViewRow row in dgvCriteria.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    checkedRows++;
                    selectedCriteria = (Criterion)row.DataBoundItem;
                }
            }
            if (checkedRows > 1 || checkedRows == 0)
            {
                MessageBox.Show("Molimo odaberite jedan kriterij za brisanje.");
            }
            if (checkedRows == 1)
            {
                bool criteriaDeleted = criteriaService.DeleteCriteria(selectedCriteria);
                if (criteriaDeleted)
                {
                    bool addCheckBox = false;
                    LoadCriterias(addCheckBox);
                }
                else
                {
                    MessageBox.Show("Kriterij se koristi u nekom natječaju te se ne može izbrisati!", "Brisanje nije moguće", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            dgvDocumentation.Rows.Add();
            dgvDocumentation.CurrentCell = dgvDocumentation["opis", dgvDocumentation.Rows.Count - 1];
        }

        private void btnDeleteDocument_Click(object sender, EventArgs e)
        {
            if (dgvDocumentation.SelectedRows.Count > 0)
            {
                dgvDocumentation.Rows.Remove(dgvDocumentation.SelectedRows[0]);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string needed_documentation = null;

            if (dgvDocumentation.RowCount != 0)
            {
                foreach (DataGridViewRow row in dgvDocumentation.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        needed_documentation += row.Cells[0].Value.ToString() + ", ";
                    }
                }
                if (needed_documentation != null) needed_documentation = needed_documentation.Remove(needed_documentation.Length - 2);
            }

            string name = txtName.Text;
            string description = rtxtDescription.Text;
            DateTime creation_date = DateTime.Now;
            DateTime due_date = dtpDueDate.Value;

            List<Criterion> selectedCriteria = new List<Criterion>();

            selectedCriteria = GetSelectedCriteria();

            string message = CheckData(name, description, needed_documentation, selectedCriteria, creation_date, due_date);

            if (message == null)
            {
                Competition competition = new Competition()
                {
                    name = name,
                    description = description,
                    creation_date = creation_date,
                    due_date = due_date,
                    needed_documentation = needed_documentation,
                    opened = true,
                    Criteria = selectedCriteria
                };
                // Dodavanje natječaja u bazu
                bool competitionCreated = competitionService.CreateCompetition(competition);
                if (competitionCreated) Close();
                else MessageBox.Show("Greška pri dodavanju u bazu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(message, "Nepotpuni podaci", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string CheckData(string name, string description, string needed_documentation, List<Criterion> selectedCriteria, DateTime creation_date, DateTime due_date)
        {
            string message = null;
            if (name == "") message += "Unesite naziv natječaja.\n";
            if (name.Length > 30) message += "Maksimalna duljina naziva natječaja je 30 znakova.\n";
            if (description == "") message += "Unesite opis natječaja.\n";
            if (needed_documentation == null) message += "Definirajte potrebnu dokumentaciju.\n";
            if (selectedCriteria.Count == 0) message += "Potrebno je odabrati kriterije.\n";
            if (creation_date > due_date) message += "Molimo unesite datum dospijeća koji je veći od sadašnjeg.\n";
            return message;
        }

        private List<Criterion> GetSelectedCriteria()
        {
            List<Criterion> selectedCriteria = new List<Criterion>();
            foreach (DataGridViewRow row in dgvCriteria.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    selectedCriteria.Add((Criterion)row.DataBoundItem);
                }
            }
            return selectedCriteria;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
