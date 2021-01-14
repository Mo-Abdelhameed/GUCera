<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegister.aspx.cs" Inherits="GUCera.StudentRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="SRegister" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please enter your information"></asp:Label> <br /><br />

            First name: <br />
            <asp:TextBox ID="firstname" runat="server"></asp:TextBox> <br /><br />

            Last name: <br />
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox> <br /> <br />

            Email: <br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox> <br /><br />

           Password: <br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox> <br /><br />

            Address: <br />
            <asp:TextBox ID="address" runat="server"></asp:TextBox> <br /><br />
            
            Gender: <br />
           
            <br /> 

            <asp:DropDownList ID="DropDownList1" runat="server" >
                <asp:ListItem Value="2">Select gender</asp:ListItem>
                <asp:ListItem Value="0">Male</asp:ListItem>
                <asp:ListItem Value="1">Female</asp:ListItem>
            </asp:DropDownList> <br/><br />

            <asp:Button ID="register" runat="server" Text="Register" OnClick="studentRegister" />
        </div>
    </form>
</body>
</html>
