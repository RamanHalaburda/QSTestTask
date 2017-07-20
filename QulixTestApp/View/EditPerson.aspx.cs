using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QulixTestApp.Models;

namespace QulixTestApp.View.Person
{
    public partial class EditPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbID.Text = Request.QueryString["id"];
                tbF.Text = Request.QueryString["f"];
                tbS.Text = Request.QueryString["s"];
                tbL.Text = Request.QueryString["l"];
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                PersonModel person = new PersonModel(System.Convert.ToInt32(tbID.Text), tbF.Text, tbS.Text, tbL.Text);

                Repository repository = new Repository();
                repository.EditPerson(person);
            }
            catch (Exception ex) { Response.Redirect("Error.aspx"); }
        }
    }
}