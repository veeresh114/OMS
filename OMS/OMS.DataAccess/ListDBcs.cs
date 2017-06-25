using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OMS.BusinessEntities;
using System.Data.SqlClient;
using System.Data;

namespace OMS.DataAccess
{
    public class ListDB
    {
        public IList<ListItem> GetListItemsById(string listCode)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OMSConnection"].ConnectionString;
            IList<ListItem> listItems = new List<ListItem> ();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("OMS.usp_GetListItemsById", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ListCode", listCode);
                sqlCon.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListItem item = new ListItem();
                    item.Code=rdr["Code"].ToString();
                    item.ListId = (int)rdr["ListId"];
                    item.Name = rdr["Name"].ToString();
                    item.Descri = rdr["Description"].ToString();
                    item.Ordinal = (bool)rdr["Ordinal"];
                    listItems.Add(item);
                }
                return listItems;
            }

        }
    }
}
