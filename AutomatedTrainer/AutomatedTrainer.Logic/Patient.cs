// File:    Patient.cs
// Author:  Bragas PC
// Created: 28 лютага 2018 18:18:02
// Purpose: Definition of Class Patient

using System;
using System.Collections.Generic;
using AutomatedTrainer.ModelsValidation;

namespace AutomatedTrainer.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Examination> Examinations { get; set; }

        public string FullName
        {
            get
            {
                return $"{SurName} {Name} {LastName}";
            }
        }

        public Patient(string name, string surName, string lastName, Sex sex, DateTime birthDate, IEnumerable<Examination> examinations)
            :this(name,surName,lastName,sex,birthDate)
        {
            if (examinations != null)
            {
                Examinations.AddRange(examinations);
            }
        }

        public Patient(string name, string surName, string lastName, Sex sex, DateTime birthDate)
        {
            Name = name;
            SurName = surName;
            LastName = lastName;
            Sex = sex;
            BirthDate = birthDate;
            Examinations = new List<Examination>();
        }

    }
}