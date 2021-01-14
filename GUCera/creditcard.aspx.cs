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
    public partial class creditcard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addCreditCard(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand creditCard = new SqlCommand("addCreditCard", conn);
            creditCard.CommandType = CommandType.StoredProcedure;
            String cardNumber = cardnumber.Text;
            String CVV = cvv.Text;
            String cardHolderName = cardholdername.Text;
            String expDate = expirydate.Text;

            if (cardHolderName.Equals("") || cardNumber.Equals("") || CVV.Equals("") || expDate.Equals(""))
            {
                info.InnerHtml = "Enter All Information about the credit card";
                return;
            }
            if(cardNumber.Length != 15)
            {
                info.InnerHtml = "A valid credit card number consists of 15 digit!";
                return;
            }
            if(CVV.Length != 3)
            {
                info.InnerHtml = "The cvv consists of 3 digits!";
                return;
            }

            try
            {
                long n = Int64.Parse(cardNumber);
                int m = Int32.Parse(CVV);
                creditCard.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                creditCard.Parameters.Add(new SqlParameter("@number", cardNumber));
                creditCard.Parameters.Add(new SqlParameter("@cardHolderName", cardHolderName));
                creditCard.Parameters.Add(new SqlParameter("@cvv", CVV));
                creditCard.Parameters.Add(new SqlParameter("@expiryDate", expDate));
                conn.Open();
                creditCard.ExecuteNonQuery();
                conn.Close();
                info.InnerHtml = "The credit card was added successfully";
            }
            catch(SqlException exception)
            {
                info.InnerHtml = "This credit card is already added";
            }
            catch(FormatException exception)
            {
                info.InnerHtml = "The card number or the cvv is not valid";
            }
            
            

        }
        /*protected void home1(object sender, EventArgs e)
        {
            Response.Redirect("studentprofile.aspx");
        }*/

    }
}