using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using DealsAllAround.Models;
using System.Data;


namespace DealsAllAround.Models
{
    public class DealsViewModel
    {
        public List<DealProvider> GetAllData()
        {
            List<DealProvider> DealsVM = new List<DealProvider>();
            SqlConnection con = new SqlConnection(GetConString.ConString());
            {
                using (SqlCommand cmd = new SqlCommand("GetAllData", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        DealProvider dealsVM = new DealProvider();
                        dealsVM.id = Convert.ToInt16(reader["id"]);
                        dealsVM.description =reader["description"].ToString();
                        dealsVM.price = Convert.ToInt16(reader["price"]);

                        DealsVM.Add(dealsVM);
                    }
                }

            }
                    return DealsVM;
        }
            
        public void GetDetails(DealProvider dealpro)
        {
            SqlConnection con = new SqlConnection(GetConString.ConString());
            {
                using (SqlCommand cmd = new SqlCommand("InsertProduct", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@description", dealpro.description);
                    cmd.Parameters.AddWithValue("@price", dealpro.price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateData(DealProvider dealpro)
        {
            SqlConnection con = new SqlConnection(GetConString.ConString());
            {
                using (SqlCommand cmd = new SqlCommand("UpdateData", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@description", dealpro.description);
                    cmd.Parameters.AddWithValue("@price", dealpro.price);
                    cmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    

                }
            }

            
        }
        }

    }
