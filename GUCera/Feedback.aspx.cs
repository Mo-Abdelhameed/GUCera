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
    public partial class feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addFeedback(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int cid = Int16.Parse(courseId.Text);

                
                String feedback = feed.Text;
                if (feedback == "")
                    info.InnerText = "Invalid Input";
                //Response.Write("<script>alert('Invalid Input')</script>");

                else
                {
                    SqlCommand addFeedback = new SqlCommand("addFeedback", conn);
                    addFeedback.CommandType = CommandType.StoredProcedure;
                    addFeedback.Parameters.Add(new SqlParameter("@cid", cid));
                    addFeedback.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                    addFeedback.Parameters.Add(new SqlParameter("@comment", feedback));
                    conn.Open();
                    addFeedback.ExecuteNonQuery();
                    conn.Close();
                    info.InnerText = "Feedback added successfully!";
                    //Response.Write("<script>alert('Feedback added successfully!')</script>");
                }
            }
            catch (Exception)
            {
                info.InnerText = "Please enter a valid input";
            }
        }
    }
}