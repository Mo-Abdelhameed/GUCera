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
    public partial class SubmitAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void submitAssignment(object sender, EventArgs e)
        {
             try
            {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int cid = Int32.Parse(courseId.Text);
            int assignNumber = Int32.Parse(assignNum.Text);
            
            String assignType = type.Text;
           

          /*  String value = DropDownList1.SelectedValue;
            if (value.Equals(0))
                assignType = "quiz";
            else
            {
                if (value.Equals(1))
                {
                    assignType = "exam";
                }
                else
                    assignType = "project";
            }
          */
            SqlCommand SubmitAssignment = new SqlCommand("submitAssign", conn);
            SubmitAssignment.CommandType = CommandType.StoredProcedure;

            SubmitAssignment.Parameters.Add(new SqlParameter("@assignType", assignType));
            SubmitAssignment.Parameters.Add(new SqlParameter("@assignnumber", assignNumber));
            SubmitAssignment.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            SubmitAssignment.Parameters.Add(new SqlParameter("@cid", cid));



            conn.Open();
            SubmitAssignment.ExecuteNonQuery();
            conn.Close();
            //  info.InnerHtml = "Assignment Submitted Successfully!";
             Response.Write("<script>alert('Assignment Submitted Successfully!')</script>");
             }
             catch (SqlException)
             {
                 // info.InnerHtml = "You are not enrolled in this course";
                 Response.Write("<script>alert('You are not enrolled in this course')</script>");

             }
             catch (Exception)
             {
                 Response.Write("<script>alert('Please Enter Valid Input')</script>");
             }


        }
    }
}