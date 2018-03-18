// File:    ElectricalConductivityIndicator.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 22:46:55
// Purpose: Definition of Class ElectricalConductivityIndicator

using System;

namespace Trainer.Models
{
    public class ElectricalConductivityIndicator : PhysicalIndicator
    {
        public ElectricalConductivityIndicator(ISensor sensor) : base(sensor)
        {
            Name = "Показатель проводимости кожи";
            MeasureUnits = "отн. ед.";
        }
    }
}