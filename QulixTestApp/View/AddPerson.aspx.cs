using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QulixTestApp.Models;

namespace QulixTestApp.View.Person
{
    public partial class AddCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbF.Text == string.Empty ||
                    tbS.Text == string.Empty ||
                    tbL.Text == string.Empty)
                {
                    Response.Redirect("AddPerson.aspx");
                }
                else 
                {
                    PersonModel person = new PersonModel
                        (
                            0,
                            tbF.Text,
                            tbS.Text,
                            tbL.Text
                        );

                    Repository repository = new Repository();
                    repository.AddPerson(person);                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddPerson: " + ex);
                Response.Redirect("AddPerson.aspx");
            }

            Response.Redirect("AllPersons.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllPersons.aspx");
        }
    }
}