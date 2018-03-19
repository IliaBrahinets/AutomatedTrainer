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
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Submit.Location = new System.Drawing.Point(110, 307);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(104, 27);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Сохранить";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(54, 32);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(246, 22);
            this.FirstName.TabIndex = 1;
            // 
            // SurName
            // 
            this.SurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurName.Location = new System.Drawing.Point(54, 89);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(246, 22);
            this.SurName.TabIndex = 5;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(54, 140);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(246, 22);
            this.LastName.TabIndex = 6;
            // 
            // BirthDate
            // 
            this.BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDate.Location = new System.Drawing.Point(54, 271);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(246, 22);
            this.BirthDate.TabIndex = 8;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(54, 9);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(40, 20);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "Имя";
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNameLabel.Location = new System.Drawing.Point(50, 66);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(81, 20);
            this.SurNameLabel.TabIndex = 10;
            this.SurNameLabel.Text = "Фамилия";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(50, 117);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(83, 20);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Отчество";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexLabel.Location = new System.Drawing.Point(54, 170);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(40, 20);
            this.SexLabel.TabIndex = 12;
            this.SexLabel.Text = "Пол";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDateLabel.Location = new System.Drawing.Point(54, 248);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(128, 20);
            this.BirthDateLabel.TabIndex = 13;
            this.BirthDateLabel.Text = "Дата рождения";
            // 
            // Sex
            // 
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex.FormattingEnabled = true;
            this.Sex.ItemHeight = 16;
            this.Sex.Location = new System.Drawing.Point(54, 194);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(246, 36);
            this.Sex.TabIndex = 14;
            // 
            // CreatePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 346);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.SurNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.BirthDate);
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
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.ListBox Sex;
    }
}

