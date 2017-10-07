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
        
        public string description { get; set; }
       
        public int price { get; set; }

    }
}
