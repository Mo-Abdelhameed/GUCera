<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewCourseInfo.aspx.cs" Inherits="GUCera.viewCourseInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>view course info</title>
    <style>
         .center {
                margin: 0;
                 position: absolute;
                 top: 50%;
                 left: 50%;
                -ms-transform: translate(-50%, -50%);
                transform: translate(-50%, -50%);
        }
         body{
            background-color: black;
        }
         form{
             color: antiquewhite;
             height: 25%; 
         }
          h1{
            text-align:center; 
            color:antiquewhite;
            font: italic 8em "Fira Sans", serif;
        
        }
          
    </style>
</head>
<body>
     <h1 style="text-align: center">View Course Information</h1> <br/>
    <form class="center" id="form1" runat="server">
        <div id="div1" runat="server">
            <h2>Enter the id of the course</h2><br /><br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="View Information" OnClick="courseInfo" /><br />
            
        </div>
       
    </form>
</body>
</html>
