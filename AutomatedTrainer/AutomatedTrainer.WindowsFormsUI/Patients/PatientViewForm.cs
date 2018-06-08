using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTrainer.WindowsFormsUI
{
    using AutomatedTrainer.Models;
    using AutomatedTrainer.Store;

    public partial class PatientViewForm : Form
    {
        public PatientViewForm()
        {
            InitializeComponent();

            ConfigurePatientTable();

        }

        private void ConfigurePatientTable()
        {
            DataGridViewTextBoxColumn fullNameColumn = new DataGridViewTextBoxColumn();
            fullNameColumn.HeaderText = "ФИО";
            fullNameColumn.Name = "FullName";
            fullNameColumn.DataPropertyName = "FullName";

            DataGridViewTextBoxColumn birthDateColumn = new DataGridViewTextBoxColumn();
            birthDateColumn.HeaderText = "Дата рождения";
            birthDateColumn.Name = "BirthDate";
            birthDateColumn.DataPropertyName = "BirthDate";

            DataGridViewTextBoxColumn sexColumn = new DataGridViewTextBoxColumn();
            sexColumn.HeaderText = "Пол";
            sexColumn.Name = "Sex";
            sexColumn.DataPropertyName = "Sex";

            DataGridViewButtonColumn examinationButtons = new DataGridViewButtonColumn();
            examinationButtons.HeaderText = "Обследования";
            examinationButtons.Name = "Examination";
            examinationButtons.Text = "Показать";
            examinationButtons.UseColumnTextForButtonValue = true;
            PatientsTable.CellClick += 
                new DataGridViewCellEventHandler(PatientsTable_ExaminationsButtons);

            DataGridViewButtonColumn removeButtons = new DataGridViewButtonColumn();
            removeButtons.HeaderText = "Удаление";
            removeButtons.Name = "RemovePatient";
            removeButtons.Text = "Удалить";
            removeButtons.UseColumnTextForButtonValue = true;
            PatientsTable.CellClick +=
                new DataGridViewCellEventHandler(PatientsTable_RemovePatientButtons);

            PatientsTable.Columns.Add(fullNameColumn);
            PatientsTable.Columns.Add(birthDateColumn);
            PatientsTable.Columns.Add(sexColumn);
            PatientsTable.Columns.Add(examinationButtons);
            PatientsTable.Columns.Add(removeButtons);

            PatientsTable.AutoGenerateColumns = false;
            PatientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            UpdateDataSource();
        }

        private void PatientsTable_RemovePatientButtons(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            if (e.RowIndex == -1)
            {
                return;
            }

            if (columnIndex == PatientsTable.Columns["RemovePatient"].Index)
            {
                var patients = PatientsTable.DataSource as IList<Patient>;

                int i = e.RowIndex;

                Store.Instance.RemovePatient(patients[i]);

                UpdateDataSource();

            }
        }

        private void UpdateDataSource()
        {
            PatientsTable.DataSource = Store.Instance.GetPatients();
        }

        private void PatientsTable_ExaminationsButtons(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            if (e.RowIndex == -1)
            {
                return;
            }


            if (columnIndex == PatientsTable.Columns["Examination"].Index)
            {
                var patients = PatientsTable.DataSource as IList<Patient>;

                int i = e.RowIndex;

                ShowExaminationForm(patients[i]);
                
            }
        }

        private void ShowExaminationForm(Patient patient)
        {
            Form next = new ExaminationViewForm(patient);

            next.Show();
            next.Focus();
        }

        private void CreatePatientFormInvoke_Click(object sender, EventArgs e)
        {
            Form next = new CreatePatientForm();

            next.FormClosed += (s, args) =>
            {
                UpdateDataSource();
            };

            next.Show();
            next.Focus();

        }
    }
}
