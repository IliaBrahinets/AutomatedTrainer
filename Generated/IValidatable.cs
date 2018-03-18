// File:    IValidatable.cs
// Author:  Bragas PC
// Created: 2 сакавіка 2018 20:14:21
// Purpose: Definition of Interface IValidatable

using System;
using System.Collections.Generic;

namespace Trainer.ModelsValidtaion
{
    public interface IValidatable
    {
        List<ValidationResult> Validate();

    }
}