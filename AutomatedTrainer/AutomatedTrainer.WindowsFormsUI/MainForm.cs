using AutomatedTrainer.Models;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient("Илья", "Брагинец", "Андреевич", Models.Sex.Female, DateTime.Now);
            patient.Examinations.Add(new Examination(DateTime.Now, "OK!", Store.Store.Instance.GetPhysicalIndicators()));
            patient.Examinations.Add(new Examination(DateTime.Now, "OssssK!", Store.Store.Instance.GetPhysicalIndicators()));
            new ExaminationViewForm(patient).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new PatientViewForm().Show();
        }
    }
}
