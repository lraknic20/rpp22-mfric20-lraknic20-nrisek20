namespace Winatjecaj
{
    partial class FormAccountActivation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountActivation));
            this.dgvDeactivatedAccounts = new System.Windows.Forms.DataGridView();
            this.btnActivate = new System.Windows.Forms.Button();
            this.hpAccountActivation = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeactivatedAccounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeactivatedAccounts
            // 
            this.dgvDeactivatedAccounts.AllowUserToAddRows = false;
            this.dgvDeactivatedAccounts.AllowUserToDeleteRows = false;
            this.dgvDeactivatedAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeactivatedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeactivatedAccounts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeactivatedAccounts.Location = new System.Drawing.Point(13, 74);
            this.dgvDeactivatedAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeactivatedAccounts.Name = "dgvDeactivatedAccounts";
            this.dgvDeactivatedAccounts.ReadOnly = true;
            this.dgvDeactivatedAccounts.RowHeadersWidth = 82;
            this.dgvDeactivatedAccounts.RowTemplate.Height = 33;
            this.dgvDeactivatedAccounts.Size = new System.Drawing.Size(784, 441);
            this.dgvDeactivatedAccounts.TabIndex = 0;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.Location = new System.Drawing.Point(614, 523);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(183, 35);
            this.btnActivate.TabIndex = 37;
            this.btnActivate.Text = "Aktiviraj";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // hpAccountActivation
            // 
            this.hpAccountActivation.HelpNamespace = "WinatjecajHelp.chm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(-4, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 76);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(196, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aktivacija korisničkih računa";
            // 
            // FormAccountActivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.dgvDeactivatedAccounts);
            this.hpAccountActivation.SetHelpKeyword(this, "Aktivacija racuna");
            this.hpAccountActivation.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAccountActivation";
            this.hpAccountActivation.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktivacija korisničkih računa";
            this.Load += new System.EventHandler(this.FormAccountActivation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeactivatedAccounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeactivatedAccounts;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.HelpProvider hpAccountActivation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}