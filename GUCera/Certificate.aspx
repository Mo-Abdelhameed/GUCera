<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Certificate.aspx.cs" Inherits="GUCera.Certificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .burly {
            color:burlywood;
        }

    </style>
</head>
<body style="background-color: black">
    <form id="cert" runat="server">
        
        <center>
            <div style="color: burlywood">
            <h1>Certificates</h1>
            Enter your Course ID: <br />
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox><br /> <br />
            <asp:Button ID="certificate" runat="server" Text="list Certificates" OnClick="ListCertificate" />
        </div>
            </center>
    </form>
   </body>
</html>
