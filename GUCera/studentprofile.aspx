<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentprofile.aspx.cs" Inherits="GUCera.studentprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Student profile</title>
    <style>
       h1{
            text-align:center; 
            color:antiquewhite;
            font: italic 8em "Fira Sans", serif;
        
        }

        .info{
            font-size: x-large;     
        }

        #b{
           margin: 5px;
        }
        #c{margin:5px}
         
         body{
            background-color: black;
        }

        .center {
                margin: 0;
                 position: absolute;
                 top: 50%;
                 left: 50%;
                -ms-transform: translate(-50%, -50%);
                transform: translate(-50%, -50%);
        }

        div{
            color: antiquewhite
        }
        .button{
            width: 160px;
            margin:10px
        }

    </style>
</head>
<body>
    <h1>Student Profile</h1>
    <div class="info center">
        <div id="sid" runat="server"></div><br />
        <div id="sname" runat="server"></div><br />
        <div id="smail" runat="server"></div><br />
        <div id="saddress" runat="server"></div><br />
        <div id="sgender" runat="server"></div><br />
   <form id="form1" runat="server">
    <div id="b">
        <asp:Button CssClass="button" ID="availablecourses" runat="server" Text="Availabe Courses" OnClick="availableCourses"/>
        <asp:Button CssClass="button" ID="creditcard" runat="server" Text="Add Credit Card" OnClick="creditCard" />
        <asp:Button CssClass="button" ID="promocode" runat="server" Text="View Promocodes" OnClick="promoCode" />
        <asp:Button CssClass="button" ID="courseInfo" runat="server" Text="View course information" OnClick="courseinfo" />
        <asp:Button CssClass="button" ID="mobile" runat="server" Text="Add mobile" OnClick="addMobile" />
        
    </div>
    <div id="c">
        <asp:Button CssClass="button" ID="cont" runat="server" Text="View assignment content" OnClick="viewContent"/>
        <asp:Button CssClass="button" ID="assign" runat="server" Text="Submit assignmengt" OnClick="submitAssign"/>
        <asp:Button CssClass="button" ID="grad" runat="server" Text="View grade" OnClick="grade" />
        <asp:Button CssClass="button" ID="comm" runat="server" Text="Add course feedback" OnClick="comment" />
        <asp:Button CssClass="button" ID="cert" runat="server" Text="View Certificates" OnClick="listCertificate" />
    </div>
    </form>
    </div>
    
    
   
</body>
</html>
