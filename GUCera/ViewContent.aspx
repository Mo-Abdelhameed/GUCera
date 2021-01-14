<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewContent.aspx.cs" Inherits="GUCera.ViewContent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<style>
        .burly {
            color:burlywood;
        }

    </style>

</head>
<body style="background-color:black">
    <form id="vcontent" runat="server">
        <center>
        <div style="color:burlywood">
            <h1>Assignments Content</h1>
            Enter Your Course ID: <br />
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox> <br /> <br />
            <asp:Button ID="submit" runat="server" Text="View Assignment Content" OnClick="viewContent" />

        </div>
            </center>
    </form>
</body>
</html>
