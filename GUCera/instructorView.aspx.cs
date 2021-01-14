using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class instructorView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void viewAddedFeedback(object sender, EventArgs e)
        {
            Response.Redirect("viewAddedFeedback.aspx");
        }

        protected void issueCertificate(object sender, EventArgs e)
        {
            Response.Redirect("issueCertificate.aspx");
        }
        protected void addNewCourse(object sender, EventArgs e)
        {
            Response.Redirect("addNewCourse.aspx");
        }
        protected void AddCourseAssignment(object sender, EventArgs e)
        {
            Response.Redirect("AddCourseAssignment.aspx");
        }
        protected void ViewSubmission(object sender, EventArgs e)
        {
            Response.Redirect("ViewSubmissions.aspx");
        }
        protected void GradeAssignment(object sender, EventArgs e)
        {
            Response.Redirect("GradeAssignment.aspx");
        }
        protected void addMobile(object sender, EventArgs e)
        {
            Response.Redirect("AddMobile.aspx");
        }

    }
}