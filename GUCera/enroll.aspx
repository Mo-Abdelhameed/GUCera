<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enroll.aspx.cs" Inherits="GUCera.enroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enroll in course</title>
    <style>
        
        h1{
            text-align:center; 
            color:antiquewhite;
            font: italic 8em "Fira Sans", serif;
            margin:1px;
        
        }

        #instructors{
            display:flex;
            flex-wrap:wrap;
            justify-content:flex-start;
        }

        input {
            background: none!important;
            border: none;
            padding: 0!important;
            /*optional*/
            font-family: arial, sans-serif;
            /*input has OS specific font-family*/
            color: antiquewhite;
            cursor: pointer; 
            margin: 10px;

            
        }

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
         form{
             color: antiquewhite;
             font-size:1.5em;
             
         }
        #info {
             color:red;
             font-size: 0.7em;
         }
        #Span1{
            color:red;
            font-size: 0.7em;
        }
        
    </style>

</head>
<body>
    <h1 style="text-align:center">Enroll in the course</h1><br/>
    <form class="center" id="form1" runat="server">
        <div id="div1" runat="server">

            
        </div>
         <asp:Label ID="Label1" runat="server" Text="Select the name of the instructor"></asp:Label><br /><br/>
        <!--<asp:TextBox ID="instId" runat="server"></asp:TextBox><br /><br />-->
        <div id="instructors" runat="server">

        </div>
        <span  id="info" runat="server"></span><br/> <br />

        <asp:Button ID="Button1" runat="server" Text="Enroll" OnClick="enrollInCourse"/><br />

        <span  id="Span1" runat="server"></span><br/> <br />
        
    </form>
</body>
</html>
