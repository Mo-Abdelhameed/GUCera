<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addNewCourse.aspx.cs" Inherits="GUCera.addNewCourse" %>

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
            box-shadow: 10px 15px 22px 6px rgba(255,255,255);

        }
          h1 {
            color: white;
            font-size: 30px;
            text-align: center;
            font-family: 'Cookie', cursive;
        }
        .auto-style1 {
            margin-left: 100px;
        }
        .auto-style2 {
            margin-left: 100px;
            margin-top: 20px;
            
        }
        .auto-style3 {
            margin-left: 100px;
            color: darkred;
            
        }
        </style>
</head>
<body>
    
    
     <h1> Enter Course Details Here:</h1>
     
    <form id="addNewCourse" runat="server">
        <div>
           

            <asp:Label ID="Label2" runat="server" Text="Credit Hours:" CssClass="auto-style2"></asp:Label> <br />  <br />
            <asp:TextBox ID="creditHours" runat="server" CssClass="auto-style1"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label3" runat="server" Text="Course Name:" CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="name" runat="server"  CssClass="auto-style1"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label4" runat="server" Text="Course Price:"  CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="price" runat="server"  CssClass="auto-style1"></asp:TextBox>  <br />  <br />



            <asp:Label ID="Label1" runat="server" Text="The following are not required, you may add them now or later"  CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:Label ID="Label6" runat="server" Text="Course Content:"  CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="cContent" runat="server"  CssClass="auto-style1"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label7" runat="server" Text="Course Description:"  CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="cDescription" runat="server"  CssClass="auto-style1"></asp:TextBox>  <br />  <br />



            <asp:Button ID="add" runat="server" Text="Add Course"  CssClass="auto-style1" OnClick="addCourse" Height="35px" Width="161px" BackColor="Black" ForeColor="White"/> <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Go Back To Home Page"  CssClass="auto-style1" OnClick="homepage" Height="35px" Width="161px" BackColor="Black" ForeColor="White"/>
        </div>
    </form>
</body>
</html>
