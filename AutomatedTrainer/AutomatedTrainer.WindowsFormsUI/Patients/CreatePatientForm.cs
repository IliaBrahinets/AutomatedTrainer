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
using AutomatedTrainer.WindowsFormsUI.Helpers;

namespace AutomatedTrainer.WindowsFormsUI
{
    using AutomatedTrainer.Store;

    public partial class CreatePatientForm : Form
    {
        public CreatePatientForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(FirstName.Text, SurName.Text, LastName.Text, 
                                            Sex.ParseEnum<Sex>(), BirthDate.Value);

            Store.Instance.AddPatient(patient);

            this.Close();
        }

    }
}
