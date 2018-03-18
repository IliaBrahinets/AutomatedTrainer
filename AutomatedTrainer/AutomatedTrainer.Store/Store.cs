using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedTrainer.Models;

namespace AutomatedTrainer.Store
{
    public class Store
    {
        private static Store _instance;

        public static Store Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Store();
                return _instance;
            }
        }

        protected Store()
        {
            Patients = new List<Patient>();
            PhysicalIndicators = new List<PhysicalIndicator>();
            Sensors = new List<ISensor>();
        }

        private List<Patient> Patients { get; set; }
        private List<PhysicalIndicator> PhysicalIndicators { get; set; }
        private List<ISensor> Sensors { get; set; }


        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public Patient[] GetPatients()
        {
            return Patients.ToArray();
        }

        public void RemovePatient(Patient patient)
        {
            Patients.Remove(patient);
        }

        public void AddPhysicalIndicator(PhysicalIndicator physicalIndicator)
        {
            PhysicalIndicators.Add(physicalIndicator);
        }

        public PhysicalIndicator[] GetPhysicalIndicators()
        {
            return PhysicalIndicators.ToArray();
        }

        public void RemovePhysicalIndicator(PhysicalIndicator physicalIndicator)
        {
            PhysicalIndicators.Remove(physicalIndicator);
        }

        public void AddSensor(ISensor sensor)
        {
            Sensors.Add(sensor);
        }

        public ISensor[] GetSensors()
        {
            return Sensors.ToArray();
        }

        public void RemoveSensor(ISensor sensor)
        {
            Sensors.Remove(sensor);
        }

    }
}
