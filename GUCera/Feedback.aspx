<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="GUCera.feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        span{
            color: red;
        }


    </style>



</head>
<body style="background-color:black">
    <form id="feedback" runat="server">
        <center>
        <div style="color:burlywood">
            <h1>Course Feedback</h1>
             Course ID: <br />
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox> <br />
            Add Feedback:<br />
            <asp:TextBox ID="feed" runat="server"></asp:TextBox>  <br /><br />
            <asp:Button ID="addFeed" runat="server" Text="Add" OnClick="addFeedback" /> <br/>
            <span id="info" runat="server"></span>


        </div>
            </center>
    </form>
</body>
</html>
