using BusinessLayer.Services;
using EntitiesLayer.Entities;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Winatjecaj.Exceptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Winatjecaj
{
    // Autor: nrisek
    public partial class FormProfile : Form
    {
        User loggedInUser;
        UserService userService = new UserService();
        CompetitionService competitionService = new CompetitionService();
        bool passwordHidden = true;
        public FormProfile(User _loggedInUser)
        {
            InitializeComponent();
            loggedInUser = _loggedInUser;
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            ShowUserData();
            DisableEdit();
            btnSaveChanges.Enabled = false;
            ShowOpenCompetitions(competitionService.GetOpenCompetitions(loggedInUser.id));
            ShowClosedCompetitions(competitionService.GetClosedCompetitions(loggedInUser.id));
            ShowWonCompetitions(competitionService.GetWonCompetitions(loggedInUser.id));
        }

        private void ShowWonCompetitions(List<object> wonUserCompetitions)
        {
            if(wonUserCompetitions.Count > 0)
            {
                dgvWonUserCompetitions.DataSource = wonUserCompetitions;
                RenameHeaders(dgvWonUserCompetitions);
                FitColumnHeaders(dgvWonUserCompetitions);
            }    
        }

        private void ShowClosedCompetitions(List<object> closedUserCompetitions)
        {
            if(closedUserCompetitions.Count > 0)
            {
                dgvClosedUserCompetitions.DataSource = closedUserCompetitions;
                RenameHeaders(dgvClosedUserCompetitions);
                FitColumnHeaders(dgvClosedUserCompetitions);
            }          
        }

        private void ShowOpenCompetitions(List<object> openedUserCompetitions)
        {
            if (openedUserCompetitions.Count > 0)
            {
                dgvOpenedUserCompetitions.DataSource = openedUserCompetitions;
                RenameHeaders(dgvOpenedUserCompetitions);
                FitColumnHeaders(dgvOpenedUserCompetitions);
            }
        }

        private void FitColumnHeaders(DataGridView dgv)
        {
            dgv.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["creation_date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["due_date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["needed_documentation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["opened"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void RenameHeaders(DataGridView dgv)
        {
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["name"].HeaderText = "Naziv";
            dgv.Columns["description"].HeaderText = "Opis";
            dgv.Columns["creation_date"].HeaderText = "Datum otvaranja";
            dgv.Columns["due_date"].HeaderText = "Datum zatvaranja";
            dgv.Columns["needed_documentation"].HeaderText = "Potrebna dokumentacija";
            dgv.Columns["opened"].HeaderText = "Otvoren";
        }

        private void DisableEdit()
        {
            tbOib.Enabled = false;
            tbName.Enabled = false;
            tbLastName.Enabled = false;
            tbAdress.Enabled = false;
            tbPassword.Enabled = false;
            tbPhone.Enabled = false;
            tbEmail.Enabled = false;
            tbUsername.Enabled = false;
        }

        private void ShowUserData()
        {
            tbOib.Text = loggedInUser.oib;
            tbName.Text = loggedInUser.first_name;
            tbLastName.Text = loggedInUser.last_name;
            tbAdress.Text= loggedInUser.adress;
            tbPassword.Text = loggedInUser.password;
            tbPhone.Text = loggedInUser.phone;
            tbEmail.Text = loggedInUser.email;
            tbUsername.Text = loggedInUser.username;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
            btnSaveChanges.Enabled = true;
        }

        private void EnableEdit()
        {
            tbName.Enabled = true;
            tbLastName.Enabled = true;
            tbAdress.Enabled = true;
            tbPassword.Enabled = true;
            tbPhone.Enabled = true;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if(passwordHidden)
            {
                tbPassword.PasswordChar = '\0';
                passwordHidden = false;
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastName = tbLastName.Text;
            string adress = tbAdress.Text;
            string phone = tbPhone.Text;
            string password = tbPassword.Text;

            try
            {
                CheckEnteredData(name, lastName, adress, phone, password);

                User editedUser = new User
                {
                    oib = loggedInUser.oib,
                    first_name = name,
                    last_name = lastName,
                    adress = adress,
                    phone = phone,
                    email = loggedInUser.email,
                    username = loggedInUser.username,
                    password = password,
                    roles_id = loggedInUser.roles_id,
                };

                bool userAccountEdited = userService.SaveUserData(editedUser);

                if (userAccountEdited)
                {
                    RefreshUserData();
                }

            }
            catch (DataValidationException ex)
            {
                MessageBox.Show(ex.message);
            } 
        }

        private void RefreshUserData()
        {
            loggedInUser = userService.GetUser(loggedInUser.username);
            ShowUserData();
            DisableEdit();
        }

        private void CheckEnteredData(string name, string lastName, string adress, string phone, string password)
        {
            string message = "";
            if (name == "") message += "Unesite ime.\n";
            if (lastName == "") message += "Unesite prezime.\n";
            if (adress == "") message += "Unesite adresu.\n";
            if (phone == "" || !IsNumeric(phone)) message += "Unesite ispravan broj telefona.\n";
            if (password == "") message += "Unesite lozinku.\n";

            if (message != "") throw new DataValidationException(message);
        }

        private bool IsNumeric(string str)
        {
            return str.All(char.IsDigit);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int selectedIndex = tcUserCompetitions.SelectedIndex;
            if (selectedIndex == 0)
            {
                exportCompetitions(dgvOpenedUserCompetitions, "Otvoreni natjecaji");
            }
            else if (selectedIndex == 1)
            {
                exportCompetitions(dgvClosedUserCompetitions, "Zatvoreni natjecaji");
            }
            else
            {
                exportCompetitions(dgvWonUserCompetitions, "Osvojeni natjecaji");
            }

        }

        private void exportCompetitions(DataGridView dgCompetitions, string name)
        {
            if (dgCompetitions.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = ""+name+" - "+loggedInUser.first_name+" "+loggedInUser.last_name+".pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Pristup disku onemogućen: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgCompetitions.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;
                            foreach (DataGridViewColumn col in dgCompetitions.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgCompetitions.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.Value != null)
                                        pTable.AddCell(dcell.Value.ToString());

                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                Paragraph date = new Paragraph();
                                date.Alignment = Element.ALIGN_RIGHT;
                                date.Font = FontFactory.GetFont("Arial", 14);
                                var dateNow = DateTime.Now.ToString("dd.MM.yyyy");
                                date.Add("Winatjecaj - "+dateNow);
                                document.Add(date);

                                Paragraph title = new Paragraph();
                                title.Alignment = Element.ALIGN_CENTER;
                                title.Font = FontFactory.GetFont("Arial", 22);
                                title.Add("\n" + name + "\n\n" + loggedInUser.first_name + " " + loggedInUser.last_name+"\n\n\n");
                                document.Add(title);

                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Izvještaj uspješno kreiran.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Greška kod ispisa: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tablica nema podataka za ispis.");
            }
        }
    }
}
