using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using Microsoft.SqlServer;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

/* class for filling DropDownlists info from DB */

namespace QulixTestApp.Logic
{
    public class FillFields
    {
        private static string connStr = "TestConnection";

        // fill DropDownList status's titles
        public static void LoadStatus(DropDownList _ddl)
        {
            DataTable brands = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings[connStr].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("EXEC GetAllStatus", conn);
                    adapter.Fill(brands);

                    _ddl.DataSource = brands;
                    _ddl.DataTextField = "status_title";
                    _ddl.DataValueField = "status_id";
                    _ddl.DataBind();
                }
                catch (Exception) { }
            }

            _ddl.Items.Insert(0, new ListItem("<Выберите статус задачи>", "0"));
            _ddl.SelectedIndex = 0;
        }


        // fill DropDownList person's names
        public static void LoadPerson(DropDownList _ddl)
        {
            DataTable brands = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings[connStr].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("EXEC GetNamePerson", conn);
                    adapter.Fill(brands);

                    _ddl.DataSource = brands;
                    _ddl.DataTextField = "person_name";
                    _ddl.DataValueField = "person_id";
                    _ddl.DataBind();
                }
                catch (Exception) { }
            }

            _ddl.Items.Insert(0, new ListItem("<Выберите исполнителя>", "0"));
            _ddl.SelectedIndex = 0;
        }
    }
}