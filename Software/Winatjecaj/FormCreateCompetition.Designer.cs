namespace Winatjecaj
{
    partial class FormCreateCompetition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateCompetition));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.dgvDocumentation = new System.Windows.Forms.DataGridView();
            this.dgvCriteria = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDeleteDocument = new System.Windows.Forms.Button();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.btnDeleteCriteria = new System.Windows.Forms.Button();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.hpCreateCompetition = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriteria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Definiranje potrebne dokumentacije:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(793, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Definiranje kriterija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum dospijeća:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(61, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(309, 20);
            this.txtName.TabIndex = 5;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Location = new System.Drawing.Point(61, 165);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(309, 110);
            this.rtxtDescription.TabIndex = 7;
            this.rtxtDescription.Text = "";
            // 
            // dgvDocumentation
            // 
            this.dgvDocumentation.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentation.Location = new System.Drawing.Point(431, 119);
            this.dgvDocumentation.Name = "dgvDocumentation";
            this.dgvDocumentation.RowHeadersWidth = 51;
            this.dgvDocumentation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentation.Size = new System.Drawing.Size(309, 169);
            this.dgvDocumentation.TabIndex = 8;
            // 
            // dgvCriteria
            // 
            this.dgvCriteria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCriteria.BackgroundColor = System.Drawing.Color.White;
            this.dgvCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCriteria.Location = new System.Drawing.Point(797, 119);
            this.dgvCriteria.Name = "dgvCriteria";
            this.dgvCriteria.RowHeadersWidth = 51;
            this.dgvCriteria.Size = new System.Drawing.Size(309, 169);
            this.dgvCriteria.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(769, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 42);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(944, 359);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(162, 42);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Kreiraj";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDeleteDocument
            // 
            this.btnDeleteDocument.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDocument.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDocument.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDocument.Location = new System.Drawing.Point(431, 294);
            this.btnDeleteDocument.Name = "btnDeleteDocument";
            this.btnDeleteDocument.Size = new System.Drawing.Size(144, 34);
            this.btnDeleteDocument.TabIndex = 13;
            this.btnDeleteDocument.Text = "Izbriši dokument";
            this.btnDeleteDocument.UseVisualStyleBackColor = false;
            this.btnDeleteDocument.Click += new System.EventHandler(this.btnDeleteDocument_Click);
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDocument.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDocument.ForeColor = System.Drawing.Color.White;
            this.btnAddDocument.Location = new System.Drawing.Point(596, 294);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(144, 34);
            this.btnAddDocument.TabIndex = 14;
            this.btnAddDocument.Text = "Dodaj dokument";
            this.btnAddDocument.UseVisualStyleBackColor = false;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnDeleteCriteria
            // 
            this.btnDeleteCriteria.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCriteria.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCriteria.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCriteria.Location = new System.Drawing.Point(797, 294);
            this.btnDeleteCriteria.Name = "btnDeleteCriteria";
            this.btnDeleteCriteria.Size = new System.Drawing.Size(144, 34);
            this.btnDeleteCriteria.TabIndex = 15;
            this.btnDeleteCriteria.Text = "Izbriši kriterij";
            this.btnDeleteCriteria.UseVisualStyleBackColor = false;
            this.btnDeleteCriteria.Click += new System.EventHandler(this.btnDeleteCriteria_Click);
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCriteria.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCriteria.ForeColor = System.Drawing.Color.White;
            this.btnAddCriteria.Location = new System.Drawing.Point(962, 294);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(144, 34);
            this.btnAddCriteria.TabIndex = 16;
            this.btnAddCriteria.Text = "Dodaj kriterij";
            this.btnAddCriteria.UseVisualStyleBackColor = false;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(61, 308);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(309, 20);
            this.dtpDueDate.TabIndex = 17;
            // 
            // hpCreateCompetition
            // 
            this.hpCreateCompetition.HelpNamespace = "C:\\Users\\Leon\\Documents\\GitHub\\rpp22-mfric20-lraknic20-nrisek20\\Software\\Winatjec" +
    "aj\\WinatjecajHelp.chm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-7, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 81);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(386, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 46);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kreiranje natječaja";
            // 
            // FormCreateCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnAddCriteria);
            this.Controls.Add(this.btnDeleteCriteria);
            this.Controls.Add(this.btnAddDocument);
            this.Controls.Add(this.btnDeleteDocument);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvCriteria);
            this.Controls.Add(this.dgvDocumentation);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.hpCreateCompetition.SetHelpKeyword(this, "Kreiranje natjecaja");
            this.hpCreateCompetition.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateCompetition";
            this.hpCreateCompetition.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje natječaja";
            this.Load += new System.EventHandler(this.FormCreateCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriteria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.DataGridView dgvDocumentation;
        private System.Windows.Forms.DataGridView dgvCriteria;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDeleteDocument;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.Button btnDeleteCriteria;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.HelpProvider hpCreateCompetition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
    }
}