using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidations.Models
{
    public class NiitishValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if(value!= null)
            {
                string message = value.ToString();
                if(message.Contains("nitish"))
                {
                    return ValidationResult.Success;
                }
               
            }
            ErrorMessage = ErrorMessage ?? "Field must contain Nitish";
            return new ValidationResult(ErrorMessage);
        }
    }
}