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
            this.Dates = new System.Windows.Forms.ListBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PhysicalIndicators = new System.Windows.Forms.ListBox();
            this.Navigation = new System.Windows.Forms.MenuStrip();
            this.InvokeCreateExaminationForm = new System.Windows.Forms.ToolStripMenuItem();
            this.Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dates
            // 
            this.Dates.FormattingEnabled = true;
            this.Dates.Location = new System.Drawing.Point(12, 43);
            this.Dates.Name = "Dates";
            this.Dates.Size = new System.Drawing.Size(147, 329);
            this.Dates.TabIndex = 0;
            this.Dates.SelectedIndexChanged += new System.EventHandler(this.Dates_SelectedIndexChanged);
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(189, 69);
            this.Type.Multiline = true;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Size = new System.Drawing.Size(347, 61);
            this.Type.TabIndex = 1;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(186, 43);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(26, 13);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Тип";
            // 
            // PhysicalIndicators
            // 
            this.PhysicalIndicators.FormattingEnabled = true;
            this.PhysicalIndicators.Location = new System.Drawing.Point(189, 148);
            this.PhysicalIndicators.Name = "PhysicalIndicators";
            this.PhysicalIndicators.Size = new System.Drawing.Size(347, 225);
            this.PhysicalIndicators.TabIndex = 3;
            // 
            // Navigation
            // 
            this.Navigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InvokeCreateExaminationForm});
            this.Navigation.Location = new System.Drawing.Point(0, 0);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(554, 24);
            this.Navigation.TabIndex = 4;
            this.Navigation.Text = "Меню";
            // 
            // InvokeCreateExaminationForm
            // 
            this.InvokeCreateExaminationForm.Name = "InvokeCreateExaminationForm";
            this.InvokeCreateExaminationForm.Size = new System.Drawing.Size(135, 20);
            this.InvokeCreateExaminationForm.Text = "Новое обследование";
            this.InvokeCreateExaminationForm.Click += new System.EventHandler(this.InvokeCreateExaminationForm_Click);
            // 
            // ExaminationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 446);
            this.Controls.Add(this.PhysicalIndicators);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Dates);
            this.Controls.Add(this.Navigation);
            this.Name = "ExaminationViewForm";
            this.Text = "ExaminationViewForm";
            this.Navigation.ResumeLayout(false);
            this.Navigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Dates;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ListBox PhysicalIndicators;
        private System.Windows.Forms.MenuStrip Navigation;
        private System.Windows.Forms.ToolStripMenuItem InvokeCreateExaminationForm;
    }
}