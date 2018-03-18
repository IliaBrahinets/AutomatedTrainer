// File:    BloodPressureIndicator.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 22:43:03
// Purpose: Definition of Class BloodPressureIndicator

using System;

namespace AutomatedTrainer.Models
{
    public class BloodPressureIndicator : PhysicalIndicator
    {
        public BloodPressureIndicator(ISensor sensor) : base(sensor)
        {
            Name = "Показатель кровяного давления";
            MeasureUnits = "мм рт. ст.";
        }
    }
}