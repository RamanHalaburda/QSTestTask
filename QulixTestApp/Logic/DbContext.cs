using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;

namespace QulixTestApp.Logic
{
    public class DbContext
    {
        private static string conStr = "TestConnection";

        public DataTable CallSelectSP(string _query)
        {
            string constr = ConfigurationManager.ConnectionStrings[conStr].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(_query))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("DbContext Error: " + ex); }
            return null;
        }

        public void CallUpdateSP(string _query)
        {
            string constr = ConfigurationManager.ConnectionStrings[conStr].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    
                    using (SqlCommand cmd = new SqlCommand(_query, con))
                    {
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("DbContext Error: " + ex); }
        }
    }
}