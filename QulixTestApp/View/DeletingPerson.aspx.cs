using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QulixTestApp.Models;

namespace QulixTestApp.View
{
    public partial class DeletePerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    PersonModel person = new PersonModel(System.Convert.ToInt32(Request.QueryString["id"]));
                    Repository repository = new Repository();
                    repository.DeletePerson(person);
                }
                catch (Exception ex) { Response.Redirect("Error.aspx"); }
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllPersons.aspx");
        }
    }
}