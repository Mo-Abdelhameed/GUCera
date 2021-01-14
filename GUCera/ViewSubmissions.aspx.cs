using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ViewSubmissions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void homepage(object sender, EventArgs e)
        {
            Response.Redirect("instructorView.aspx");
        }

        protected void viewStudentsSubmissions(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (cid.Text.Equals(""))
            {
                Response.Write("<script> alert('Please fill all requirements first'); </script>");
                return;
            }
            try { 
            int courseid = Int32.Parse(cid.Text);

          
            SqlCommand viewSubProc = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewSubProc.CommandType = CommandType.StoredProcedure;

            viewSubProc.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            viewSubProc.Parameters.Add(new SqlParameter("@cid", courseid));
            conn.Open();
            SqlDataReader rdr = viewSubProc.ExecuteReader(CommandBehavior.CloseConnection);

                if (!rdr.HasRows)
                {
                    Response.Write("<script> alert('There are no submissions yet'); </script>");
                    return;
                }



                Label title = new Label();
                title.Text = "Student Submissions:";
                viewS.Controls.Add(title);
                BulletedList bt = new BulletedList();

                while (rdr.Read())
                {

                    ListItem li = new ListItem();
                    li.Text = "Student ID  " + rdr.GetValue(rdr.GetOrdinal("sid")) + "   |    Course ID: " + rdr.GetValue(rdr.GetOrdinal("cid")) + "    |     Assignment Number: " + rdr.GetValue(rdr.GetOrdinal("assignmentNumber")) + "    |     Assignment Type: " + rdr.GetValue(rdr.GetOrdinal("assignmenttype")) + "    |   Grade: " + rdr.GetValue(rdr.GetOrdinal("grade"));
                    bt.Items.Add(li);
                }
                viewS.Controls.Add(bt);
            }
            catch (FormatException)
            {
                Response.Write("<script> alert('Unsuccessful Attempt Due To Format Error! Make sure you entered a valid numerical ID'); </script>");
                return;
            }

        }
    }
}