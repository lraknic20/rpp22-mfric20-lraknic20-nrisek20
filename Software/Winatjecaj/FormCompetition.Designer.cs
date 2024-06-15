namespace Winatjecaj
{
    partial class FormCompetition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompetition));
            this.dgvCompetitions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAccountActivation = new System.Windows.Forms.Button();
            this.hpCompetitions = new System.Windows.Forms.HelpProvider();
            this.btnCreateCompetition = new System.Windows.Forms.Button();
            this.btnOverviewOfApplications = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitions)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompetitions
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCompetitions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompetitions.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompetitions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompetitions.Location = new System.Drawing.Point(24, 164);
            this.dgvCompetitions.Name = "dgvCompetitions";
            this.dgvCompetitions.ReadOnly = true;
            this.dgvCompetitions.RowHeadersWidth = 82;
            this.dgvCompetitions.Size = new System.Drawing.Size(960, 414);
            this.dgvCompetitions.TabIndex = 2;
            this.dgvCompetitions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCompetitions_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Natječaji";
            // 
            // btnPrijava
            // 
            this.btnPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.Location = new System.Drawing.Point(11, 221);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(168, 42);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.FlatAppearance.BorderSize = 0;
            this.btnDetalji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ForeColor = System.Drawing.Color.White;
            this.btnDetalji.Location = new System.Drawing.Point(11, 173);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(168, 42);
            this.btnDetalji.TabIndex = 6;
            this.btnDetalji.Text = "Prikaži detalje";
            this.btnDetalji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(24, 122);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(175, 26);
            this.tbFilter.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filtriranje po nazivu:";
            // 
            // cmbSort
            // 
            this.cmbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(825, 119);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(159, 28);
            this.cmbSort.TabIndex = 12;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(821, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sortiraj po:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(205, 117);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(137, 34);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAccountActivation
            // 
            this.btnAccountActivation.FlatAppearance.BorderSize = 0;
            this.btnAccountActivation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAccountActivation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountActivation.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountActivation.ForeColor = System.Drawing.Color.White;
            this.btnAccountActivation.Location = new System.Drawing.Point(10, 268);
            this.btnAccountActivation.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccountActivation.Name = "btnAccountActivation";
            this.btnAccountActivation.Size = new System.Drawing.Size(169, 41);
            this.btnAccountActivation.TabIndex = 16;
            this.btnAccountActivation.Text = "Aktivacija računa";
            this.btnAccountActivation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountActivation.UseVisualStyleBackColor = true;
            this.btnAccountActivation.Click += new System.EventHandler(this.btnAccountActivation_Click);
            // 
            // hpCompetitions
            // 
            this.hpCompetitions.HelpNamespace = "WinatjecajHelp.chm";
            // 
            // btnCreateCompetition
            // 
            this.btnCreateCompetition.FlatAppearance.BorderSize = 0;
            this.btnCreateCompetition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreateCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCompetition.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCompetition.ForeColor = System.Drawing.Color.White;
            this.btnCreateCompetition.Location = new System.Drawing.Point(10, 313);
            this.btnCreateCompetition.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCompetition.Name = "btnCreateCompetition";
            this.btnCreateCompetition.Size = new System.Drawing.Size(170, 41);
            this.btnCreateCompetition.TabIndex = 17;
            this.btnCreateCompetition.Text = "Kreiraj natječaj";
            this.btnCreateCompetition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCompetition.UseVisualStyleBackColor = true;
            this.btnCreateCompetition.Click += new System.EventHandler(this.btnCreateCompetition_Click);
            // 
            // btnOverviewOfApplications
            // 
            this.btnOverviewOfApplications.FlatAppearance.BorderSize = 0;
            this.btnOverviewOfApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOverviewOfApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverviewOfApplications.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverviewOfApplications.ForeColor = System.Drawing.Color.White;
            this.btnOverviewOfApplications.Location = new System.Drawing.Point(11, 358);
            this.btnOverviewOfApplications.Margin = new System.Windows.Forms.Padding(2);
            this.btnOverviewOfApplications.Name = "btnOverviewOfApplications";
            this.btnOverviewOfApplications.Size = new System.Drawing.Size(168, 49);
            this.btnOverviewOfApplications.TabIndex = 18;
            this.btnOverviewOfApplications.Text = "Pregled prijavljenih korisnika";
            this.btnOverviewOfApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverviewOfApplications.UseVisualStyleBackColor = true;
            this.btnOverviewOfApplications.Click += new System.EventHandler(this.btnOverviewOfApplications_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbProfil);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-4, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // pbProfil
            // 
            this.pbProfil.Image = global::Winatjecaj.Properties.Resources.Profil_ikona;
            this.pbProfil.Location = new System.Drawing.Point(942, 21);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(59, 55);
            this.pbProfil.TabIndex = 1;
            this.pbProfil.TabStop = false;
            this.pbProfil.Click += new System.EventHandler(this.pbProfil_Click);
            this.pbProfil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnAccountActivation);
            this.groupBox2.Controls.Add(this.btnPrijava);
            this.groupBox2.Controls.Add(this.btnOverviewOfApplications);
            this.groupBox2.Controls.Add(this.btnDetalji);
            this.groupBox2.Controls.Add(this.btnCreateCompetition);
            this.groupBox2.Location = new System.Drawing.Point(1003, -9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 605);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winatjecaj.Properties.Resources.Logo_W_3;
            this.pictureBox1.Location = new System.Drawing.Point(54, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 94);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = global::Winatjecaj.Properties.Resources.reset;
            this.pbRefresh.Location = new System.Drawing.Point(356, 120);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(30, 31);
            this.pbRefresh.TabIndex = 15;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            this.pbRefresh.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // FormCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.dgvCompetitions);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hpCompetitions.SetHelpKeyword(this, "Pregled natjecaja");
            this.hpCompetitions.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompetition";
            this.hpCompetitions.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled natječaja";
            this.Load += new System.EventHandler(this.FormCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbProfil;
        private System.Windows.Forms.DataGridView dgvCompetitions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Button btnAccountActivation;
        private System.Windows.Forms.HelpProvider hpCompetitions;
        private System.Windows.Forms.Button btnCreateCompetition;
        private System.Windows.Forms.Button btnOverviewOfApplications;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}