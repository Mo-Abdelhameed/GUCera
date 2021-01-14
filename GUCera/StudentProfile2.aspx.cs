using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace GUCera
{
    public partial class StudentProfile2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewContent(object sender, EventArgs e)
        {
            Response.Redirect("ViewContent.aspx");
        }
        protected void submitAssign(object sender, EventArgs e)
        {
            Response.Redirect("SubmitAssign.aspx");
        }
        protected void grade(object sender, EventArgs e)
        {
            Response.Redirect("ViewGrade.aspx");
        }
        protected void listCertificate(object sender, EventArgs e)
        {
            Response.Redirect("Certificate.aspx");
        }
        protected void comment(object sender, EventArgs e)
        {
            Response.Redirect("Feedback.aspx");
        }

    }
}