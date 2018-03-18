namespace AutomatedTrainer.WindowsFormsUI
{
    using AutomatedTrainer.Models;
    using System;

    partial class CreatePatientForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Submit = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SurName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(129, 267);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Сохранить";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(54, 49);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(246, 20);
            this.FirstName.TabIndex = 1;
            // 
            // SurName
            // 
            this.SurName.Location = new System.Drawing.Point(54, 98);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(246, 20);
            this.SurName.TabIndex = 5;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(54, 140);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(246, 20);
            this.LastName.TabIndex = 6;
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            AutomatedTrainer.Models.Sex.Male,
            AutomatedTrainer.Models.Sex.Female});
            this.Sex.Location = new System.Drawing.Point(54, 179);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(246, 21);
            this.Sex.TabIndex = 7;
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(54, 229);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(246, 20);
            this.BirthDate.TabIndex = 8;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(54, 25);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "Имя";
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Location = new System.Drawing.Point(54, 76);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurNameLabel.TabIndex = 10;
            this.SurNameLabel.Text = "Фамилия";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(54, 121);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(54, 13);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Отчество";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(54, 163);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(27, 13);
            this.SexLabel.TabIndex = 12;
            this.SexLabel.Text = "Пол";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(54, 213);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.BirthDateLabel.TabIndex = 13;
            this.BirthDateLabel.Text = "Дата рождения";
            // 
            // CreatePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 343);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.SurNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.SurName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Submit);
            this.Name = "CreatePatientForm";
            this.Text = "Создание Пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox SurName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label BirthDateLabel;
    }
}

