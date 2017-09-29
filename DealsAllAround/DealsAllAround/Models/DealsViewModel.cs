using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DealsAllAround.Models
{
    public class DealsViewModel
    {
        public void GetDetails(DealProvider dealpro)
        {
            SqlConnection con = new SqlConnection(GetConString.ConString());
            {
                using (SqlCommand cmd = new SqlCommand("InsertProduct", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@description",dealpro.description);
                    cmd.Parameters.AddWithValue("@price", dealpro.price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
