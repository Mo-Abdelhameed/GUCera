<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewGrade.aspx.cs" Inherits="GUCera.ViewGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        <span > {
            color:white;
        }
        </style>
</head>
<body style="background-color:black">
    
    <form id="grade" runat="server">
        <center>
       <div style="color:burlywood">
           <h1 >VIEW GRADE</h1>
               Assignment Type:<br />
           <!--  <asp:DropDownList ID="DropDownList2" runat="server"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="quiz" Value="0" />
                <asp:ListItem Text="exam" Value="1" />
                <asp:ListItem Text="project" Value="2" />
            </asp:DropDownList> <br /> -->
            <asp:TextBox ID="type" runat="server"></asp:TextBox> <br />
           Assignment Number:<br />
            <asp:TextBox ID="assignNum2" runat="server"></asp:TextBox> <br />
            Course ID:<br />
            <asp:TextBox ID="courseId2" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button2" runat="server" Text="View Grade" OnClick="ViewGrade1" /><br /> <br />
            <span id="info" runat="server"></span>
        </div>
            </center>
    </form>
</body>
</html>
