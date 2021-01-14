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
    public partial class addNewCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void homepage(object sender, EventArgs e)
        {
            Response.Redirect("instructorView.aspx");
        }
        protected void addCourse(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (creditHours.Text.Equals("") || name.Text.Equals("") || price.Text.Equals(""))
            {
                Response.Write("<script> alert('Please fill all requirements first'); </script>");
                return;
            }


            String coursename = name.Text; 


            try
            {
                int credithours = Int32.Parse(creditHours.Text);
               
                Decimal courseprice = Decimal.Parse(price.Text);

                SqlCommand addcourseproc = new SqlCommand("InstAddCourse", conn);
                addcourseproc.CommandType = CommandType.StoredProcedure;

                addcourseproc.Parameters.Add(new SqlParameter("@creditHours", credithours));
                addcourseproc.Parameters.Add(new SqlParameter("@name", coursename));
                addcourseproc.Parameters.Add(new SqlParameter("@price", courseprice));
                addcourseproc.Parameters.Add(new SqlParameter("@instructorId", Session["user"]));
               


                conn.Open();
                addcourseproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script> alert('Course Has Been Successfully Added!'); </script>");
                

            }
            catch (SqlException exception)
            {
                Response.Write("<script> alert('You already inserted this course before'); </script>");
                return;
            }
            catch (FormatException)
            {
                Response.Write("<script> alert('Unsuccessful Attempt! Make sure you etered valid numerical id and price'); </script>");
                return;
            }

            if (!cContent.Text.Equals("")){
                SqlConnection conn1 = new SqlConnection(connStr);
                String content = cContent.Text;

               
                SqlCommand addContent = new SqlCommand("UpdateCourseContent", conn1);
                addContent.CommandType = CommandType.StoredProcedure;

                conn1.Open();
                String sql = "select id from Course where name = '" + coursename + "'";
                SqlCommand cmd = new SqlCommand(sql  , conn1);
                int id = (Int32)cmd.ExecuteScalar();
                addContent.Parameters.Add(new SqlParameter("@courseId", id));
                addContent.Parameters.Add(new SqlParameter("@content", content));
                addContent.Parameters.Add(new SqlParameter("@instrId", Session["user"]));

                
                addContent.ExecuteNonQuery();
                conn1.Close();
            }

            if (!cDescription.Text.Equals(""))
            {
                SqlConnection conn2 = new SqlConnection(connStr);
                String desc = cDescription.Text;


                SqlCommand addDescr = new SqlCommand("UpdateCourseDescription", conn2);
                addDescr.CommandType = CommandType.StoredProcedure;

                conn2.Open();
                String sql = "select id from Course where name = '" +coursename + "'";
                SqlCommand cmd = new SqlCommand(sql, conn2);
                int id = (Int32)cmd.ExecuteScalar();
                addDescr.Parameters.Add(new SqlParameter("@courseId", id));
                addDescr.Parameters.Add(new SqlParameter("@courseDescription", desc));
                addDescr.Parameters.Add(new SqlParameter("@instrId", Session["user"]));


                addDescr.ExecuteNonQuery();
                conn2.Close();
            }
        }
    }
}