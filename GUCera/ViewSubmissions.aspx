<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSubmissions.aspx.cs" Inherits="GUCera.ViewSubmissions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
              background-color: black;
              background-size: cover;
            }
          form{
             background: rgba(255, 255, 255);
            margin-left:250px;
            margin-top: 100px;
            margin-right: 250px;
          
            box-shadow: 10px 15px 22px 6px rgba(255, 255, 255);

        }
           h1 {
              margin-top:10px;
            color: white;
            font-size: 30px;
            text-align: center;
            font-family: 'Cookie', cursive;
        }
        .auto-style1 {
            margin-left: 295px;
        }
        .auto-style2 {
            margin-left: 296px;
        }
    </style>
</head>
<body>
    <h1> Please Enter the details below </h1>
    <form id="viewS" runat="server">
        <div>


            <asp:Label ID="Label3" runat="server" Text="Course ID:" CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="cid" runat="server" CssClass="auto-style1"></asp:TextBox>  <br />  <br />

            <asp:Button ID="add" runat="server" Text="View Submissions" CssClass="auto-style1" OnClick="viewStudentsSubmissions" Height="35px" Width="169px" BackColor="Black" ForeColor="White"/> <br />  <br />
            <asp:Button ID="Button1" runat="server" Text="Go Back To Home Page" CssClass="auto-style1" OnClick="homepage" Height="35px" Width="169px" BackColor="Black" ForeColor="White"/><br />  
        </div>
    </form>
</body>
</html>
