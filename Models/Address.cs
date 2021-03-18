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
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Street has to have name in between 3 and 32 letters.")]
        [Required(ErrorMessage = "You have to live on some street.")]
        public string Street { get; set; }

        [Display(Name = "Kod pocztowy")]
        [StringLength(6, MinimumLength = 5, ErrorMessage = "Zipcode has to be 6 signs long.")]
        [Required(ErrorMessage = "This street should have it's zipcode.")]
        public string ZipCode { get; set; }

        [Display(Name = "Miasto")]
        [Required(ErrorMessage = "City field is required.")]
        public string City { get; set; }

        [Display(Name = "Numer telefonu")]
        [Required(ErrorMessage = "You should specify propper number.")]
        public int Number { get; set; }
    }
}
