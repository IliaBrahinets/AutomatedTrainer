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
    using System.Windows.Forms.DataVisualization.Charting;
    using AutomatedTrainer.WindowsFormsUI.Examinations;
    using System.Drawing.Imaging;

    public partial class ExaminationForm : Form
    {
        private Patient WhosExamination { get; set; }
        private Examination Examination { get; set; }

        private GraphManager GraphManager { get; set; }
        private TimeManager TimeManager { get; set; }
        private SensorPlacesManager SensorPlacesManager { get; set; }


        public ExaminationForm(Patient patient, Examination examination)
        {
            WhosExamination = patient;
            Examination = examination;

            InitializeComponent();

            ExaminationInformationInit();

            this.GraphManager = new GraphManager(examination.PhysicalIndicators.ToArray(),
                IndicatorGraph1, IndicatorGraph2, IndicatorGraph3,
                IndicatorGraph4, IndicatorGraph5);

            this.TimeManager = new TimeManager(Synchronizer);

            this.SensorPlacesManager = new SensorPlacesManager(examination.PhysicalIndicators.ToArray(), HumansBody);

            DataRemovingInit();
        }

        
        private void DataRemovingInit()
        {
            this.FormClosed += (s, args) => {
                WhosExamination.Examinations.Remove(Examination);
            };
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

        private void Synchronizer_Tick(object sender, EventArgs e)
        {
            GraphManager.Step(TimeManager.Step());
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (TimeManager.IsRun())
            {
                TimeManager.Stop();

                Button btn = sender as Button;
                btn.Text = "Старт";
            }
            else
            {
                TimeManager.Start();

                Button btn = sender as Button;
                btn.Text = "Стоп";
            }
        }
    }
}
