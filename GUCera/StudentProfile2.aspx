<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.StudentProfile2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:black">
    <form id="student" runat="server">
       
        <div style="color:burlywood">
            <h1>Student Profile</h1>
            <asp:Button ID="cont" runat="server" Text="View assignment content" OnClick="viewContent"/>
            <asp:Button ID="assign" runat="server" Text="Submit assignmengt" OnClick="submitAssign"/>
            <asp:Button ID="grad" runat="server" Text="View grade" OnClick="grade" />
            <asp:Button ID="comm" runat="server" Text="Add course feedback" OnClick="comment" />
            <asp:Button ID="cert" runat="server" Text="View Certificates" OnClick="listCertificate" />
        </div>
         
    </form>
</body>
</html>
