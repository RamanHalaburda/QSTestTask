using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QulixTestApp.Models;

namespace QulixTestApp.View
{
    public partial class DeletingTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    TaskModel task = new TaskModel(System.Convert.ToInt32(Request.QueryString["id"]));
                    Repository repository = new Repository();
                    repository.DeleteTask(task);
                }
                catch (Exception ex) { Response.Redirect("Error.aspx"); }
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllTasks.aspx");
        }
    }
}