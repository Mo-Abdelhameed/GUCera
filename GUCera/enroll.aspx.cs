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
    public partial class enroll : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Int32.Parse(Session["wantedCourse"].ToString());
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand courseinfo = new SqlCommand("courseInformation", conn);
            courseinfo.CommandType = CommandType.StoredProcedure;
            courseinfo.Parameters.Add(new SqlParameter("@id", id));
            conn.Open();
            SqlDataReader rdr = courseinfo.ExecuteReader(CommandBehavior.CloseConnection);
            rdr.Read();
            String name = rdr.GetString(rdr.GetOrdinal("name"));
            int creditHours = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
            Decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
            
            int adminId = rdr.GetInt32(rdr.GetOrdinal("adminId"));
            int instructorId = rdr.GetInt32(rdr.GetOrdinal("instructorId"));
            String firstName = rdr.GetString(rdr.GetOrdinal("firstName"));
            String lastName = rdr.GetString(rdr.GetOrdinal("lastName"));

            HtmlGenericControl courseName = new HtmlGenericControl("span");
            HtmlGenericControl credit = new HtmlGenericControl("span");
            HtmlGenericControl courseDescription = new HtmlGenericControl("span");
            HtmlGenericControl coursePrice = new HtmlGenericControl("span");
            HtmlGenericControl courseContent = new HtmlGenericControl("span");
            HtmlGenericControl courseAdmin = new HtmlGenericControl("span");
            HtmlGenericControl courseInstructor = new HtmlGenericControl("span");
            HtmlGenericControl IName = new HtmlGenericControl("span");

            String description = "";
            String content = "";
            try
            {
                description = rdr.GetString(rdr.GetOrdinal("courseDescription"));
            }
            catch(Exception ee)
            {
                courseDescription.InnerHtml = "Course Description: The description is not defined yet!";
            }
            try
            {
                content = rdr.GetString(rdr.GetOrdinal("content"));
            }
            catch(Exception ee)
            {
                courseContent.InnerHtml = "Course Content: The content is not defined yet!";
            }

            courseName.InnerHtml = "Course Name: " + name;
            credit.InnerHtml = "Credit Hours: " + creditHours;
            courseDescription.InnerHtml = "Course Description: " + description;
            coursePrice.InnerHtml = "Price: " + price.ToString();
            courseContent.InnerHtml = "Course Content: " + content;
            courseInstructor.InnerHtml = "Instructor id: " + instructorId.ToString();
            IName.InnerHtml = "Instructor Name: " + firstName +" "+ lastName;

            div1.Controls.Add(courseName);
            div1.Controls.Add(new HtmlGenericControl("br"));
            div1.Controls.Add(credit);
            div1.Controls.Add(new HtmlGenericControl("br"));
            div1.Controls.Add(courseDescription);
            div1.Controls.Add(new HtmlGenericControl("br"));
            div1.Controls.Add(courseContent);
            div1.Controls.Add(new HtmlGenericControl("br"));
            div1.Controls.Add(coursePrice);
            div1.Controls.Add(new HtmlGenericControl("br"));
            div1.Controls.Add(IName);
            div1.Controls.Add(new HtmlGenericControl("br"));
            div1.Controls.Add(courseInstructor);
            div1.Controls.Add(new HtmlGenericControl("br"));
            conn.Close();

            String connStr1 = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn1 = new SqlConnection(connStr1);
            String query = "SELECT * FROM InstructorTeachCourse IT INNER JOIN Users I ON IT.insid = I.id WHERE cid = " + "'" + Session["wantedCourse"] + "'";
            SqlCommand sql = new SqlCommand(query, conn1);
            conn1.Open();
            SqlDataReader rdr1 = sql.ExecuteReader(CommandBehavior.CloseConnection);
            if(!rdr1.HasRows)
            {
                info.InnerHtml = "There are no instructors teaching this course!";

            }
            while (rdr1.Read())
            {
                String fName = rdr1.GetString(rdr1.GetOrdinal("firstName"));
                String lName = rdr1.GetString(rdr1.GetOrdinal("lastName"));
                Button iName = new Button();
                iName.Text = fName + " " + lName;
                iName.ID = rdr1.GetString(rdr1.GetOrdinal("email"));
                iName.Click += new EventHandler(selectInstructor);
                instructors.Controls.Add(iName);
                Session[iName.ID] = rdr1.GetInt32(rdr1.GetOrdinal("id"));
            }




        }

        protected void selectInstructor(object sender, EventArgs e)
        {
            Session["selectedInstructor"] = Session[((Button)sender).ID];
            info.InnerHtml = "You have selected instructor " + ((Button)sender).Text + " press Enroll to continue";
            Span1.InnerHtml = "";

        }


        protected void enrollInCourse(object sender, EventArgs e)
        {
            try
            { 
                int instructorId = (int)Session["selectedInstructor"];
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand enroll = new SqlCommand("enrollInCourse", conn);
                enroll.CommandType = CommandType.StoredProcedure;
                enroll.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                enroll.Parameters.Add(new SqlParameter("@cid", Session["wantedCourse"]));
                enroll.Parameters.Add(new SqlParameter("@instr", instructorId));
                conn.Open();
                SqlCommand tmp = new SqlCommand("SELECT COUNT(*) FROM StudentTakeCourse", conn);
                int before = (Int32)(tmp.ExecuteScalar());
                enroll.ExecuteNonQuery();
                int after = (Int32)(tmp.ExecuteScalar());
                if (before == after)
                {
                    Span1.InnerHtml = "You have to finish the Prerequisites first!";
                }
                else
                {
                    Span1.InnerHtml =  "You have enrolled in this course successfully!";
                }
                return;
            }
            catch(SqlException ex)
            {
                Span1.InnerHtml = "You have already enrolled in this course!";
            }







            
        }
            
        }
    }
