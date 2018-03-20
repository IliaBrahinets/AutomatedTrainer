using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedTrainer.Models;

namespace AutomatedTrainer.Store
{
    static class StoreInitializers
    {
        static public void Initialize()
        {
            RandomSensor[] randomSensors = new RandomSensor[]
            {
                new RandomSensor(),
                new RandomSensor(),
                new RandomSensor(),
                new RandomSensor(),
                new RandomSensor()
            };
            Store.Instance.AddSensor(randomSensors[0]);
            Store.Instance.AddSensor(randomSensors[1]);
            Store.Instance.AddSensor(randomSensors[2]);
            Store.Instance.AddSensor(randomSensors[3]);
            Store.Instance.AddSensor(randomSensors[4]);

            Store.Instance.AddPhysicalIndicator(new BloodPressureIndicator(randomSensors[0]));
            Store.Instance.AddPhysicalIndicator(new ElectricalConductivityIndicator(randomSensors[1]));
            Store.Instance.AddPhysicalIndicator(new HeartRateIndicator(randomSensors[2]));
            Store.Instance.AddPhysicalIndicator(new SkinMoistureIndicator(randomSensors[3]));
            Store.Instance.AddPhysicalIndicator(new SkinTemperatureIndicator(randomSensors[4]));

            Examination examination = new Examination(DateTime.Now, "Тест", Store.Instance.GetPhysicalIndicators());

            var examinations = new List<Examination>();
            examinations.Add(examination);

            Patient patient = new Patient("Сергей", "Иванов", "Иванович", Sex.Male, DateTime.Parse("20.03.1998"), examinations);

            Store.Instance.AddPatient(patient);
        }
    }
}
