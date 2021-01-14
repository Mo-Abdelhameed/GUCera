using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class StudentPromocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand promoproc = new SqlCommand("viewPromocode", conn);
            promoproc.CommandType = CommandType.StoredProcedure;
            conn.Open();
            promoproc.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            SqlDataReader rdr = promoproc.ExecuteReader(CommandBehavior.CloseConnection);

            if (!rdr.HasRows)
            {
                HtmlGenericControl empty = new HtmlGenericControl("h1");
                empty.InnerHtml = "You Don't have any promocodes!";
                form1.Controls.AddAt(0, empty);
                return;
            }
            else
            {
                HtmlGenericControl empty = new HtmlGenericControl("h1");
                empty.InnerHtml = "Promocodes";
                form1.Controls.AddAt(0, empty);
            }

            while (rdr.Read())
            {
                String code = rdr.GetString(rdr.GetOrdinal("code"));
                DateTime issueDate = rdr.GetDateTime(rdr.GetOrdinal("isuueDate"));
                Decimal discount = rdr.GetDecimal(rdr.GetOrdinal("discount"));
                DateTime expDate = rdr.GetDateTime(rdr.GetOrdinal("expiryDate"));

                HtmlGenericControl code1 = new HtmlGenericControl("span");
                HtmlGenericControl issueDate1 = new HtmlGenericControl("span");
                HtmlGenericControl discount1 = new HtmlGenericControl("span");
                HtmlGenericControl expDate1 = new HtmlGenericControl("span");

                code1.InnerHtml = "Code: " + code;
                issueDate1.InnerHtml = "Issue date: " + issueDate.ToString();
                discount1.InnerHtml = "Discount: " + discount.ToString();
                expDate1.InnerHtml = "Expiry date: " + expDate.ToString();


                HtmlGenericControl div = new HtmlGenericControl("div");
                div.Controls.Add(code1);
                div.Controls.Add(new HtmlGenericControl("br"));
                div.Controls.Add(discount1);
                div.Controls.Add(new HtmlGenericControl("br"));
                div.Controls.Add(issueDate1);
                div.Controls.Add(new HtmlGenericControl("br"));
                div.Controls.Add(expDate1);
                div.Controls.Add(new HtmlGenericControl("br"));
                div.Attributes["class"] = "code";
                div1.Controls.Add(div);
                div1.Controls.Add(new HtmlGenericControl("br"));
            }

        }

       /* protected void home(object sender, EventArgs e)
        {
            Response.Redirect("studentprofile.aspx");
        }*/

    }
}