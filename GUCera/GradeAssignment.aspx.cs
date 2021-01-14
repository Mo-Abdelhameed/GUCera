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
    public partial class GradeAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void homepage(object sender, EventArgs e)
        {
            Response.Redirect("instructorView.aspx");
        }

        protected void gradeAsg(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (studentid.Text.Equals("") || courseid.Text.Equals("") || anumber.Text.Equals("") || agrade.Text.Equals("") || DropDownList1.SelectedValue.Equals("0"))
            {
                Response.Write("<script> alert('Please fill all requirements first'); </script>");
                return;
            }

            try 
            {

                int sid = Int32.Parse(studentid.Text);
                int cid = Int32.Parse(courseid.Text);
                int number = Int32.Parse(anumber.Text);
                int grade = Int32.Parse(agrade.Text);
                String asgType = DropDownList1.SelectedValue;

                SqlCommand gradeasgproc = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
            gradeasgproc.CommandType = CommandType.StoredProcedure;

            gradeasgproc.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            gradeasgproc.Parameters.Add(new SqlParameter("@cid", cid));
            gradeasgproc.Parameters.Add(new SqlParameter("@assignmentNumber", number));
            gradeasgproc.Parameters.Add(new SqlParameter("@type", asgType));
            gradeasgproc.Parameters.Add(new SqlParameter("@grade", grade));
            gradeasgproc.Parameters.Add(new SqlParameter("@sid", sid));

            conn.Open();
            gradeasgproc.ExecuteNonQuery();
            conn.Close();
            Response.Write("<script> alert('Grade Has Been Successfully Added!'); </script>");

            }
            catch (SqlException exception)
            {
                Response.Write("<script> alert('You cant grade this assignment! Make sure you teach this student this course, and that this assignment exists '); </script>");
                return;
               
            }
            catch (FormatException)
            {
                Response.Write("<script> alert('Unsuccessful Attempt Due To Format Error! Make sure you entered a valid numerical ID'); </script>");
                return;
            }


        }
    }
}