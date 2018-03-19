// File:    Examination.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 18:57:16
// Purpose: Definition of Class Examination

using System;
using System.Collections.Generic;
using AutomatedTrainer.ModelsValidation;
using System.ComponentModel;

namespace AutomatedTrainer.Models
{
    public class Examination
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public BindingList<PhysicalIndicator> PhysicalIndicators { get; set; }

        public Examination(DateTime date, string type, IEnumerable<PhysicalIndicator> physicalIndicators)
            :this(date,type)
        {
            Date = date;
            Type = type;
            foreach (PhysicalIndicator item in physicalIndicators)
            {
                PhysicalIndicators.Add(item);
            }
        }

        public Examination(DateTime date, string type)
        {
            Date = date;
            Type = type;
            PhysicalIndicators = new BindingList<PhysicalIndicator>();
        }
    }
}