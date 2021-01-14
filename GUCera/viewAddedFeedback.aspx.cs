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
    public partial class viewAddedFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void homepage(object sender, EventArgs e)
        {
            Response.Redirect("instructorView.aspx");
        }
        protected void view(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (courseid.Text.Equals(""))
            {
                Response.Write("<script> alert('Please fill all requirements first'); </script>");
                return;
            }
            try
            {
                int cid = Int32.Parse(courseid.Text);


                SqlCommand viewfeedbackproc = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
                viewfeedbackproc.CommandType = CommandType.StoredProcedure;

                viewfeedbackproc.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
                viewfeedbackproc.Parameters.Add(new SqlParameter("@cid", cid));

                conn.Open();
                SqlDataReader rdr = viewfeedbackproc.ExecuteReader(CommandBehavior.CloseConnection);

                if (!rdr.HasRows)
                {
                    Response.Write("<script> alert('you dont have any feedback in this course yet'); </script>");
                    return;
                }



                Label title = new Label();
                title.Text = "Your feedback on this course:";
                viewFeedback.Controls.Add(title);
                BulletedList bt = new BulletedList();

                while (rdr.Read())
                {
                    
                    ListItem li = new ListItem();
                    li.Text = "Feedback Number  " + rdr.GetValue(rdr.GetOrdinal("number")) + "|     Comment: " + rdr.GetValue(rdr.GetOrdinal("comment")) + "|    Number Of Likes: " + rdr.GetValue(rdr.GetOrdinal("numberOfLikes"));
                    bt.Items.Add(li);
                }
                viewFeedback.Controls.Add(bt);
            }
            catch(FormatException exception)
            {
                Response.Write("<script> alert('Unsuccessful Attempt Due to Format Error! Make sure you entered a valid numerical ID'); </script>");
                return;
            }
            /*
            conn.Open();
            viewfeedbackproc.ExecuteNonQuery();
            conn.Close();
            */
        }
    }
}