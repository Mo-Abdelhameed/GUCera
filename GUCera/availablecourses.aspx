<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="availablecourses.aspx.cs" Inherits="GUCera.availablecourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Available courses</title>
    <style>
        
        h1{color:antiquewhite;  font: italic 6em "Fira Sans", serif;}
        h3 {
            color:antiquewhite;  font: italic 4em "Fira Sans", serif;
        }
        body {
            background-color:black;
        }
        span{margin: 30px;}

        .button {
            background: none!important;
            border: none;
            padding: 0!important;
            /*optional*/
            font-family: arial, sans-serif;
            /*input has OS specific font-family*/
            color: #069;
           
            cursor: pointer;
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
            color:antiquewhite;  font: italic 2.5em "Fira Sans", serif;
            margin:20px;
            
        }

        form{
            display:flex;
            flex-wrap:wrap;
            justify-content:flex-start;
            
        }
        


    </style>

</head>
<body>
    <h1 id="head" style="text-align:center" runat="server">Available Courses</h1>
    <h3>Press on the course to enroll</h3>
    <form id="form1" runat="server">

    </form>
    <div id="div1" runat="server">
        
    </div>
    


</body>
</html>
