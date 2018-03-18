// File:    SkinMoistureIndicator.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 22:45:59
// Purpose: Definition of Class SkinMoistureIndicator

using System;

namespace AutomatedTrainer.Models
{
    public class SkinMoistureIndicator : PhysicalIndicator
    {
        public SkinMoistureIndicator(ISensor sensor) : base(sensor)
        {
            Name = "Показатель влажности кожи";
            MeasureUnits = "Отн. ед.";
        }
    }
}