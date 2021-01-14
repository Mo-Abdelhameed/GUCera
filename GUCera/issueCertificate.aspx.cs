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
    public partial class issueCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void homepage(object sender, EventArgs e)
        {
            Response.Redirect("instructorView.aspx");
        }
        protected void issueStudentCertificate(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if ( cid.Text.Equals("") || sid.Text.Equals(""))
            {
                Response.Write("<script> alert('Please fill all requirements first'); </script>");
                return;
            }

           
            try
            {

                int courseid = Int32.Parse(cid.Text);
                int studentid = Int32.Parse(sid.Text);
                DateTime issueDate = DateTime.Now;

                SqlConnection conn1 = new SqlConnection(connStr);
                SqlCommand finalgrade = new SqlCommand("calculateFinalGrade", conn1);
                finalgrade.CommandType = CommandType.StoredProcedure;
                finalgrade.Parameters.Add(new SqlParameter("@insId", Session["user"]));
                finalgrade.Parameters.Add(new SqlParameter("@cid", courseid));
                finalgrade.Parameters.Add(new SqlParameter("@sid", studentid));
                conn1.Open();
                finalgrade.ExecuteNonQuery();
                conn1.Close();

                SqlCommand issuecertificateproc = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                issuecertificateproc.CommandType = CommandType.StoredProcedure;

                issuecertificateproc.Parameters.Add(new SqlParameter("@insId", Session["user"]));
                issuecertificateproc.Parameters.Add(new SqlParameter("@cid", courseid));
                issuecertificateproc.Parameters.Add(new SqlParameter("@sid", studentid));
                issuecertificateproc.Parameters.Add(new SqlParameter("@issueDate", issueDate));


                conn.Open();
                issuecertificateproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script> alert('Certificate Has Been Successfully Issued!'); </script>");

            }
            catch (SqlException exception)
            {

                Response.Write("<script> alert('You cant issue a certificate to this student. Make sure you teach this student this course and the student hasnt recieved a certificate in this course and that the student passed this course '); </script>");
                return;
            }
            catch (FormatException)
            {
                Response.Write("<script> alert('Format Error! Make sure you entered a valid numerical ID'); </script>");
                return;
            }
        }
    }
}