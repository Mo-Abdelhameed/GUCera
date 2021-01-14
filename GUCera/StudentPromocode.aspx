<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPromocode.aspx.cs" Inherits="GUCera.StudentPromocode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Promocodes</title>
    <style>
         h1{
            text-align:center; 
            color:antiquewhite;
            font: italic 4em "Fira Sans", serif;
        
        }
        body {
            background-color: black;
        }
        form{color:antiquewhite; font-size:1.5em; }
        #div1{display:flex; flex-wrap: wrap; justify-content:flex-start; }
        .code {
            margin:30px
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1" runat="server">
        </div>
    </form>
    
</body>
</html>
