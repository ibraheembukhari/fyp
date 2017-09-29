using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DealsAllAround.Models
{
    public class DealProvider
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Description is Requierd")]
        public string description { get; set; }
        [Required(ErrorMessage = "Price is Requierd")]
        public int price { get; set; }

    }
}
