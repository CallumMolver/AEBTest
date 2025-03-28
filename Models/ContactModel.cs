using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AEB_demo.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        [RegularExpression(@"^\+?\d{10,15}$", ErrorMessage = "Invalid phone number format")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please select an area of interest")]
        public string Interest { get; set; }

        public string Message { get; set; } // Message is optional

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
    }
}