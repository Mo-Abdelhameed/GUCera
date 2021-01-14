<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
        }
        h1{
            text-align:center; 
            color:antiquewhite;
            font: italic 8em "Fira Sans", serif;
        }
        .button {
            background: none!important;
            border: none;
            padding: 0!important;
            /*optional*/
            font-family: arial, sans-serif;
            /*input has OS specific font-family*/
            color: antiquewhite;
            cursor: pointer;
            color:antiquewhite;  font: italic 1em "Fira Sans", serif;
            margin:20px;
            color: blue;
            
        }
       

    </style>
</head>
<body>
    <h1>GUCera</h1>
    <form class="center" id="form1" runat="server">
        
        <div>
            <h2>Please login:</h2> <br /> <br />

            Username:<br />
            
                 <asp:TextBox ID="username" runat="server"></asp:TextBox> 
                 <br />
            
            Password:<br />
            
                <asp:TextBox ID="password" TextMode="Password" runat="server"></asp:TextBox>
                <br /> <br />
            
            <asp:Button  ID="signin" runat="server" Text="Login" OnClick="login" /><br />
            
            <span id="span1" runat="server" style="color: red; display: none">*Invalid Username or Password</span>
             <asp:Button CssClass="button" ID="register" runat="server" Text="I don't have an account" onclick="register1"/>

        </div>
        
       
    </form>
   
        </body>
</html>
