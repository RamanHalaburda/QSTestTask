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
    public partial class AddTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillFields.LoadPerson(ddlPerson);
                FillFields.LoadStatus(ddlStatus);
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == string.Empty ||
                    tbAmount.Text == string.Empty ||
                    tbDateS.Text == string.Empty ||
                    tbDateF.Text == string.Empty ||
                    ddlPerson.SelectedIndex == 0 ||
                    ddlStatus.SelectedIndex == 0)
                {
                    Response.Redirect("AddTask.aspx");
                }
                else 
                {
                    PersonModel person = new PersonModel(ddlPerson.SelectedIndex, null, null, null);
                    StatusModel status = new StatusModel(Convert.ToInt16(ddlStatus.SelectedIndex), null);
                    TaskModel task = new TaskModel
                        (
                            0,
                            tbName.Text,
                            Convert.ToInt32(tbAmount.Text),
                            DateTime.Parse(tbDateS.Text),
                            DateTime.Parse(tbDateF.Text),
                            status,
                            person
                        );

                    Repository repository = new Repository();
                    repository.AddTask(task);                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddTask: " + ex);
                Response.Redirect("AddTask.aspx");
            }

            Response.Redirect("AllTasks.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllTasks.aspx");
        }
    }
}