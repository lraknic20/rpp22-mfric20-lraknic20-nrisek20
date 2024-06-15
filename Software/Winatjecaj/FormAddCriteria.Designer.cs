namespace Winatjecaj
{
    partial class FormAddCriteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCriteria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.numGrade = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.hpAddCriteria = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ocjena:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(105, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(105, 176);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(318, 60);
            this.txtDescription.TabIndex = 7;
            // 
            // numGrade
            // 
            this.numGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGrade.Location = new System.Drawing.Point(105, 262);
            this.numGrade.Name = "numGrade";
            this.numGrade.Size = new System.Drawing.Size(90, 22);
            this.numGrade.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(102, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCriteria.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCriteria.ForeColor = System.Drawing.Color.White;
            this.btnAddCriteria.Location = new System.Drawing.Point(276, 311);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(147, 37);
            this.btnAddCriteria.TabIndex = 13;
            this.btnAddCriteria.Text = "Dodaj";
            this.btnAddCriteria.UseVisualStyleBackColor = false;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // hpAddCriteria
            // 
            this.hpAddCriteria.HelpNamespace = "C:\\Users\\Leon\\Documents\\GitHub\\rpp22-mfric20-lraknic20-nrisek20\\Software\\Winatjec" +
    "aj\\WinatjecajHelp.chm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(-5, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 84);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(116, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dodavanje kriterija";
            // 
            // FormAddCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddCriteria);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numGrade);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.hpAddCriteria.SetHelpKeyword(this, "Dodavanje kriterija");
            this.hpAddCriteria.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddCriteria";
            this.hpAddCriteria.SetShowHelp(this, true);
            this.Text = "Dodaj Kriterij";
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numGrade;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.HelpProvider hpAddCriteria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}