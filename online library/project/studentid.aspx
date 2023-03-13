<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentid.aspx.cs" Inherits="online_library.project.studentid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 438px;
            margin-top: 39px;
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
<td align ="center"><font size="6">Search Student ID</font></td>
</tr>
</table>
<br>
<table align="center"  cellspacing="40" bgcolor="black" style="color:white;border-radius:25px">
<tr>
<th colspan="3" align ="center">Enter Student detail</th>
</tr>
<tr>
<td align ="left">Student_Name</td>
<td  align ="left">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
    </tr>
<tr>
<td align="right">
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
</td>
<td align="center">
    <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
</td>
</tr>
</table>
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1" Width="448px" BackColor="Black" ForeColor="White"  Visible="False">
        </asp:GridView>
    </form>
</body>
</html>
