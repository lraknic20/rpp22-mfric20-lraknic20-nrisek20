namespace Winatjecaj
{
    partial class FormDocumentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocumentation));
            this.dgvDocumentation = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreuzmi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocumentation
            // 
            this.dgvDocumentation.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentation.Location = new System.Drawing.Point(12, 103);
            this.dgvDocumentation.Name = "dgvDocumentation";
            this.dgvDocumentation.ReadOnly = true;
            this.dgvDocumentation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentation.Size = new System.Drawing.Size(503, 210);
            this.dgvDocumentation.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(87, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 34);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPreuzmi
            // 
            this.btnPreuzmi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPreuzmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreuzmi.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreuzmi.ForeColor = System.Drawing.Color.White;
            this.btnPreuzmi.Location = new System.Drawing.Point(283, 333);
            this.btnPreuzmi.Name = "btnPreuzmi";
            this.btnPreuzmi.Size = new System.Drawing.Size(150, 34);
            this.btnPreuzmi.TabIndex = 16;
            this.btnPreuzmi.Text = "Preuzmi";
            this.btnPreuzmi.UseVisualStyleBackColor = false;
            this.btnPreuzmi.Click += new System.EventHandler(this.btnPreuzmi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-4, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 86);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dokumentacija";
            // 
            // FormDocumentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPreuzmi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvDocumentation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDocumentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokumentacija";
            this.Load += new System.EventHandler(this.FormDocumentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocumentation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreuzmi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}