namespace AutomatedTrainer.WindowsFormsUI
{
    partial class ExaminationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PatientFullName = new System.Windows.Forms.TextBox();
            this.PatientAge = new System.Windows.Forms.TextBox();
            this.PatientSex = new System.Windows.Forms.TextBox();
            this.ExaminationDate = new System.Windows.Forms.TextBox();
            this.ExaminationType = new System.Windows.Forms.TextBox();
            this.ExaminationTypeLabel = new System.Windows.Forms.Label();
            this.ExaminationDateLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.PatientAgeLabel = new System.Windows.Forms.Label();
            this.PatientFullNameLabel = new System.Windows.Forms.Label();
            this.TestGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PatientFullName);
            this.panel1.Controls.Add(this.PatientAge);
            this.panel1.Controls.Add(this.PatientSex);
            this.panel1.Controls.Add(this.ExaminationDate);
            this.panel1.Controls.Add(this.ExaminationType);
            this.panel1.Controls.Add(this.ExaminationTypeLabel);
            this.panel1.Controls.Add(this.ExaminationDateLabel);
            this.panel1.Controls.Add(this.SexLabel);
            this.panel1.Controls.Add(this.PatientAgeLabel);
            this.panel1.Controls.Add(this.PatientFullNameLabel);
            this.panel1.Location = new System.Drawing.Point(331, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 146);
            this.panel1.TabIndex = 0;
            // 
            // PatientFullName
            // 
            this.PatientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientFullName.Location = new System.Drawing.Point(164, 19);
            this.PatientFullName.Name = "PatientFullName";
            this.PatientFullName.ReadOnly = true;
            this.PatientFullName.Size = new System.Drawing.Size(230, 22);
            this.PatientFullName.TabIndex = 9;
            // 
            // PatientAge
            // 
            this.PatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientAge.Location = new System.Drawing.Point(164, 41);
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.ReadOnly = true;
            this.PatientAge.Size = new System.Drawing.Size(230, 22);
            this.PatientAge.TabIndex = 8;
            // 
            // PatientSex
            // 
            this.PatientSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientSex.Location = new System.Drawing.Point(164, 63);
            this.PatientSex.Name = "PatientSex";
            this.PatientSex.ReadOnly = true;
            this.PatientSex.Size = new System.Drawing.Size(230, 22);
            this.PatientSex.TabIndex = 7;
            // 
            // ExaminationDate
            // 
            this.ExaminationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationDate.Location = new System.Drawing.Point(189, 89);
            this.ExaminationDate.Name = "ExaminationDate";
            this.ExaminationDate.ReadOnly = true;
            this.ExaminationDate.Size = new System.Drawing.Size(147, 22);
            this.ExaminationDate.TabIndex = 6;
            // 
            // ExaminationType
            // 
            this.ExaminationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationType.Location = new System.Drawing.Point(220, 113);
            this.ExaminationType.Name = "ExaminationType";
            this.ExaminationType.ReadOnly = true;
            this.ExaminationType.Size = new System.Drawing.Size(372, 22);
            this.ExaminationType.TabIndex = 5;
            // 
            // ExaminationTypeLabel
            // 
            this.ExaminationTypeLabel.AutoSize = true;
            this.ExaminationTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationTypeLabel.Location = new System.Drawing.Point(16, 114);
            this.ExaminationTypeLabel.Name = "ExaminationTypeLabel";
            this.ExaminationTypeLabel.Size = new System.Drawing.Size(203, 20);
            this.ExaminationTypeLabel.TabIndex = 4;
            this.ExaminationTypeLabel.Text = "Тип физической нагрузки";
            // 
            // ExaminationDateLabel
            // 
            this.ExaminationDateLabel.AutoSize = true;
            this.ExaminationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationDateLabel.Location = new System.Drawing.Point(16, 92);
            this.ExaminationDateLabel.Name = "ExaminationDateLabel";
            this.ExaminationDateLabel.Size = new System.Drawing.Size(162, 20);
            this.ExaminationDateLabel.TabIndex = 3;
            this.ExaminationDateLabel.Text = "Дата обследования";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexLabel.Location = new System.Drawing.Point(16, 63);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(40, 20);
            this.SexLabel.TabIndex = 2;
            this.SexLabel.Text = "Пол";
            // 
            // PatientAgeLabel
            // 
            this.PatientAgeLabel.AutoSize = true;
            this.PatientAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientAgeLabel.Location = new System.Drawing.Point(16, 41);
            this.PatientAgeLabel.Name = "PatientAgeLabel";
            this.PatientAgeLabel.Size = new System.Drawing.Size(72, 20);
            this.PatientAgeLabel.TabIndex = 1;
            this.PatientAgeLabel.Text = "Возраст";
            // 
            // PatientFullNameLabel
            // 
            this.PatientFullNameLabel.AutoSize = true;
            this.PatientFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientFullNameLabel.Location = new System.Drawing.Point(15, 19);
            this.PatientFullNameLabel.Name = "PatientFullNameLabel";
            this.PatientFullNameLabel.Size = new System.Drawing.Size(75, 20);
            this.PatientFullNameLabel.TabIndex = 0;
            this.PatientFullNameLabel.Text = "Пациент";
            // 
            // TestGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.TestGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TestGraph.Legends.Add(legend1);
            this.TestGraph.Location = new System.Drawing.Point(331, 164);
            this.TestGraph.Name = "TestGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.TestGraph.Series.Add(series1);
            this.TestGraph.Size = new System.Drawing.Size(636, 221);
            this.TestGraph.TabIndex = 1;
            this.TestGraph.Text = "Test";
            // 
            // ExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 606);
            this.Controls.Add(this.TestGraph);
            this.Controls.Add(this.panel1);
            this.Name = "ExaminationForm";
            this.Text = "ExaminationForm";
            this.Load += new System.EventHandler(this.Examinatio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExaminationTypeLabel;
        private System.Windows.Forms.Label ExaminationDateLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label PatientAgeLabel;
        private System.Windows.Forms.Label PatientFullNameLabel;
        private System.Windows.Forms.TextBox ExaminationType;
        private System.Windows.Forms.TextBox PatientFullName;
        private System.Windows.Forms.TextBox PatientAge;
        private System.Windows.Forms.TextBox PatientSex;
        private System.Windows.Forms.TextBox ExaminationDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart TestGraph;
    }
}