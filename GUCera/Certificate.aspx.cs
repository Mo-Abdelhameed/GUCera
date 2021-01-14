using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace GUCera
{
    public partial class Certificate : System.Web.UI.Page
    {
        private Color burlywood;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListCertificate(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int cid = Int16.Parse(courseId.Text);
                
               
                SqlCommand EnrollCheck = new SqlCommand("SELECT * FROM StudentCertifyCourse WHERE cid=" + cid + " and sid=" + Session["user"], conn);
               

                conn.Open();
                object check = EnrollCheck.ExecuteScalar();
              
                if (check == null)
                    Response.Write("<script>alert('You are not certified in this course')</script>");
                else
                {

                   
                        SqlCommand listCertificate = new SqlCommand("viewCertificate", conn);
                        listCertificate.CommandType = CommandType.StoredProcedure;
                        listCertificate.Parameters.Add(new SqlParameter("@cid", cid));
                        listCertificate.Parameters.Add(new SqlParameter("@sid", Session["user"]));


                        

                        SqlDataReader rdr = listCertificate.ExecuteReader(CommandBehavior.CloseConnection);
                    
                    if (rdr.Read())
                    {
                        Label header = new Label();
                        header.Text = "Cid" + "&nbsp; " + "Sid" + "&nbsp;" + "IssueDate" + "<br>";

                        header.CssClass = "burly";

                        cert.Controls.Add(header);

                        int Cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                        int Sid = rdr.GetInt32(rdr.GetOrdinal("sid"));
                        DateTime IssueDate = rdr.GetDateTime(rdr.GetOrdinal("issueDate"));
                        Label certificate = new Label();
                        certificate.CssClass = "burly";
                        certificate.Text = Cid + "&nbsp; &nbsp; &nbsp; &nbsp;" + Sid + "&nbsp; &nbsp;" + IssueDate;
                        
                        cert.Controls.Add(certificate);



                        while (rdr.Read())
                        {
                             Cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                             Sid = rdr.GetInt32(rdr.GetOrdinal("sid"));
                             IssueDate = rdr.GetDateTime(rdr.GetOrdinal("issueDate"));
                             certificate = new Label();
                            certificate.Text = Cid + "&nbsp; &nbsp; &nbsp; &nbsp;" + Sid + "&nbsp; &nbsp;" + IssueDate;
                            certificate.CssClass = "burly";
                            cert.Controls.Add(certificate);
                        }
                    }
                        //viewContent.ExecuteNonQuery();
                        conn.Close();
                    }
               // }
                //style="background-color: black"
                //style="color:burlywood"
            }
            catch (Exception)
            {
                Response.Write("<script>alert('You did not enter a course id')</script>");
            }
        }
    }
}