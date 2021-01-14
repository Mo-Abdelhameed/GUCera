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
    public partial class StudentRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void studentRegister(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String firstName = firstname.Text;
            String lastName = lastname.Text;
            String pass = password.Text;
            String mail = email.Text;
            String Address = address.Text;


            if (firstName.Equals("") || lastname.Equals("") || pass.Equals("") || mail.Equals("") || Address.Equals("") || DropDownList1.SelectedValue.Equals("2"))
            {
                Label l = new Label();
                l.Text = "There is a missing information!";
                SRegister.Controls.Add(l);
         
                return;
            }


            SqlCommand registerproc = new SqlCommand("studentRegister", conn);
            registerproc.CommandType = CommandType.StoredProcedure;
            registerproc.Parameters.Add(new SqlParameter("@first_name", firstName));
            registerproc.Parameters.Add(new SqlParameter("@last_name", lastName));
            registerproc.Parameters.Add(new SqlParameter("@password", pass));
            registerproc.Parameters.Add(new SqlParameter("@email", mail));
            registerproc.Parameters.Add(new SqlParameter("@address", Address));

            int genderBit = Int32.Parse(DropDownList1.SelectedValue);

            registerproc.Parameters.Add(new SqlParameter("@gender", genderBit));



            conn.Open();
            registerproc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Login.aspx");
        }

        
    }
}