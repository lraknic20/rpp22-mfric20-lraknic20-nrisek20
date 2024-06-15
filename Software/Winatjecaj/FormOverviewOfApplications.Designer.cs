namespace Winatjecaj
{
    partial class FormOverviewOfApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOverviewOfApplications));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnDeclareWinner = new System.Windows.Forms.Button();
            this.btnCancelWinner = new System.Windows.Forms.Button();
            this.lblNameOfCompetition = new System.Windows.Forms.Label();
            this.hpOverviewOfApplications = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prijave - ";
            // 
            // dgvApplications
            // 
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Location = new System.Drawing.Point(28, 168);
            this.dgvApplications.Margin = new System.Windows.Forms.Padding(2);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersWidth = 51;
            this.dgvApplications.RowTemplate.Height = 24;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1020, 370);
            this.dgvApplications.TabIndex = 5;
            this.dgvApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplications_CellContentClick);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluate.ForeColor = System.Drawing.Color.White;
            this.btnEvaluate.Location = new System.Drawing.Point(451, 559);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(195, 34);
            this.btnEvaluate.TabIndex = 15;
            this.btnEvaluate.Text = "Ocijeni";
            this.btnEvaluate.UseVisualStyleBackColor = false;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnDeclareWinner
            // 
            this.btnDeclareWinner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeclareWinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeclareWinner.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclareWinner.ForeColor = System.Drawing.Color.White;
            this.btnDeclareWinner.Location = new System.Drawing.Point(853, 559);
            this.btnDeclareWinner.Name = "btnDeclareWinner";
            this.btnDeclareWinner.Size = new System.Drawing.Size(195, 34);
            this.btnDeclareWinner.TabIndex = 16;
            this.btnDeclareWinner.Text = "Proglasi dobitnika";
            this.btnDeclareWinner.UseVisualStyleBackColor = false;
            this.btnDeclareWinner.Click += new System.EventHandler(this.btnDeclareWinner_Click);
            // 
            // btnCancelWinner
            // 
            this.btnCancelWinner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelWinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelWinner.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelWinner.ForeColor = System.Drawing.Color.White;
            this.btnCancelWinner.Location = new System.Drawing.Point(652, 559);
            this.btnCancelWinner.Name = "btnCancelWinner";
            this.btnCancelWinner.Size = new System.Drawing.Size(195, 34);
            this.btnCancelWinner.TabIndex = 17;
            this.btnCancelWinner.Text = "Poništi dobitnika";
            this.btnCancelWinner.UseVisualStyleBackColor = false;
            this.btnCancelWinner.Click += new System.EventHandler(this.btnCancelWinner_Click);
            // 
            // lblNameOfCompetition
            // 
            this.lblNameOfCompetition.AutoSize = true;
            this.lblNameOfCompetition.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfCompetition.Location = new System.Drawing.Point(147, 124);
            this.lblNameOfCompetition.Name = "lblNameOfCompetition";
            this.lblNameOfCompetition.Size = new System.Drawing.Size(168, 29);
            this.lblNameOfCompetition.TabIndex = 18;
            this.lblNameOfCompetition.Text = "Competition";
            // 
            // hpOverviewOfApplications
            // 
            this.hpOverviewOfApplications.HelpNamespace = "C:\\Users\\Leon\\Documents\\GitHub\\rpp22-mfric20-lraknic20-nrisek20\\Software\\Winatjec" +
    "aj\\WinatjecajHelp.chm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-4, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1111, 93);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(383, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pregled prijava";
            // 
            // FormOverviewOfApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNameOfCompetition);
            this.Controls.Add(this.btnCancelWinner);
            this.Controls.Add(this.btnDeclareWinner);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.hpOverviewOfApplications.SetHelpKeyword(this, "Pregled prijavljenih");
            this.hpOverviewOfApplications.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOverviewOfApplications";
            this.hpOverviewOfApplications.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled prijava";
            this.Load += new System.EventHandler(this.FormOverviewOfApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnDeclareWinner;
        private System.Windows.Forms.Button btnCancelWinner;
        private System.Windows.Forms.Label lblNameOfCompetition;
        private System.Windows.Forms.HelpProvider hpOverviewOfApplications;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}