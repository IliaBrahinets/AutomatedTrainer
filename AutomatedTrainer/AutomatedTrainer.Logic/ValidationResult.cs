// File:    ValidationResult.cs
// Author:  Bragas PC
// Created: 2 сакавіка 2018 20:14:57
// Purpose: Definition of Class ValidationResult

using System;
using System.Collections.Generic;

namespace AutomatedTrainer.ModelsValidation
{
    public class ValidationResult
    {
        public List<string> MemberNames { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsSucces { get; set; }

        public ValidationResult(bool isSucces)
        {
            IsSucces = isSucces;
        }

        public ValidationResult(string errorMessage, List<string> memberNames)
        {
            IsSucces = false;
            ErrorMessage = errorMessage;
            MemberNames = new List<string>(memberNames);
        }
    }
}