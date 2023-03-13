<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="online_library.project.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 215px;
        }
        .auto-style2 {
            height: 238px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <table bgcolor="black" style="width:1345px;color:white;height:150px;">
<tr>
<td align="center"><font size="6">Welcome to Online Library Management System</font></td>
</tr>
</table>
<br>
<br>
<table cellspacing="20" align="center" cellpadding="5" width="600" style="border:2px solid black;border-radius:25px;">
<tr>
<td align="center">
<img src="addbook.png">
</td>
<td align="center">
<img src="deletebook.png">
</td>
<td align="left">
<img src="issuebook.png">
</td>
</tr>
<tr>
<td align="center">
 <asp:Button ID="Button1" runat="server" Text="Add Book"  style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;"  onclick="Button1_Click"/>
</td>
<td align="center">
    <asp:Button ID="Button2" runat="server" Text="Delete Book"  style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;" OnClick="Button2_Click"/>
</td>
<td align="center">
    <asp:Button ID="Button3" runat="server" Text="Issue Book"  style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;" OnClick="Button3_Click"/>
</td>
</tr>
<tr>
<td align="center">
<img src="return book.png">
</td>
<td align="center">
<img src="addstudent.png">
</td>
<td align="left" >
<img src="deletestudent.png">
</td>
</tr>
<tr>
<td align="center">
    <asp:Button ID="Button4" runat="server" Text="Return Book"  style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;" OnClick="Button4_Click" />
</td>
<td align="center">
    <asp:Button ID="Button5" runat="server" Text="Add Student"  style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;" OnClick="Button5_Click" />
</td>
<td align="center">
    <asp:Button ID="Button6" runat="server" Text="Delete Student"  style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;" OnClick="Button6_Click"/>
</td>
</tr>
<tr>
<td align="center" class="auto-style2">
<img src="fine.jpg" class="auto-style1" />
</td>
    <td align="center" class="auto-style2">
        <img src="search.png">
    </td>
    <td align="left" class="auto-style2">
        <img src="update.jpg" />
    </td>
    </tr>
    <tr>
<td align="center">
    <asp:Button ID="Button10" runat="server" Text="Fine" style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;" OnClick="Button10_Click" />
</td>
        <td align="center">
            <asp:Button ID="Button8" runat="server" Text="Search"  style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;" OnClick="Button8_Click"/>
        </td>
        <td  align="left">
            <asp:Button ID="Button9" runat="server" Text="Update" style="background-color:black;color:white;width:130px;height:26px; border-radius:25px;" OnClick="Button9_Click1"/>
        </td>
</tr>
    <tr>
        <td align="center">
     <img src="logout.png">

        </td>
    </tr>
    <tr>
        <td align="center">
             <asp:Button ID="Button7" runat="server" Text="Logout"  style="background-color:black;color:white;width:130px;height:30px;border-radius:25px;" OnClick="Button7_Click" />
           
        </td>
    </tr>
</table>
<br>
<br>
    </form>
</body>
</html>
