<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCourseAssignment.aspx.cs" Inherits="GUCera.AddCourseAssignment" %>

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
        .auto-style3 {
            margin-left: 101px;
        }
        </style>
</head>
<body>
    <h1> Enter Assignment Details Here </h1>
    <div class="cont">>
        
    <form id="addasg" runat="server">
      
            

            

            <asp:Label ID="Label3" runat="server" Text="Course ID:"  CssClass="auto-style3"></asp:Label> <br />  <br />
            <asp:TextBox ID="cid" runat="server" Width="393px"  CssClass="auto-style3"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label4" runat="server" Text="Assignment Number:"  CssClass="auto-style3"></asp:Label> <br />  <br />
            <asp:TextBox ID="anumber" runat="server"  CssClass="auto-style3" Width="387px"></asp:TextBox>  <br />  <br />

           <asp:Label ID="Label5" runat="server" Text="Assignment Type:"  CssClass="auto-style3"></asp:Label> <br />  <br />
             <asp:DropDownList ID="DropDownList1" runat="server"  CssClass="auto-style3" Height="23px" Width="396px" >
                <asp:ListItem Value="0">Select type</asp:ListItem>
                <asp:ListItem Value="quiz">Quiz</asp:ListItem>
                <asp:ListItem Value="project">Project</asp:ListItem>
                <asp:ListItem Value="exam">Exam</asp:ListItem>
            </asp:DropDownList> <br/><br />

            <asp:Label ID="Label6" runat="server" Text="Assignmet Full Grade:"  CssClass="auto-style3"></asp:Label> <br />  <br />
            <asp:TextBox ID="fgrade" runat="server" Width="393px"  CssClass="auto-style3"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label7" runat="server" Text="Assignment Weight:"  CssClass="auto-style3"></asp:Label> <br />  <br />
            <asp:TextBox ID="aweight" runat="server" Width="393px"  CssClass="auto-style3"></asp:TextBox>  <br />  <br />

            <asp:Label ID="Label8" runat="server" Text="Assignment Deadline:"  CssClass="auto-style3"></asp:Label> <br />  <br />
            <asp:Label ID="Label1" runat="server" Text="*Enter Date and Time in Format: MM/DD/YYYY HH:MM:SS"  CssClass="auto-style3"></asp:Label> <br />  <br />
            <asp:TextBox ID="adeadline" runat="server" Width="393px"  CssClass="auto-style3"></asp:TextBox>  <br />  <br />

            

            <asp:Label ID="Label9" runat="server" Text="Assignment Content:"  CssClass="auto-style3"></asp:Label> <br />  <br />
            <asp:TextBox ID="acontent" runat="server" Height="55px"  CssClass="auto-style3" Width="390px"></asp:TextBox>  <br />  <br /><br />

            



            <asp:Button ID="add" runat="server" Text="Add Assignment"  CssClass="auto-style3" OnClick="addAssignment" Width="397px" BackColor="Black" ForeColor="White" Height="40px"/> <br /> <br />
         <asp:Button ID="Button1" runat="server" Text="Go Back To Home Page"  CssClass="auto-style3" OnClick="homepage" Width="397px" BackColor="Black" ForeColor="White" Height="40px"/>
        
    </form>
  </div>
</body>
</html>
