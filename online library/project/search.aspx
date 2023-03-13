<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="online_library.project.search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
<td align ="center"><font size="6">Search</font></td>
</tr>
</table>
<br>
<table align="center"  cellspacing="40" bgcolor="black" width="500px" style="color:white;border-radius:25px">
<tr>
<td><img src="searchid.jpg"</td>
<td  align ="left">
    <asp:Button ID="Button1" runat="server" Text="Search student id" OnClick="Button1_Click" />
</td>
</tr>/
<tr>
<td><img src="searchbook.png"</td>
<td  align ="left">
    <asp:Button ID="Button2" runat="server" Text="Search book id" OnClick="Button2_Click" /></td>
</tr>
<tr>
<td><img src="searchstudent.png"</td>
<td  align ="left">
    <asp:Button ID="Button3" runat="server" Text="Search Student record" OnClick="Button3_Click" />
</td>
</tr>
</table>
<table align="center" bgcolor="black" style="color:white;width:100px;border:1px solid white;border-radius:25px"">
<tr>
<td  align ="center">
    <asp:Button ID="Button4" runat="server" Text="Cancel" OnClick="Button4_Click" />
</td>
</tr>
</table>
<br>
<br>
    </form>
</body>
</html>
