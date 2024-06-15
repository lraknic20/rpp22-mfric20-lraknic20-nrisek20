using Dropbox.Api.Users;
using EntitiesLayer.Entities;
using MegaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dropbox.Api.TeamLog.PaperDownloadFormat;
using Application = EntitiesLayer.Entities.Application;

namespace Winatjecaj
{
    // autor: Leon Raknić
    public partial class FormDocumentation : Form
    {
        private Competition selectedCompetition;
        private Application selectedApplication;
        List<Documentation> documents;
        MegaManager megaManager;
        public FormDocumentation(Competition _selectedCompetition, Application _selectedApplication)
        {
            InitializeComponent();
            selectedCompetition = _selectedCompetition;
            selectedApplication = _selectedApplication;
            documents = new List<Documentation>();
            megaManager = new MegaManager();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDocumentation_Load(object sender, EventArgs e)
        {
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            foreach (var doc in selectedApplication.Documentations)
            {
                string docName = doc.name;
                docName = char.ToUpper(docName[0]) + docName.Substring(1);
                Documentation document = new Documentation
                {
                    name = docName,
                    url = doc.url
                };
                documents.Add(document);
            }
            dgvDocumentation.DataSource = documents;

            dgvDocumentation.Columns[1].HeaderText = "Naziv dokumenta";
            dgvDocumentation.Columns[2].HeaderText = "URL";

            dgvDocumentation.Columns[0].Visible = false;
            dgvDocumentation.Columns[3].Visible = false;
            dgvDocumentation.Columns[4].Visible = false;
            dgvDocumentation.Columns[5].Visible = false;

            dgvDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPreuzmi_Click(object sender, EventArgs e)
        {
            var selectedDocument = dgvDocumentation.CurrentRow.DataBoundItem as Documentation;
            if (selectedDocument != null)
            {
                string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string destDocuments = Path.Combine(myDocuments, "Dokumenti");

                if (!Directory.Exists(destDocuments))
                {
                    Directory.CreateDirectory(destDocuments);
                }

                string docName = selectedDocument.name;
                docName = char.ToUpper(docName[0]) + docName.Substring(1);

                string destination = Path.Combine(destDocuments, docName + " - " + selectedApplication.User + ".pdf");

                if(!File.Exists(destination))
                {
                    try
                    {
                        megaManager.Download(selectedDocument.url, destination);
                        Process.Start("explorer.exe", "/select," + destination);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Greška", "Greška pri preuzimanju dokumentacije.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Dokument je već prezuet. Želite li otvoriti mapu u kojoj se nalazi?", "Dokument postoji", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe", "/select," + destination);
                    }
                }
            }
        }
    }
}
