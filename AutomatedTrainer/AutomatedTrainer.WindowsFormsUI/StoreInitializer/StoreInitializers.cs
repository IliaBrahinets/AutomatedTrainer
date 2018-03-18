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
            RandomSensor randomSensor = new RandomSensor();
            Store.Instance.AddSensor(randomSensor);

            Store.Instance.AddPhysicalIndicator(new BloodPressureIndicator(randomSensor));
            Store.Instance.AddPhysicalIndicator(new ElectricalConductivityIndicator(randomSensor));
            Store.Instance.AddPhysicalIndicator(new HeartRateIndicator(randomSensor));
            Store.Instance.AddPhysicalIndicator(new SkinMoistureIndicator(randomSensor));
            Store.Instance.AddPhysicalIndicator(new SkinTemperatureIndicator(randomSensor));
        }
    }
}
