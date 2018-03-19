using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedTrainer.Models;
using System.ComponentModel;

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
            Patients = new BindingList<Patient>();
            PhysicalIndicators = new BindingList<PhysicalIndicator>();
            Sensors = new BindingList<ISensor>();
        }

        private BindingList<Patient> Patients { get; set; }
        private BindingList<PhysicalIndicator> PhysicalIndicators { get; set; }
        private BindingList<ISensor> Sensors { get; set; }


        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public BindingList<Patient> GetPatients()
        {
            return Patients;
        }

        public void RemovePatient(Patient patient)
        {
            Patients.Remove(patient);
        }

        public void AddPhysicalIndicator(PhysicalIndicator physicalIndicator)
        {
            PhysicalIndicators.Add(physicalIndicator);
        }

        public BindingList<PhysicalIndicator> GetPhysicalIndicators()
        {
            return PhysicalIndicators;
        }

        public void RemovePhysicalIndicator(PhysicalIndicator physicalIndicator)
        {
            PhysicalIndicators.Remove(physicalIndicator);
        }

        public void AddSensor(ISensor sensor)
        {
            Sensors.Add(sensor);
        }

        public BindingList<ISensor> GetSensors()
        {
            return Sensors;
        }

        public void RemoveSensor(ISensor sensor)
        {
            Sensors.Remove(sensor);
        }

    }
}
