<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAddedFeedback.aspx.cs" Inherits="GUCera.viewAddedFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
              background-color: black;
              background-size: cover;
        }
        h1 {
            color: white;
            font-size: 20px;
            text-align: center;
            font-family: 'Cookie', cursive;
        }
        form{
            background: rgba(255, 255, 255);
            margin-left: 350px;
            margin-top: 50px;
            margin-right: 350px;
            margin-bottom: 50px;
            box-shadow: 3px 15px 22px 6px rgba(255,255,255);

        }
        .auto-style1 {
            margin-left: 200px;
        }
        li
        {
            color: black;
            font-size: 20px;
            text-align: center;
        }
        .auto-style4 {
            margin-left: 110px;
        }
        
        .add{
            color:black;
            background-color: black;
        }
    </style>
</head>

<body>
     <h1> Enter The Details Below To Show Your Feedback</h1> <br />  <br />
    <form id="viewFeedback" runat="server">
        <div>
                        

          
            <asp:Label ID="Label6" runat="server" Text="Course ID:" CssClass="auto-style4"></asp:Label> <br />  <br />
            <asp:TextBox ID="courseid" runat="server" Width="291px" CssClass="auto-style4"></asp:TextBox>  <br />  <br />

            <asp:Button ID="add" runat="server" Text="View My Feedback " OnClick="view" CssClass="auto-style4" Height="33px" Width="301px" BackColor="Black" ForeColor="White"/> <br /> <br />
            <asp:Button ID="Button1" runat="server" Text="Go Back To Home Page"  CssClass="auto-style4" OnClick="homepage" Height="33px" Width="301px" BackColor="Black" ForeColor="White"/> <br /> <br />
            

        </div>
    </form>
</body>
</html>
