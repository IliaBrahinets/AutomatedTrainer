namespace AutomatedTrainer.WindowsFormsUI
{
    partial class ExaminationViewForm
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
            this.ExaminationTable = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicalIndicators = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ExaminationTable
            // 
            this.ExaminationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExaminationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.PhysicalIndicators,
            this.Type});
            this.ExaminationTable.Location = new System.Drawing.Point(31, 40);
            this.ExaminationTable.Name = "ExaminationTable";
            this.ExaminationTable.ReadOnly = true;
            this.ExaminationTable.Size = new System.Drawing.Size(577, 271);
            this.ExaminationTable.TabIndex = 0;
            this.ExaminationTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // PhysicalIndicators
            // 
            this.PhysicalIndicators.DropDownWidth = 5;
            this.PhysicalIndicators.HeaderText = "Измеряемые показатели";
            this.PhysicalIndicators.Name = "PhysicalIndicators";
            this.PhysicalIndicators.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 200;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(31, 351);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 135);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ExaminationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 510);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ExaminationTable);
            this.Name = "ExaminationViewForm";
            this.Text = "ExaminationViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.ExaminationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExaminationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhysicalIndicators;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.ListView listView1;
    }
}