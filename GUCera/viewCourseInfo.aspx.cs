using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUCera
{

    public partial class viewCourseInfo : System.Web.UI.Page
    {
        public static int x = 0;
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void courseInfo(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand courseinfo = new SqlCommand("courseInformation", conn);
            courseinfo.CommandType = CommandType.StoredProcedure;
            int id;
            try
            {
                id = Int32.Parse(courseid.Text);
            }

            catch (FormatException ee)
            {
                Response.Write("<script>alert('Enter a valid course id')</script>");
                return;
            }
            courseinfo.Parameters.Add(new SqlParameter("@id", id));
            conn.Open();
            SqlDataReader rdr = courseinfo.ExecuteReader(CommandBehavior.CloseConnection);
            if (!rdr.HasRows)
            {
                HtmlGenericControl span = new HtmlGenericControl("span");
                span.InnerHtml = "*There is no course with id " + id;
                span.Style["color"] = "red";
                div1.Controls.Add(span);
                return;
            }
            Session["wantedCourse"] = id;
            Response.Redirect("enroll.aspx");

        }
        /*protected void home(object sender, EventArgs e)
        {
            Response.Redirect("studentprofile.aspx");
        }*/

    }
}