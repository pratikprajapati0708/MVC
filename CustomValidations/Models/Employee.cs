using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidations.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        [NiitishValidation]
        public string Message{ get; set; }
    }
}