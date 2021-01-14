<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeAssignment.aspx.cs" Inherits="GUCera.GradeAssignment" %>

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
    <h1> Enter Assignment Details</h1>
    <form id="gradeAsssignment" runat="server">
        <div>
             

            <asp:Label ID="Label3" runat="server" Text="Student ID:" CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="studentid" runat="server" CssClass="auto-style1"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label6" runat="server" Text="Course ID:" CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="courseid" runat="server" CssClass="auto-style1"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label4" runat="server" Text="Assignment Number:" CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="anumber" runat="server" CssClass="auto-style1"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label5" runat="server" Text="Assignment Type:" CssClass="auto-style1"></asp:Label> <br />  <br />
             <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1">
                <asp:ListItem Value="0">Select type</asp:ListItem>
                <asp:ListItem Value="quiz">Quiz</asp:ListItem>
                <asp:ListItem Value="project">Project</asp:ListItem>
                <asp:ListItem Value="exam">Exam</asp:ListItem>
            </asp:DropDownList> <br/><br />

            <asp:Label ID="Label9" runat="server" Text="Grade:" CssClass="auto-style1"></asp:Label> <br />  <br />
            <asp:TextBox ID="agrade" runat="server" CssClass="auto-style1"></asp:TextBox>  <br />  <br />

            <asp:Button ID="add" runat="server" Text="Add Grade"  CssClass="auto-style1" OnClick="gradeAsg"  Height="35px" Width="169px" BackColor="Black" ForeColor="White"/>
             <asp:Button ID="Button1" runat="server" Text="Go Back To Home Page" CssClass="auto-style1" OnClick="homepage" Height="35px" Width="169px" BackColor="Black" ForeColor="White"/><br />  
        </div>
    </form>
</body>
</html>
