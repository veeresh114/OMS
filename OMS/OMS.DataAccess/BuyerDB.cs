using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using OMS.BusinessEntities;


namespace OMS.DataAccess
{
    public class BuyerDB
    {
        public ValidationResults RegisterNewBuyer(Buyer buyer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OMSConnection"].ConnectionString;
            ValidationResults result = new ValidationResults();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("OMS.spRegisterNewBuyer", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompanyName", buyer.CompanyName);
                cmd.Parameters.AddWithValue("CompanyDescription", buyer.CompanyDescription);
                cmd.Parameters.AddWithValue("@CompanyContactName", buyer.CompanyContactName);
                cmd.Parameters.AddWithValue("@EmailAddress", buyer.EmailAddress);
                cmd.Parameters.AddWithValue("@ContactNo", buyer.ContactNo);
                cmd.Parameters.AddWithValue("@PermanentAddress", buyer.PermanentAddress);
                cmd.Parameters.AddWithValue("@ShippingAddress", buyer.ShippingAddress);
                cmd.Parameters.AddWithValue("@City", buyer.City);
                cmd.Parameters.AddWithValue("@BankAccountNo", buyer.BankAccountNo);
                cmd.Parameters.AddWithValue("@Country", buyer.BankAccountNo);
                sqlCon.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    result.ValidationMessage = rdr["validationMessage"]==null ? null:rdr["validationMessage"].ToString();
                    if(rdr["success"]!=null)
                    {
                        result.Success = (bool)rdr["success"];
                    }
                    if(rdr["Id"] != null)
                    {
                         result.Id =  (int)  rdr["Id"];
                    }
                       
                }
            }
            return result;
        }
    }
}
