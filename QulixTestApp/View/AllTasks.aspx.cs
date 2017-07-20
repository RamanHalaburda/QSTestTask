using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QulixTestApp.Logic;
using QulixTestApp.Models;

namespace QulixTestApp.View.Task
{
    public partial class AllTasks : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected IEnumerable<TaskModel> GetTasks()
        {
            return repository.Tasks;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}