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
    public partial class AddMobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*protected void home(object sender, EventArgs e)
        {
            Response.Redirect("studentprofile.aspx");
        }*/

        protected void addMobile(object sender, EventArgs e)
        { 

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String mobileNumber = mobile.Text;

            try
            {
                Int64.Parse(mobileNumber);
            }
            catch(FormatException ee)
            {
                info.InnerHtml = "*Please enter a valid mobile number";
                return;
            }
            if(mobileNumber.Length != 11)
            {
                info.InnerHtml = "A valid mobile number consists of 11 digits!";
                return;
            }
            SqlCommand mobileproc = new SqlCommand("addMobile", conn);

            
            mobileproc.CommandType = CommandType.StoredProcedure;
            mobileproc.Parameters.Add(new SqlParameter("@id", Session["user"]));
            mobileproc.Parameters.Add(new SqlParameter("@mobile_number", mobileNumber));
            conn.Open();
            try
            {
                mobileproc.ExecuteNonQuery();
            }
            catch(SqlException ee)
            {
                info.InnerHtml = "*This mobile number is already added.";
                return;
            }
            info.InnerHtml = "The mobile number was added successfully!";
            
            conn.Close();
        }
    }
}