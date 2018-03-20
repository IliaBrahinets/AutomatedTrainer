using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatedTrainer.Models;
using AutomatedTrainer.Store;

namespace AutomatedTrainer.WindowsFormsUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StoreInitializers.Initialize();

            Application.Run(new PatientViewForm());
            //Examination examination = Store.Store.Instance.GetPatients()[0].Examinations[0];
            //Application.Run(new ExaminationForm(Store.Store.Instance.GetPatients()[0], examination));
        }
    }
}
