<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addstudent.aspx.cs" Inherits="online_library.project.addstudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 403px;
        }
        .auto-style2 {
            width: 91px;
        }
        .auto-style3 {
            width: 104px;
        }
        .auto-style4 {
            width: 42px;
        }
        .auto-style5 {
            margin-left: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <table align="center" bgcolor="black" style="color:white;width:1345px;border:1px solid white;height:150px;border-radius:25px">
<tr>
<td align ="center"><font size="6">Online Library Management System</font></td>
</tr>
</table>
<br>
<br>
<table align="center" bgcolor="black" style="color:white;width:805px;border:1px solid white;border-radius:25px"">
<tr>
<td align ="center"><font size="6">Add Student</font></td>
</tr>
</table>
<br>
<table align="center"  cellspacing="40"  bgcolor="black" style="color:white;border-radius:25px" class="auto-style1">
<tr>
<th colspan="3" align ="right"><font size="4">Enter Student Detail</font></th>
</tr>
<tr>
<td align ="left" class="auto-style2">Student_id</td>
<td  align ="left" class="auto-style3">
    <asp:TextBox ID="TextBox1" runat="server" style="border-radius:25px" Width="96px" Enabled="False" ForeColor="White"  /></asp:TextBox></td>
<td rowspan="2" class="auto-style4">
    <asp:Image ID="Image1" runat="server" Height="88px" Width="85px" />
</td>
    <td>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </td>
</tr>

<tr>
<td align ="left" class="auto-style2">Student_Name</td>
<td  align ="left" class="auto-style3">
    <asp:TextBox ID="TextBox2" runat="server" style="border-radius:25px" Width="96px" /></asp:TextBox>
</td>
     <td>
        <asp:Button ID="Button3" runat="server" Text="Upload" Width="216px" CssClass="auto-style5" OnClick="Button3_Click" />
    </td>
</tr>
<tr>
<td align ="left" class="auto-style2">Father_Name</td>
<td  align ="left" class="auto-style3">
    <asp:TextBox ID="TextBox3" runat="server" style="border-radius:25px" Width="96px" /></asp:TextBox>
</td>
</tr>
<tr>
<td align ="left" class="auto-style2">Class</td>
<td  align ="left" class="auto-style3">
    <asp:TextBox ID="TextBox4" runat="server" style="border-radius:25px" Width="96px" /></asp:TextBox>
</td>
</tr>
<tr>
<td align ="left" class="auto-style2">Mobile.No</td>
<td  align ="left" class="auto-style3">
    <asp:TextBox ID="TextBox5" runat="server" style="border-radius:25px" Width="96px" MaxLength="10" TextMode="Number" /></asp:TextBox>
</td>
</tr>
</table>
<table align="center" cellspacing="40" bgcolor="black" style="color:white;width:750px; border:2px solid white;border-radius:25px">
<tr>
<td align ="Right">
    <asp:Button ID="Button1" runat="server" Text="Add" style="border-radius:25px" Width="96px" OnClick="Button1_Click"  /></td>
<td align ="left">
    <asp:Button ID="Button2" runat="server" Text="Cancel"  style="border-radius:25px" Width="96px" OnClick="Button2_Click" /></td>
</tr>
</table>
       
    </form>
</body>
</html>
