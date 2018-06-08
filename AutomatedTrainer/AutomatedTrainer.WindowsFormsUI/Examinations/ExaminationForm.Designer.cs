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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.IndicatorGraph1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Synchronizer = new System.Windows.Forms.Timer(this.components);
            this.IndicatorGraph4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IndicatorGraph2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IndicatorGraph5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IndicatorGraph3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PlayButton = new System.Windows.Forms.Button();
            this.HumansBody = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumansBody)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 157);
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
            this.ExaminationDate.Location = new System.Drawing.Point(220, 89);
            this.ExaminationDate.Name = "ExaminationDate";
            this.ExaminationDate.ReadOnly = true;
            this.ExaminationDate.Size = new System.Drawing.Size(147, 22);
            this.ExaminationDate.TabIndex = 6;
            // 
            // ExaminationType
            // 
            this.ExaminationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationType.Location = new System.Drawing.Point(220, 113);
            this.ExaminationType.Multiline = true;
            this.ExaminationType.Name = "ExaminationType";
            this.ExaminationType.ReadOnly = true;
            this.ExaminationType.Size = new System.Drawing.Size(226, 39);
            this.ExaminationType.TabIndex = 5;
            // 
            // ExaminationTypeLabel
            // 
            this.ExaminationTypeLabel.AutoSize = true;
            this.ExaminationTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationTypeLabel.Location = new System.Drawing.Point(16, 121);
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
            // IndicatorGraph1
            // 
            chartArea6.Name = "ChartArea1";
            this.IndicatorGraph1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.IndicatorGraph1.Legends.Add(legend6);
            this.IndicatorGraph1.Location = new System.Drawing.Point(12, 195);
            this.IndicatorGraph1.Name = "IndicatorGraph1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.IndicatorGraph1.Series.Add(series6);
            this.IndicatorGraph1.Size = new System.Drawing.Size(451, 159);
            this.IndicatorGraph1.TabIndex = 1;
            this.IndicatorGraph1.Text = "Test";
            this.IndicatorGraph1.Click += new System.EventHandler(this.TestGraph_Click);
            // 
            // Synchronizer
            // 
            this.Synchronizer.Tick += new System.EventHandler(this.Synchronizer_Tick);
            // 
            // IndicatorGraph4
            // 
            chartArea7.Name = "ChartArea1";
            this.IndicatorGraph4.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.IndicatorGraph4.Legends.Add(legend7);
            this.IndicatorGraph4.Location = new System.Drawing.Point(493, 195);
            this.IndicatorGraph4.Name = "IndicatorGraph4";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.IndicatorGraph4.Series.Add(series7);
            this.IndicatorGraph4.Size = new System.Drawing.Size(451, 159);
            this.IndicatorGraph4.TabIndex = 2;
            this.IndicatorGraph4.Text = "chart1";
            // 
            // IndicatorGraph2
            // 
            chartArea8.Name = "ChartArea1";
            this.IndicatorGraph2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.IndicatorGraph2.Legends.Add(legend8);
            this.IndicatorGraph2.Location = new System.Drawing.Point(12, 360);
            this.IndicatorGraph2.Name = "IndicatorGraph2";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.IndicatorGraph2.Series.Add(series8);
            this.IndicatorGraph2.Size = new System.Drawing.Size(451, 159);
            this.IndicatorGraph2.TabIndex = 3;
            this.IndicatorGraph2.Text = "chart2";
            // 
            // IndicatorGraph5
            // 
            chartArea9.Name = "ChartArea1";
            this.IndicatorGraph5.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.IndicatorGraph5.Legends.Add(legend9);
            this.IndicatorGraph5.Location = new System.Drawing.Point(493, 360);
            this.IndicatorGraph5.Name = "IndicatorGraph5";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.IndicatorGraph5.Series.Add(series9);
            this.IndicatorGraph5.Size = new System.Drawing.Size(451, 159);
            this.IndicatorGraph5.TabIndex = 4;
            this.IndicatorGraph5.Text = "chart3";
            // 
            // IndicatorGraph3
            // 
            chartArea10.Name = "ChartArea1";
            this.IndicatorGraph3.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.IndicatorGraph3.Legends.Add(legend10);
            this.IndicatorGraph3.Location = new System.Drawing.Point(493, 22);
            this.IndicatorGraph3.Name = "IndicatorGraph3";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.IndicatorGraph3.Series.Add(series10);
            this.IndicatorGraph3.Size = new System.Drawing.Size(451, 159);
            this.IndicatorGraph3.TabIndex = 5;
            this.IndicatorGraph3.Text = "chart4";
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(1022, 491);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(90, 43);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.Text = "Старт";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // HumansBody
            // 
            this.HumansBody.Location = new System.Drawing.Point(956, 22);
            this.HumansBody.Name = "HumansBody";
            this.HumansBody.Size = new System.Drawing.Size(186, 463);
            this.HumansBody.TabIndex = 8;
            this.HumansBody.TabStop = false;
            // 
            // ExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 546);
            this.Controls.Add(this.HumansBody);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.IndicatorGraph3);
            this.Controls.Add(this.IndicatorGraph5);
            this.Controls.Add(this.IndicatorGraph2);
            this.Controls.Add(this.IndicatorGraph4);
            this.Controls.Add(this.IndicatorGraph1);
            this.Controls.Add(this.panel1);
            this.Name = "ExaminationForm";
            this.Text = "ExaminationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorGraph3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumansBody)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart IndicatorGraph1;
        private System.Windows.Forms.Timer Synchronizer;
        private System.Windows.Forms.DataVisualization.Charting.Chart IndicatorGraph4;
        private System.Windows.Forms.DataVisualization.Charting.Chart IndicatorGraph2;
        private System.Windows.Forms.DataVisualization.Charting.Chart IndicatorGraph5;
        private System.Windows.Forms.DataVisualization.Charting.Chart IndicatorGraph3;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox HumansBody;
    }
}