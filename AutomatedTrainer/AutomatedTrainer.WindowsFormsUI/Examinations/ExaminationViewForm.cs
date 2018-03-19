using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatedTrainer.Models;

namespace AutomatedTrainer.WindowsFormsUI
{
    public partial class ExaminationViewForm : Form
    {

        private Patient WhosExaminations { get; set; }

        public ExaminationViewForm(Patient patient)
        {
            InitializeComponent();

            if (patient == null)
            {
                return;
            }

            WhosExaminations = patient;

            //Dates
            Dates.DataSource = WhosExaminations.Examinations;
            Dates.ValueMember = "Date";
            Dates.DisplayMember = "Дата";

        }

        private void Dates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;

            Examination selectedExamination = listBox.SelectedItem as Examination;

            //Type
            Type.Text = selectedExamination.Type;

            //Physical Indicators
            PhysicalIndicators.DataSource = selectedExamination.PhysicalIndicators.Select(el => el.ToString()).ToArray();
            
        }

        private void InvokeCreateExaminationForm_Click(object sender, EventArgs e)
        {
            Form next = new CreateExaminationForm(WhosExaminations);

            next.FormClosed += (s, args) =>
            {
                new ExaminationViewForm(WhosExaminations).Show();
            };

            next.Show();
            next.Focus();

            this.Close();
        }
    }
}
