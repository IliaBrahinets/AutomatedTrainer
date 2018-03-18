// File:    PhysicalIndicator.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 19:10:44
// Purpose: Definition of Class PhysicalIndicator

using System;

namespace AutomatedTrainer.Models
{
    public abstract class PhysicalIndicator
    {

        public string Name { get; protected set; }
        public string MeasureUnits { get; protected set; }


        public PhysicalIndicator(ISensor sensor)
        {
            Sensor = sensor;
        }

        public virtual int GetValue()
        {
            if (Sensor != null)
                return Sensor.GetValue();
            else
                return 0;
        }

        protected ISensor Sensor;



    }
}