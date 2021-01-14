<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorView.aspx.cs" Inherits="GUCera.instructorView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
         body{
            background-color: black;
            background-size: cover;
        }
    
    
        h1 {
            color: white;
            font-size: 90px;
            margin-top: 3%;
            text-align: center;
            font-family: 'Cookie', cursive;
        }
        
        form{
            background: rgba(255, 255, 255);
            margin-left:30%;
            margin-top: 30px;
            margin-right: 30%;
            margin-bottom: 200px;
            box-shadow: 3px 15px 22px 6px rgba(255,255,255);
            

        }
        .auto-style1 {
            margin-left: 125px;
            margin-top: 20px;
            margin-right: 10%;
        }
        .auto-style2 {
            margin-left: 125px;
        }
      
    </style>

</head>
<body>
    <h1> &nbsp;GUCera </h1>
    <div id ="cont">
    <form id="instructor" runat="server">
        

        
        <asp:Button ID="viewFeedBack" runat="server" Text="View Feedback" OnClick ="viewAddedFeedback" CssClass="auto-style1" Width="236px" BackColor="Black" ForeColor="White"/><br  /><br  />
        <asp:Button ID="IssueCertificate" runat="server" Text="IssueCertificate" OnClick="issueCertificate" CssClass="auto-style2" Width="238px" BackColor="Black" ForeColor="White"/><br /> <br />
        <asp:Button ID="addcourse" runat="server" Text="Add a new course" OnClick ="addNewCourse" CssClass="auto-style2" Width="239px" BackColor="Black" ForeColor="White" /> <br  /><br  />
        <asp:Button ID="addAsg" runat="server" Text="Add a new assignment" OnClick ="AddCourseAssignment" CssClass="auto-style2" Width="240px" BackColor="Black" ForeColor="White" /><br  /><br  />
        <asp:Button ID="viewSub" runat="server" Text="View Student Submission" OnClick ="ViewSubmission" CssClass="auto-style2" Width="238px" BackColor="Black" ForeColor="White" /><br  /><br  />
        <asp:Button ID="grade" runat="server" Text="Grade Student Submission " OnClick ="GradeAssignment" CssClass="auto-style2" style="width: 240px" BackColor="Black" ForeColor="White" /><br  /><br  />
        <asp:Button ID="mobile" runat="server" Text="Add mobile number " OnClick ="addMobile" CssClass="auto-style2" style="width: 240px" BackColor="Black" ForeColor="White" /><br  /><br  />
        
        
    </form>
        </div>
</body>
</html>
