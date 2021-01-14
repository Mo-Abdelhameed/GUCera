<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitAssign.aspx.cs" Inherits="GUCera.SubmitAssign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
          span {
              color:red
          }
        
        </style>
</head>
<body style="background-color:black">
    <form id="submitAssign" runat="server">
        <center>
        <div style="color:burlywood">
            <h1>Assignment Submission</h1> 
             Assignment Type:<br />
            <!-- <asp:DropDownList ID="DropDownList1" runat="server"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="quiz" Value="0" />
                <asp:ListItem Text="exam" Value="1" />
                <asp:ListItem Text="project" Value="2" />
            </asp:DropDownList> <br /> -->
             <asp:TextBox ID="type" runat="server"></asp:TextBox> <br />
            Assignment Number:<br />
            <asp:TextBox ID="assignNum" runat="server"></asp:TextBox> <br />
            Course ID: <br />
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="submitAssignment" /> <br />
            <span id="info" runat="server"></span>
        </div>
            </center>
    </form>
</body>
</html>
