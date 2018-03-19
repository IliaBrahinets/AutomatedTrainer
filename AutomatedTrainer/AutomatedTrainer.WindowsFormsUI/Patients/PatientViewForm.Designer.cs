namespace AutomatedTrainer.WindowsFormsUI
{
    partial class PatientViewForm
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
            this.PatientsTable = new System.Windows.Forms.DataGridView();
            this.Navigation = new System.Windows.Forms.MenuStrip();
            this.CreatePatientFormInvoke = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsTable)).BeginInit();
            this.Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientsTable
            // 
            this.PatientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsTable.Location = new System.Drawing.Point(31, 67);
            this.PatientsTable.Name = "PatientsTable";
            this.PatientsTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientsTable.Size = new System.Drawing.Size(768, 351);
            this.PatientsTable.TabIndex = 0;
            // 
            // Navigation
            // 
            this.Navigation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Navigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatePatientFormInvoke});
            this.Navigation.Location = new System.Drawing.Point(0, 0);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(853, 24);
            this.Navigation.TabIndex = 1;
            this.Navigation.Text = "Navigation";
            // 
            // CreatePatientFormInvoke
            // 
            this.CreatePatientFormInvoke.Name = "CreatePatientFormInvoke";
            this.CreatePatientFormInvoke.Size = new System.Drawing.Size(116, 20);
            this.CreatePatientFormInvoke.Text = "Создать пациента";
            this.CreatePatientFormInvoke.Click += new System.EventHandler(this.CreatePatientFormInvoke_Click);
            // 
            // PatientViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 528);
            this.Controls.Add(this.PatientsTable);
            this.Controls.Add(this.Navigation);
            this.MainMenuStrip = this.Navigation;
            this.Name = "PatientViewForm";
            this.Text = "PatientViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.PatientsTable)).EndInit();
            this.Navigation.ResumeLayout(false);
            this.Navigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsTable;
        private System.Windows.Forms.MenuStrip Navigation;
        private System.Windows.Forms.ToolStripMenuItem CreatePatientFormInvoke;
    }
}