using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace GUCera
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse(username.Text);
            String pass = password.Text;
            SqlCommand loginproc = new SqlCommand("userLogin", conn);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));
            SqlParameter success = loginproc.Parameters.Add("@success", System.Data.SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", System.Data.SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;
            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if(success.Value.ToString() == "1")
            {
                Session["user"] = id;
                if(type.Value.ToString() == "2")
                    Response.Redirect("studentprofile.aspx");
                else if(type.Value.ToString() == "0")
                    Response.Redirect("instructorView.aspx");

            }
            else
            {
                span1.Style.Remove("display");
            }
               
            
        

        }
        protected void register1(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }



    }
}