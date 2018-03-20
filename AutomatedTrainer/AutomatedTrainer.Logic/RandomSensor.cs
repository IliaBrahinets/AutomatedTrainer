// File:    RandomSensor.cs
// Author:  Bragas PC
// Created: 2 сакавіка 2018 20:29:02
// Purpose: Definition of Class RandomSensor

using System;
using AutomatedTrainer.Models;

namespace AutomatedTrainer.Models
{
    public class RandomSensor : ISensor
    {
        public SensorStatus Status { get; private set; }

        private Random RandomGenerator;

        public RandomSensor()
        {
            RandomGenerator = new Random(DateTime.Now.GetHashCode());

            Status = SensorStatus.WorkingCorrectly;
        }

        public int GetValue()
        {
            return RandomGenerator.Next();
        }

    }
}