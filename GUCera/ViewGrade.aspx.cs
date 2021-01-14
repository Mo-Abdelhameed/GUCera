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
    public partial class ViewGrade : System.Web.UI.Page
    {



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void ViewGrade1(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
               
                
                int cid = Int16.Parse(courseId2.Text);
                int assignNumber = Int16.Parse(assignNum2.Text);
                String assignType = type.Text;


                //SqlCommand checkGrade = new SqlCommand("SELECT * FROM StudentTakeAssignment STC INNER JOIN Course C ON STC.cid = C.id INNER JOIN Assignment A ON STC.assignmentNumber = A.number WHERE STC.cid =" + cid + " AND STC.sid =" + user + " AND C.id =" + cid + " AND A.[type] =" + assignType, conn);
                // "SELECT * FROM StudentCertifyCourse WHERE cid=" + cid + " and sid=" + user
                
                //object check = checkGrade.ExecuteScalar();


                /*String value = DropDownList2.SelectedValue;
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
               
                    if (assignType == "")
                        Response.Write("<script>alert('Please fill in the missing gaps')</script>");

                    else
                    {
                        if (assignType != "quiz" && assignType != "project" && assignType != "exam")
                            Response.Write("<script>alert('Incorrect Assignment Type')</script>");

                        else
                        {

                            SqlCommand viewgrade = new SqlCommand("viewAssignGrades", conn);
                            viewgrade.CommandType = CommandType.StoredProcedure;

                            viewgrade.Parameters.Add(new SqlParameter("@assignType", assignType));
                            viewgrade.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                            viewgrade.Parameters.Add(new SqlParameter("@cid", cid));
                            viewgrade.Parameters.Add(new SqlParameter("@assignnumber", assignNumber));
                            // viewgrade.Parameters.Add("@assignGrade", System.Data.SqlDbType.Int);
                            // viewgrade.Parameters["@assignGrade"].Direction = ParameterDirection.Output;
                            SqlParameter g = viewgrade.Parameters.Add(new SqlParameter("@assignGrade", SqlDbType.Int));
                            g.Direction = ParameterDirection.Output;

                            ///viewgrade.Parameters["@assignGrade"].Direction = ParameterDirection.Output;
                            conn.Open();
                            viewgrade.ExecuteNonQuery();
                            conn.Close();
                            String output = g.Value.ToString();
                            //String grade1 = "Your grade is " + "&nbsp;" + output;
                            // Response.Write("<script>alert()</script>"); g.Value.ToString()

                            info.InnerHtml = "Your grade is " + "&nbsp;" + output;

                        }
                    }

                
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Please fill in the missing gaps')</script>");
            }
            
        }
    }
}