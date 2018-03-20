// File:    ElectricalConductivityIndicator.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 22:46:55
// Purpose: Definition of Class ElectricalConductivityIndicator

using System;

namespace AutomatedTrainer.Models
{
    public class ElectricalConductivityIndicator : PhysicalIndicator
    {
        public ElectricalConductivityIndicator(ISensor sensor) : base(sensor)
        {
            Name = "Показатель проводимости кожи";
            MeasureUnits = "отн. ед.";
        }

        public override int GetValue()
        {
            return base.GetValue() % 35 + 25;
        }
    }
}