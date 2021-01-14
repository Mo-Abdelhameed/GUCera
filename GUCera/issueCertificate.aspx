<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issueCertificate.aspx.cs" Inherits="GUCera.issueCertificate" %>

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
            margin-left:30%;
            margin-top: 100px;
            margin-right: 30%;
            margin-bottom: 150px;
            box-shadow: 10px 15px 22px 6px rgba(255, 255, 255);

        }
          h1 {
              margin-top:10px;
            color: white;
            font-size: 30px;
            text-align: center;
            font-family: 'Cookie', cursive;
        }
        .auto-style6 {
            margin-left: 89px;
        }
        .auto-style7 {
            margin-left: 106px;
        }
    </style>
</head>
<body>

    <h1> Please Enter The Details Below To Issue The Certificate </h1>
    <form id="form1" runat="server">
        <div>


            <asp:Label ID="Label3" runat="server" Text="Course ID:" CssClass="auto-style7"></asp:Label> <br />  <br />
            <asp:TextBox ID="cid" runat="server" CssClass="auto-style7" Width="169px"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label4" runat="server" Text="Student ID:" CssClass="auto-style7"></asp:Label> <br />  <br />
            <asp:TextBox ID="sid" runat="server" CssClass="auto-style7" Width="169px"></asp:TextBox>  <br />  <br />

            <asp:Button ID="add" runat="server" Text="Issue Certificate" OnClick="issueStudentCertificate" CssClass="auto-style7" Height="35px" Width="169px" BackColor="Black" ForeColor="White"/>  <br /> <br />
            <asp:Button ID="Button1" runat="server" Text="Go Back To Home Page"  CssClass="auto-style7" OnClick="homepage" Height="35px" Width="169px" BackColor="Black" ForeColor="White"/>
        </div>
    </form>
</body>
</html>
