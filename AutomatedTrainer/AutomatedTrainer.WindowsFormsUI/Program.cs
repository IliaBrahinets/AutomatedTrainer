using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Application.Run(new ExaminationViewForm());
        }
    }
}
