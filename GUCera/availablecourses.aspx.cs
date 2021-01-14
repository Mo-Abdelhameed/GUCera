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
    public partial class availablecourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand courses = new SqlCommand("availableCourses", conn);
            courses.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                //HtmlGenericControl coursename = new HtmlGenericControl("button");
                Button coursename = new Button();
                coursename.Click += new EventHandler(getCourseName);
                coursename.Text = courseName;
                form1.Controls.Add(coursename);
            }
        }

        protected void getCourseName(object sender, EventArgs e)
        {
            String courseName = "'" +  ((Button) sender).Text + "'";
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand sql = new SqlCommand("SELECT id FROM Course WHERE name = " + courseName, conn);
            conn.Open();
            SqlDataReader rdr = sql.ExecuteReader(CommandBehavior.CloseConnection);
            rdr.Read();
            int id = rdr.GetInt32(rdr.GetOrdinal("id"));
            Session["wantedCourse"] = id;
            Response.Redirect("enroll.aspx");
           
        }
        protected void home1(object sender, EventArgs e)
        {
            Response.Redirect("studentprofile.aspx");
        }
    }
}