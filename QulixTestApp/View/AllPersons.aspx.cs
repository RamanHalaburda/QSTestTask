using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using QulixTestApp.Logic;
using QulixTestApp.Models;

namespace QulixTestApp.View.Person
{
    public partial class AllPersons : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected IEnumerable<PersonModel> GetPersons()
        {
            return repository.Persons;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}