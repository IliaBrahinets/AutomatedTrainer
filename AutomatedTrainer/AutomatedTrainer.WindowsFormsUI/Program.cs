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

            //Application.Run(new CreateExaminationForm(new Models.Patient("Илья", "Брагинец", "Андреевич", Models.Sex.Female, DateTime.Now)));
            //Application.Run(new CreatePatientForm());
            Patient patient = new Patient("Илья", "Брагинец", "Андреевич", Models.Sex.Female, DateTime.Now);
            patient.Examinations.Add(new Examination(DateTime.Now, "OK!", Store.Store.Instance.GetPhysicalIndicators()));
            patient.Examinations.Add(new Examination(DateTime.Now, "OssssK!", Store.Store.Instance.GetPhysicalIndicators()));
            Application.Run(new ExaminationViewForm(patient));
        }
    }
}
