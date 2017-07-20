using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QulixTestApp.Models;
using QulixTestApp.Logic;

namespace QulixTestApp.View.Task
{
    public partial class EditTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbID.Text = Request.QueryString["id"];
                tbName.Text = Request.QueryString["n"];
                tbAmount.Text = Request.QueryString["am"];
                tbDateS.Text = Request.QueryString["ds"];
                tbDateF.Text = Request.QueryString["df"];
                FillFields.LoadStatus(ddlStatus);
                ddlStatus.SelectedIndex = Convert.ToInt32(Request.QueryString["stid"]);
                FillFields.LoadPerson(ddlPerson);
                ddlPerson.SelectedIndex = Convert.ToInt32(Request.QueryString["pid"]);
            }
        }

        // save changes
        protected void btnEdit_Click1(object sender, EventArgs e)
        {
            try
            {
                PersonModel person = new PersonModel(ddlPerson.SelectedIndex, null, null, null);
                StatusModel status = new StatusModel(Convert.ToInt16(ddlStatus.SelectedIndex), null);
                TaskModel task = new TaskModel
                    (
                        Convert.ToInt32(tbID.Text),
                        tbName.Text,
                        Convert.ToInt32(tbAmount.Text),
                        DateTime.Parse(tbDateS.Text),
                        DateTime.Parse(tbDateF.Text),
                        status,
                        person
                    );

                Repository repository = new Repository();
                repository.EditTask(task);
            }
            catch (Exception ex)
            {
                Console.WriteLine("EditTask: " + ex);
                Response.Redirect("Error.aspx");
            }  
        }

        // cancel and return to AllTasks.aspx
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllTasks.aspx");
        }
    }
}