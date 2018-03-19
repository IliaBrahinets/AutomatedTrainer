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

    public partial class ExaminationForm : Form
    {
        private Patient WhosExamination { get; set; }
        private Examination Examination { get; set; }

        public ExaminationForm(Patient patient, Examination examination)
        {
            WhosExamination = patient;
            Examination = examination;

            InitializeComponent();

            ExaminationInformationInit();
            //SensorsPlacesSet();
            InitializeGraphs();
        }

        private void ExaminationInformationInit()
        {
            PatientFullName.Text = WhosExamination.FullName;

            double totalDays = DateTime.Now.Subtract(WhosExamination.BirthDate).TotalDays;
            PatientAge.Text = Math.Floor(totalDays / 365).ToString();

            PatientSex.Text = WhosExamination.Sex.ToString();

            ExaminationDate.Text = Examination.Date.ToString();
            ExaminationType.Text = Examination.Type.ToString();


        }

        private void InitializeGraphs()
        {
            Te.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; // тут сами поизменяет/повыбирайте тип вывода графика

            for (int i = 0; i < x.Lenght; i++)
                chart1.Series[0].Points.AddXY(x[i], y[i]);
        }

        private void Examinatio_Load(object sender, EventArgs e)
        {

        }
    }
}
