using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Models
{
    public class Address
    {
        [Display(Name = "Ulica")]
        [Required(ErrorMessage = "You have to live on some street.")]
        [StringLength(32, MinimumLength = 3)]
        public string Street { get; set; }

        [Display(Name = "Kod pocztowy")]
        [Required(ErrorMessage = "This street should have it's zipcode.")]
        [StringLength(32, MinimumLength = 3)]
        public string ZipCode { get; set; }

        [Display(Name = "Miasto")]
        [Required(ErrorMessage = "City field is required.")]
        public string City { get; set; }

        [Display(Name = "Numer telefonu")]
        [Required(ErrorMessage = "You should specify propper number.")]
        public int Number { get; set; }
    }
}
