// File:    HeartRateIndicator.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 22:47:34
// Purpose: Definition of Class HeartRateIndicator

using System;

namespace Trainer.Models
{
    public class HeartRateIndicator : PhysicalIndicator
    {
        public HeartRateIndicator(ISensor sensor) : base(sensor)
        {
            Name = "Показатель частоты пульса сердечного ритма";
            MeasureUnits = "уд. в мин";
        }
    }
}