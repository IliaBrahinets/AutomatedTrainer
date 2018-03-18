// File:    Examination.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 18:57:16
// Purpose: Definition of Class Examination

using System;
using System.Collections.Generic;
using AutomatedTrainer.ModelsValidation;

namespace AutomatedTrainer.Models
{
    public class Examination
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public List<PhysicalIndicator> PhysicalIndicators { get; set; }

        public Examination(DateTime date, string type, List<PhysicalIndicator> physicalIndicators)
            :this(date,type)
        {
            Date = date;
            Type = type;
            PhysicalIndicators.AddRange(physicalIndicators);
        }

        public Examination(DateTime date, string type)
        {
            Date = date;
            Type = type;
            PhysicalIndicators = new List<PhysicalIndicator>();
        }
    }
}