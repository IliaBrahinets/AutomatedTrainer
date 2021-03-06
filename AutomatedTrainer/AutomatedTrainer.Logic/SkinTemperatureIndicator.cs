// File:    SkinTemperatureIndicator.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 22:44:04
// Purpose: Definition of Class SkinTemperatureIndicator

using System;

namespace AutomatedTrainer.Models
{
    public class SkinTemperatureIndicator : PhysicalIndicator
    {
        public SkinTemperatureIndicator(ISensor sensor) : base(sensor)
        {
            Name = "Показатель температуры кожи";
            MeasureUnits = "C";
        }

        public override int GetValue()
        {
            return base.GetValue() % 9 + 30;
        }
    }
}