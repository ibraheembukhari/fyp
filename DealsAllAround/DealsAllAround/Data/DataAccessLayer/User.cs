using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DealsAllAround.Models
{
    public class User
    {
        public string name { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string brand { get; set; }
        [Required(ErrorMessage = "Required.")]
        public int phone { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string address { get; set; }
        [Required(ErrorMessage = "Required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string email { get; set; }
    }
}
