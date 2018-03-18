// File:    Patient.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 18:18:02
// Purpose: Definition of Class Patient

using System;
using System.Collections.Generic;
using Trainer.ModelsValidtaion;

namespace Trainer.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Examination> Examinations { get; set; }

        public Patient(string name, string surName, string lastName, Sex sex, DateTime birthDate, List<Examination> examinations)
        {
            Name = name;
            SurName = surName;
            lastName = LastName;
            Sex = sex;
            BirthDate = birthDate;
            Examinations = new List<Examination>(examinations);
        }

    }
}