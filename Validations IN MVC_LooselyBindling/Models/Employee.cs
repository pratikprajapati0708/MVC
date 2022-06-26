using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // USe this 

namespace Validations_IN_MVC_LooselyBindling.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please enter the first name")]
        public int FirstName { get; set; }
        [Required]
        public int LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [Range(0,100)]
        public int Age { get; set; }
    }
}