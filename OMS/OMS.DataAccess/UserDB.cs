using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using OMS.BusinessEntities;

namespace OMS.DataAccess
{
    public class UserDB
    {
        public ValidationResults CreateUser(User user)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OMSConnection"].ConnectionString;
            ValidationResults result = new ValidationResults();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("OMS.spRegisterUser", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Pass", user.Password);
                cmd.Parameters.AddWithValue("@RoleId", 1); 
                //SqlParameter outPutParameter = new SqlParameter();
                //outPutParameter.ParameterName = "@UserId";
                //outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                //outPutParameter.Direction = System.Data.ParameterDirection.Output;
                //cmd.Parameters.Add(outPutParameter);

                sqlCon.Open();
                SqlDataReader rdr= cmd.ExecuteReader();
                while(rdr.Read())
                {
                    result.ValidationMessage = rdr["validationMessage"]==null ? null:rdr["validationMessage"].ToString();
                    if(rdr["success"]!=null)
                    {
                        result.Success = (bool)rdr["success"];
                    }
                    if(rdr["Id"] != null)
                    {
                         result.Id =  (int) rdr["Id"];
                    }
                       
                }
            }
            return result;
        }

       
    }
}
