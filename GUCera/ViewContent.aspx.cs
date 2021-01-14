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
    public partial class ViewContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void viewContent(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int cid = Int16.Parse(courseId.Text);

                SqlCommand viewContent = new SqlCommand("viewAssign", conn);
                viewContent.CommandType = CommandType.StoredProcedure;
                viewContent.Parameters.Add(new SqlParameter("@courseId", cid));
                viewContent.Parameters.Add(new SqlParameter("@Sid", Session["user"]));


                conn.Open();

                SqlDataReader rdr = viewContent.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    int Cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                    int number = rdr.GetInt32(rdr.GetOrdinal("number"));
                    String type = rdr.GetString(rdr.GetOrdinal("type"));
                    int fullGrade = rdr.GetInt32(rdr.GetOrdinal("fullGrade"));
                    Decimal weight = rdr.GetDecimal(rdr.GetOrdinal("weight"));
                    DateTime deadline = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                    String Content = rdr.GetString(rdr.GetOrdinal("content"));
                    Label name = new Label();
                    name.CssClass = "burly";
                    name.Text = Cid + "&nbsp;" + number + "&nbsp;" + type + "&nbsp;" + fullGrade +"&nbsp;" + weight + "&nbsp;" + deadline + "&nbsp;" + Content+"<br />";
                    vcontent.Controls.Add(name);
                }




                //viewContent.ExecuteNonQuery();
                conn.Close();

            }

            catch (Exception)
            {
                Response.Write("<script>alert('You did not enter a course id')</script>");
            }
        }
    }
}