<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GUCera.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    

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
            color: antiquewhite
        }
        h1{
            text-align:center; 
            color:antiquewhite;
            font: italic 8em "Fira Sans", serif;
            margin:5px;
        }
        span{
            color:red;
            font-size: 1em;
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
    <h1>Registration</h1>

    <form class="center" id="register" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please enter your information"></asp:Label> <br /><br />

            First name: <br />
            <asp:TextBox ID="firstname" runat="server"></asp:TextBox> <br /><br />

            Last name: <br />
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox> <br /> <br />

            Email: <br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox> <br /><br />

           Password: <br />
            <asp:TextBox TextMode="Password" ID="password" runat="server"></asp:TextBox> <br /><br />

            Address: <br />
            <asp:TextBox ID="address" runat="server"></asp:TextBox> <br /><br />
            
            Gender: <br />
           
            <br /> 

            <asp:DropDownList ID="DropDownList1" runat="server" >
                <asp:ListItem Value="2">Select gender</asp:ListItem>
                <asp:ListItem Value="0">Male</asp:ListItem>
                <asp:ListItem Value="1">Female</asp:ListItem>
            </asp:DropDownList> <br/><br />

            <asp:Button ID="student" runat="server" Text="Register as student" OnClick="studentRegister" /><br /><br />
            <asp:Button ID="instructor" runat="server" Text="Register as instructor" OnClick="instructorRegister" /><br /><br />
            <span id="info" runat="server"></span><br /><br />
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Back to login page" OnClick="login" /><br /><br />

        </div>
       
    </form>
</body>
</html>
