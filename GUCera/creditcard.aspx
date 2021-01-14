<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="creditcard.aspx.cs" Inherits="GUCera.creditcard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add credit card</title>
     <style>

        .center {
                margin: 0;
                 position: absolute;
                 top: 50%;
                 left: 50%;
                -ms-transform: translate(-50%, -50%);
                transform: translate(-50%, -50%);
        }
        body{background-color:black;}
        form{color:antiquewhite;}
        .top{ font: italic 8em "Fira Sans", serif; color:antiquewhite}
        #info{color:red}
    </style>
</head>
<body>
    <h1 class="top "style="text-align:center;">Add Credit Card</h1> <br/>
    <form class="center" id="form1" runat="server">

        <div>
            <h1>Enter Credit Card Details</h1> <br />

            <asp:Label ID="Label1" runat="server" Text="Credit Card Number"></asp:Label><br />
            <asp:TextBox ID="cardnumber" runat="server"></asp:TextBox>   <span id="cardnumber1" style="color:red"></span>  <br />

            <asp:Label ID="Label2" runat="server" Text="CVV"></asp:Label><br />
            <asp:TextBox ID="cvv" runat="server"></asp:TextBox>  <span id="cvv1" style="color:red"></span> <br />

            <asp:Label ID="Label3" runat="server" Text="Card Holder Name"></asp:Label><br />
            <asp:TextBox ID="cardholdername" runat="server"></asp:TextBox><span id="name" style="color:red"></span><br />

            <asp:Label ID="Label4" runat="server" Text="Expiry Date"></asp:Label><br />
            <asp:TextBox ID="expirydate" TextMode="Date" runat="server"></asp:TextBox><span id="date" style="color:red"></span><br /><br />


            <asp:Button ID="add" runat="server" Text="Add Credit Card" OnClick="addCreditCard" /><br /><br />
            <span id="info" runat="server"></span>
        </div>
          

    </form>
</body>
</html>
