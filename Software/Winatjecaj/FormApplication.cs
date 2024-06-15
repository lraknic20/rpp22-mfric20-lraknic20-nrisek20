using BusinessLayer.Services;
using EntitiesLayer.Entities;
using MegaDLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Application = EntitiesLayer.Entities.Application;

namespace Winatjecaj
{
    public partial class FormApplication : Form
    {
        //Autor: Matija Fric
        private ApplicationService applicationService = new ApplicationService();
        private Competition selectedCompetition;
        private User currentUser;
        private int NotUploaded;
        private MegaManager megaManager;
        private List<Documentation> documents;

        public FormApplication(Competition _selectedCompetition, User _currentUser)
        {
            InitializeComponent();
            selectedCompetition = _selectedCompetition;
            currentUser = _currentUser;
            megaManager = new MegaManager();
            documents = new List<Documentation>();
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {
            lbNaslov.Text = selectedCompetition.name;
            LoadUserData();
            LoadDocumenatation();
        }

        private void LoadDocumenatation()
        {
            string[] docs = selectedCompetition.needed_documentation.Split(new string[] { ", "}, StringSplitOptions.None);
            for(int i = 0; i < docs.Length; i++)
            {
                Documentation document = new Documentation { name = docs[i], url = "", competitions_id = selectedCompetition.id, users_id = currentUser.id };
                documents.Add(document);
            }
            NotUploaded = documents.Count;
            dgvDocumentation.DataSource = documents;
            dgvDocumentation.Columns[1].Width = 150;
            dgvDocumentation.Columns[2].Width = 200;

            dgvDocumentation.Columns[1].HeaderText = "Naziv";
            dgvDocumentation.Columns[2].HeaderText = "Url";

            dgvDocumentation.Columns[0].Visible = false;
            dgvDocumentation.Columns[3].Visible = false;
            dgvDocumentation.Columns[4].Visible = false;
            dgvDocumentation.Columns[5].Visible = false;
        }

        private void LoadUserData()
        {
            tbOIB.Text = currentUser.oib;
            tbFirstName.Text = currentUser.first_name;
            tbLastName.Text = currentUser.last_name;
            tbEmail.Text = currentUser.email;
            tbUsername.Text = currentUser.username;
            tbPhone.Text = currentUser.phone;
            tbAdress.Text = currentUser.adress;
        }

        private void dgvDocumentation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (e.Value == "")
                {
                    DataGridViewRow row = dgvDocumentation.Rows[e.RowIndex];
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(NotUploaded == 0)
            {
                Application _newApplication = new Application
                {
                    competitions_id = selectedCompetition.id,
                    users_id = currentUser.id,
                    application_date = DateTime.Now,
                    application_won = false,
                    grade = 0,
                };
                var unesen = applicationService.CreateApplication(_newApplication, documents);
                if(unesen == true)
                {
                    MessageBox.Show("Prijava je uspješna!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Greška kod prijave!");
                }
            }
            else
            {
                MessageBox.Show("Nije prenesena sva potrebna dokumentacija!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Pdf Files|*.pdf";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string link = dlg.FileName;
                link = link.Replace("\\", "/");
                UploadPdf(link);
            }
        }

        private void UploadPdf(string link)
        {
            try
            {
                var selectedRow = dgvDocumentation.CurrentRow.DataBoundItem as Documentation;
                var url = megaManager.Upload(link, currentUser.username);
                if(url != null || url != "")
                {
                    MessageBox.Show("Uspješno!");
                    selectedRow.url = url;
                    dgvDocumentation.DataSource = documents;
                    dgvDocumentation.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                    NotUploaded--;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Nije odabrana dokumentacija!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dgvDocumentation.CurrentRow.DataBoundItem as Documentation;
                selectedRow.url = "";
                dgvDocumentation.DataSource = documents;
                dgvDocumentation.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
                NotUploaded++;
            }
            catch
            {
                MessageBox.Show("Nije odabrana dokumentacija!");
            }
        }
    }
}
