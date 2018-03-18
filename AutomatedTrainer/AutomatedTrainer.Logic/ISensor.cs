// File:    ISensor.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 19:50:28
// Purpose: Definition of Interface ISensor

using System;

namespace AutomatedTrainer.Models
{
    public interface ISensor
    {
        SensorStatus Status { get; }

        int GetValue();

    }
}