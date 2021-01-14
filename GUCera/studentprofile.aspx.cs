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
    public partial class studentprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand info = new SqlCommand("viewMyProfile", conn);
            info.CommandType = CommandType.StoredProcedure;
            conn.Open();
            info.Parameters.Add(new SqlParameter("@id", Session["user"]));
            SqlDataReader rdr = info.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int studentId = rdr.GetInt32(rdr.GetOrdinal("id"));
                String studentFirstName = rdr.GetString(rdr.GetOrdinal("firstName"));
                String studentLastName = rdr.GetString(rdr.GetOrdinal("lastName"));
                String studentPassword = rdr.GetString(rdr.GetOrdinal("password"));
                Byte[] studentGender = (Byte[])rdr.GetSqlBinary(rdr.GetOrdinal("gender"));
                String studentEmail = rdr.GetString(rdr.GetOrdinal("email"));
                String studentAddress = rdr.GetString(rdr.GetOrdinal("address"));
                
                sid.InnerHtml = "ID: " + studentId;
                sname.InnerHtml = "Name: " + studentFirstName + " " + studentLastName;
                smail.InnerHtml = "Email: " + studentEmail;
                saddress.InnerHtml = "Address: " + studentAddress;

                if (studentGender[0] == 0)
                    sgender.InnerHtml = "Gender: Female";
                else
                    sgender.InnerHtml =  "Gender: Male";
            }

        }

        protected void availableCourses(object sender, EventArgs e)
        {
            Response.Redirect("availablecourses.aspx");
        }
        protected void creditCard(object sender, EventArgs e)
        {
            Response.Redirect("creditcard.aspx");
        }

        protected void promoCode(object sender, EventArgs e)
        {
            Response.Redirect("StudentPromocode.aspx");
        }
        protected void courseinfo(object sender, EventArgs e)
        {
            Response.Redirect("viewCourseInfo.aspx");
        }
        protected void addMobile(object sender, EventArgs e)
        {
            Response.Redirect("AddMobile.aspx");
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