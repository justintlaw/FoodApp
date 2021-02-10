using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Suggestion
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string shopName { get; set; }

        [Required]
        public string favDish { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$")]
        public string shopPhoneNumber { get; set; }
    }
}
