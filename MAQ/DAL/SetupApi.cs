using BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SetupApi
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataTable dt;
        DataSet ds;
        string connectionstring = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
              
   // This method is used to get all Details of form.
        public List<BLL> GetAllSetupDetails()
        {
            List<BLL> objBLL = new List<BLL>();
            using (cmd = new SqlCommand("usp_SetupGet", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    adap = new SqlDataAdapter();
                    adap.SelectCommand = cmd;
                    dt = new DataTable();
                    adap.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        BLL col = new BLL();
                        col.ProjectName = row["ProjectName"].ToString();
                        col.ProjectCode = Convert.ToInt32(row["ProjectCode"]);
                        col.ProjectAddress = row["ProjectAddress"].ToString();
                        col.ProjectAddressn = row["ProjectAddressn"].ToString();
                        col.ProjectCity = row["ProjectCity"].ToString();
                        col.PojectState = Convert.ToInt32(row["ProjectState"]);
                        col.ProjectPostalCode = row["ProjectPostalCode"].ToString();
                        col.ProjectCountry= Convert.ToInt32(row["ProjectCountry"]);
                        col.Owner = row["Owner"].ToString();
                        col.OwnerAddress = row["OwnerAddress"].ToString();
                        col.OwnerAddressn = row["OwnerAddressn"].ToString();
                        col.OwnerCity = row["OwnerCity"].ToString();
                        col.OwnerState = Convert.ToInt32(row["OwnerState"]);
                        col.OwnerPostalCode = row["OwnerPostalCode"].ToString();
                        col.OwnerCountry= Convert.ToInt32(row["OwnerCountry"]);
                        col.OwnerRepresentative = row["OwnerAddress"].ToString();
                        col.OwnerEmailAddress = row["OwnerEmailAddress"].ToString();
                        col.OwnerPhoneNumber= Convert.ToInt32(row["OwnerPhoneNumber"]);
                        col.OwnerMobileNumber = row["OwnerMobileNumber"].ToString();
                        col.OriginOfContract = Convert.ToInt32(row["OriginOfContract"]);
                        col.TypeOfContract = Convert.ToInt32(row["TypeOfContract"]);
                        col.CountryOfContract = Convert.ToInt32(row["CountryOfContract"]);                       
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                }
                return objBLL;
            }           
        }      
    }
}  


    

