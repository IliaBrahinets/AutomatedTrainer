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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel1.Location = new System.Drawing.Point(18, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 240);
            this.panel1.TabIndex = 0;
            // 
            // PatientFullName
            // 
            this.PatientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientFullName.Location = new System.Drawing.Point(246, 29);
            this.PatientFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientFullName.Name = "PatientFullName";
            this.PatientFullName.ReadOnly = true;
            this.PatientFullName.Size = new System.Drawing.Size(343, 30);
            this.PatientFullName.TabIndex = 9;
            // 
            // PatientAge
            // 
            this.PatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientAge.Location = new System.Drawing.Point(246, 63);
            this.PatientAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.ReadOnly = true;
            this.PatientAge.Size = new System.Drawing.Size(343, 30);
            this.PatientAge.TabIndex = 8;
            // 
            // PatientSex
            // 
            this.PatientSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientSex.Location = new System.Drawing.Point(246, 97);
            this.PatientSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientSex.Name = "PatientSex";
            this.PatientSex.ReadOnly = true;
            this.PatientSex.Size = new System.Drawing.Size(343, 30);
            this.PatientSex.TabIndex = 7;
            // 
            // ExaminationDate
            // 
            this.ExaminationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationDate.Location = new System.Drawing.Point(330, 137);
            this.ExaminationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExaminationDate.Name = "ExaminationDate";
            this.ExaminationDate.ReadOnly = true;
            this.ExaminationDate.Size = new System.Drawing.Size(218, 30);
            this.ExaminationDate.TabIndex = 6;
            // 
            // ExaminationType
            // 
            this.ExaminationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationType.Location = new System.Drawing.Point(330, 174);
            this.ExaminationType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExaminationType.Multiline = true;
            this.ExaminationType.Name = "ExaminationType";
            this.ExaminationType.ReadOnly = true;
            this.ExaminationType.Size = new System.Drawing.Size(337, 58);
            this.ExaminationType.TabIndex = 5;
            // 
            // ExaminationTypeLabel
            // 
            this.ExaminationTypeLabel.AutoSize = true;
            this.ExaminationTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationTypeLabel.Location = new System.Drawing.Point(24, 186);
            this.ExaminationTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExaminationTypeLabel.Name = "ExaminationTypeLabel";
            this.ExaminationTypeLabel.Size = new System.Drawing.Size(317, 29);
            this.ExaminationTypeLabel.TabIndex = 4;
            this.ExaminationTypeLabel.Text = "Тип физической нагрузки";
            // 
            // ExaminationDateLabel
            // 
            this.ExaminationDateLabel.AutoSize = true;
            this.ExaminationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationDateLabel.Location = new System.Drawing.Point(24, 142);
            this.ExaminationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExaminationDateLabel.Name = "ExaminationDateLabel";
            this.ExaminationDateLabel.Size = new System.Drawing.Size(240, 29);
            this.ExaminationDateLabel.TabIndex = 3;
            this.ExaminationDateLabel.Text = "Дата обследования";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexLabel.Location = new System.Drawing.Point(24, 97);
            this.SexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(59, 29);
            this.SexLabel.TabIndex = 2;
            this.SexLabel.Text = "Пол";
            // 
            // PatientAgeLabel
            // 
            this.PatientAgeLabel.AutoSize = true;
            this.PatientAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientAgeLabel.Location = new System.Drawing.Point(24, 63);
            this.PatientAgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientAgeLabel.Name = "PatientAgeLabel";
            this.PatientAgeLabel.Size = new System.Drawing.Size(107, 29);
            this.PatientAgeLabel.TabIndex = 1;
            this.PatientAgeLabel.Text = "Возраст";
            // 
            // PatientFullNameLabel
            // 
            this.PatientFullNameLabel.AutoSize = true;
            this.PatientFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientFullNameLabel.Location = new System.Drawing.Point(22, 29);
            this.PatientFullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientFullNameLabel.Name = "PatientFullNameLabel";
            this.PatientFullNameLabel.Size = new System.Drawing.Size(114, 29);
            this.PatientFullNameLabel.TabIndex = 0;
            this.PatientFullNameLabel.Text = "Пациент";
            // 
            // IndicatorGraph1
            // 
            chartArea1.Name = "ChartArea1";
            this.IndicatorGraph1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.IndicatorGraph1.Legends.Add(legend1);
            this.IndicatorGraph1.Location = new System.Drawing.Point(18, 300);
            this.IndicatorGraph1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IndicatorGraph1.Name = "IndicatorGraph1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.IndicatorGraph1.Series.Add(series1);
            this.IndicatorGraph1.Size = new System.Drawing.Size(676, 245);
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
            chartArea2.Name = "ChartArea1";
            this.IndicatorGraph4.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.IndicatorGraph4.Legends.Add(legend2);
            this.IndicatorGraph4.Location = new System.Drawing.Point(740, 300);
            this.IndicatorGraph4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IndicatorGraph4.Name = "IndicatorGraph4";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.IndicatorGraph4.Series.Add(series2);
            this.IndicatorGraph4.Size = new System.Drawing.Size(676, 245);
            this.IndicatorGraph4.TabIndex = 2;
            this.IndicatorGraph4.Text = "chart1";
            // 
            // IndicatorGraph2
            // 
            chartArea3.Name = "ChartArea1";
            this.IndicatorGraph2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.IndicatorGraph2.Legends.Add(legend3);
            this.IndicatorGraph2.Location = new System.Drawing.Point(18, 554);
            this.IndicatorGraph2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IndicatorGraph2.Name = "IndicatorGraph2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.IndicatorGraph2.Series.Add(series3);
            this.IndicatorGraph2.Size = new System.Drawing.Size(676, 245);
            this.IndicatorGraph2.TabIndex = 3;
            this.IndicatorGraph2.Text = "chart2";
            // 
            // IndicatorGraph5
            // 
            chartArea4.Name = "ChartArea1";
            this.IndicatorGraph5.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.IndicatorGraph5.Legends.Add(legend4);
            this.IndicatorGraph5.Location = new System.Drawing.Point(740, 554);
            this.IndicatorGraph5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IndicatorGraph5.Name = "IndicatorGraph5";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.IndicatorGraph5.Series.Add(series4);
            this.IndicatorGraph5.Size = new System.Drawing.Size(676, 245);
            this.IndicatorGraph5.TabIndex = 4;
            this.IndicatorGraph5.Text = "chart3";
            // 
            // IndicatorGraph3
            // 
            chartArea5.Name = "ChartArea1";
            this.IndicatorGraph3.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.IndicatorGraph3.Legends.Add(legend5);
            this.IndicatorGraph3.Location = new System.Drawing.Point(740, 34);
            this.IndicatorGraph3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IndicatorGraph3.Name = "IndicatorGraph3";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.IndicatorGraph3.Series.Add(series5);
            this.IndicatorGraph3.Size = new System.Drawing.Size(676, 245);
            this.IndicatorGraph3.TabIndex = 5;
            this.IndicatorGraph3.Text = "chart4";
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(1505, 756);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(135, 66);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.Text = "Старт";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // HumansBody
            // 
            this.HumansBody.Location = new System.Drawing.Point(1434, 34);
            this.HumansBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HumansBody.Name = "HumansBody";
            this.HumansBody.Size = new System.Drawing.Size(279, 712);
            this.HumansBody.TabIndex = 8;
            this.HumansBody.TabStop = false;
            // 
            // ExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 840);
            this.Controls.Add(this.HumansBody);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.IndicatorGraph3);
            this.Controls.Add(this.IndicatorGraph5);
            this.Controls.Add(this.IndicatorGraph2);
            this.Controls.Add(this.IndicatorGraph4);
            this.Controls.Add(this.IndicatorGraph1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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