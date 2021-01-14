<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMobile.aspx.cs" Inherits="GUCera.AddMobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Add mobile number</title>
    <style>

        body{background-color:black}
        form{color:antiquewhite}

        #info{font-size: 1em; color:red}
        h1{
            text-align:center; 
            color:antiquewhite;
            font: italic 8em "Fira Sans", serif;
        
        }
        .center {
                margin: 0;
                 position: absolute;
                 top: 50%;
                 left: 50%;
                -ms-transform: translate(-50%, -50%);
                transform: translate(-50%, -50%);
        }


    </style>
</head>
<body>
    <h1>Add mobile number</h1>
    <form class="center" id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter a mobile number"></asp:Label> <br />  <br />
            <asp:TextBox ID="mobile" runat="server"></asp:TextBox>  <br />  <br />
            <asp:Button ID="add" runat="server" Text="Add mobile number" OnClick="addMobile"/><br /><br />
            <span id="info" runat="server"></span>
        </div>
       
    </form>
</body>
</html>
