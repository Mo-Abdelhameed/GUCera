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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void studentRegister(object sender, EventArgs e)
        {
            try
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

                    info.InnerHtml = "There is missing information!";
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
                info.InnerHtml = "You have registered successfully!";
                SqlConnection conn1 = new SqlConnection(connStr);
                SqlCommand getId = new SqlCommand("Select id from users where email = " + "'" + mail + "'", conn1);
                conn1.Open();
                SqlDataReader rdr = getId.ExecuteReader(CommandBehavior.CloseConnection);
                rdr.Read();
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                info.InnerHtml = "Your new id is " + id;
                
            }
            catch (SqlException ee)
            {
                info.InnerHtml = "This email address is already registered!";
            }

        }

        protected void instructorRegister(object sender, EventArgs e)
        {
            try
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
                    info.InnerHtml = "There is missing information!";
                    return;
                }


                SqlCommand registerproc = new SqlCommand("InstructorRegister", conn);
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
                info.InnerHtml = "You have registered successfully!";
                SqlConnection conn1 = new SqlConnection(connStr);
                SqlCommand getId = new SqlCommand("Select id from users where email = " +"'"+mail+"'", conn1);
                conn1.Open();
                SqlDataReader rdr = getId.ExecuteReader(CommandBehavior.CloseConnection);
                rdr.Read();
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                info.InnerHtml = "Your new id is " + id;
                
            }
            catch(SqlException ee)
            {
                info.InnerHtml = "This email address is already registered!";
            }
        }
        protected void login(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}