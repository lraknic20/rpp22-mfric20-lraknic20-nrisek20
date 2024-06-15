namespace Winatjecaj
{
    partial class FormEvaluateApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvaluateApplication));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameAndSurname = new System.Windows.Forms.Label();
            this.dgvCriteria = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalGrade = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.hpEvaluateApplication = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriteria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ocjenjivanje korisnika:";
            // 
            // lblNameAndSurname
            // 
            this.lblNameAndSurname.AutoSize = true;
            this.lblNameAndSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAndSurname.Location = new System.Drawing.Point(41, 148);
            this.lblNameAndSurname.Name = "lblNameAndSurname";
            this.lblNameAndSurname.Size = new System.Drawing.Size(123, 20);
            this.lblNameAndSurname.TabIndex = 5;
            this.lblNameAndSurname.Text = "Ime Prezime";
            // 
            // dgvCriteria
            // 
            this.dgvCriteria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCriteria.BackgroundColor = System.Drawing.Color.White;
            this.dgvCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCriteria.Location = new System.Drawing.Point(45, 190);
            this.dgvCriteria.Name = "dgvCriteria";
            this.dgvCriteria.RowHeadersWidth = 51;
            this.dgvCriteria.Size = new System.Drawing.Size(537, 219);
            this.dgvCriteria.TabIndex = 10;
            this.dgvCriteria.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCriteria_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ukupna ocjena:";
            // 
            // lblTotalGrade
            // 
            this.lblTotalGrade.AutoSize = true;
            this.lblTotalGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrade.Location = new System.Drawing.Point(566, 428);
            this.lblTotalGrade.Name = "lblTotalGrade";
            this.lblTotalGrade.Size = new System.Drawing.Size(18, 20);
            this.lblTotalGrade.TabIndex = 13;
            this.lblTotalGrade.Text = "0";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(131, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 34);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(332, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // hpEvaluateApplication
            // 
            this.hpEvaluateApplication.HelpNamespace = "C:\\Users\\Leon\\Documents\\GitHub\\rpp22-mfric20-lraknic20-nrisek20\\Software\\Winatjec" +
    "aj\\WinatjecajHelp.chm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-6, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 95);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ocjenjivanje";
            // 
            // FormEvaluateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTotalGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCriteria);
            this.Controls.Add(this.lblNameAndSurname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.hpEvaluateApplication.SetHelpKeyword(this, "Ocjenjivanje");
            this.hpEvaluateApplication.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEvaluateApplication";
            this.hpEvaluateApplication.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocjenjivanje korisnika";
            this.Load += new System.EventHandler(this.FormEvaluateApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriteria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameAndSurname;
        private System.Windows.Forms.DataGridView dgvCriteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalGrade;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.HelpProvider hpEvaluateApplication;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}