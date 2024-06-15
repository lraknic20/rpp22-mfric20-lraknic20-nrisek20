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
    // autor: Leon Raknić
    public partial class FormAddCriteria : Form
    {
        private CriteriaService criteriaService = new CriteriaService();
        public FormAddCriteria()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            AddCriteria();
        }

        private void AddCriteria()
        {
            string name = txtName.Text;
            string description = txtDescription.Text;
            int grade = ((int)numGrade.Value);

            string message = CheckData(name, description, grade);

            if(message == null)
            {
                Criterion criterion = new Criterion()
                {
                    name = name,
                    description = description,
                    grade = grade
                };
                // Dodavanje kriterija u bazu
                bool cretiriaCreated = criteriaService.AddCriteria(criterion);
                if (cretiriaCreated) Close();
                else MessageBox.Show("Greška", "Greška pri dodavanju u bazu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(message, "Nepotpuni podaci", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string CheckData(string name, string description, int grade)
        {
            string message = null;
            if(name == "") message += "Unesite naziv kriterija.\n";
            if (name.Length > 30) message += "Maksimalna duljina naziva kriterija je 30 znakova.\n";
            if (description == "") message += "Unesite opis kriterija.\n";
            if(grade == 0) message += "Unesite maksimalnu ocjenu kriterija.\n";
            return message;
        }
    }
}
