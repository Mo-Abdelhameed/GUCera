using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Windows;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AddCourseAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void homepage(object sender, EventArgs e)
        {
            Response.Redirect("instructorView.aspx");
        }

        protected void addAssignment(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if ( cid.Text.Equals("") || anumber.Text.Equals("") || fgrade.Text.Equals("") || DropDownList1.SelectedValue.Equals("0") || acontent.Equals("") || aweight.Text.Equals("") || adeadline.Text.Equals(""))
            {
                Response.Write("<script> alert('Please fill all requirements first'); </script>");
                return;
            }
            try { 
                int courseid = Int32.Parse(cid.Text);
                int number = Int32.Parse(anumber.Text);
                String asgType = DropDownList1.SelectedValue;
                String weight = aweight.Text;
                int fullgrade = Int32.Parse(fgrade.Text);
                DateTime deadline = DateTime.Parse(adeadline.Text);
                String content = acontent.Text;

           
   
                SqlCommand addcourseasgproc = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
                addcourseasgproc.CommandType = CommandType.StoredProcedure;


                addcourseasgproc.Parameters.Add(new SqlParameter("@instId", Session["user"]));
                addcourseasgproc.Parameters.Add(new SqlParameter("@cid", courseid));
                addcourseasgproc.Parameters.Add(new SqlParameter("@number", number));
                addcourseasgproc.Parameters.Add(new SqlParameter("@type", asgType));
                addcourseasgproc.Parameters.Add(new SqlParameter("@fullGrade", fullgrade));
                addcourseasgproc.Parameters.Add(new SqlParameter("@weight", weight));
                addcourseasgproc.Parameters.Add(new SqlParameter("@deadline", deadline));
                addcourseasgproc.Parameters.Add(new SqlParameter("@content", content));

                conn.Open();
                // Console.Write(conn.InfoMessage +"") ;
                addcourseasgproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script> alert('Assignmnet Has Been Successfully Addedd'); </script>");


            }

            catch (SqlException)
            {
                Response.Write("<script> alert('Unsuccessfull Attempt To Add Assignment Make sure that you teach this course and that this assignment have not been added before'); </script>");
                return;
            }
            catch (FormatException)
            {
                Response.Write("<script> alert('Format Error! Make sure you entered a valid numerical ID'); </script>");
                return;
            }

        }

        protected void adeadline_SelectionChanged(object sender, EventArgs e)
        {

        }
        /*
static void connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
{
   // this gets the print statements (maybe the error statements?)
   Console.Write( e.Message);
   // string caption = "Error Detected in Input";
  //  MessageBox.Show(output);
  // Response.Write("< script > alert(" + output + ");</script>");
}
*/

    }
}