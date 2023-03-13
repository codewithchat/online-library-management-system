<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deletebook.aspx.cs" Inherits="online_library.project.deletebook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 66px;
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
<td align ="center"><font size="6">Delete Book</font></td>
</tr>
</table>
<br>
<table align="center"  cellspacing="40" bgcolor="black" style="color:white;border-radius:25px">
<tr>
<th colspan="3" align ="center">Enter Book Detail</th>
</tr>
<tr>
<td align ="center">BooK_id</td>
<td  align ="right" class="auto-style1">
    <asp:TextBox ID="TextBox1" runat="server" style="border-radius:25px" Width="96px"></asp:TextBox>
</td>
<td align ="center">
    <asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
</td>
</tr>
<tr>
<td align ="center">BooK_Name</td>
<td  align ="right" class="auto-style1">
    <asp:TextBox ID="TextBox2" runat="server" style="border-radius:25px" Width="96px" Enabled="False" ForeColor="White"></asp:TextBox>
</td>
</tr>
<tr>
<td align ="center">Publisher</td>
<td  align ="right" class="auto-style1">
    <asp:TextBox ID="TextBox3" runat="server" style="border-radius:25px" Width="96px" Enabled="False" ForeColor="White"></asp:TextBox>
</td>
</tr>
<tr>
<td align ="center">Edition</td>
<td  align ="right" class="auto-style1">
    <asp:TextBox ID="TextBox4" runat="server" style="border-radius:25px" Width="96px" Enabled="False" ForeColor="White"></asp:TextBox>
</td>
</tr>
<tr>
<td align ="center">Writer</td>
<td  align ="right" class="auto-style1">
    <asp:TextBox ID="TextBox5" runat="server" style="border-radius:25px;" Width="96px" Enabled="False" ForeColor="White"></asp:TextBox>
</td>
</tr>
</table>
<table align="center" cellspacing="40px" cellpadding="0px" bgcolor="black" style="color:white;width:410px; border:2px solid white;border-radius:25px">
<tr>
<td align="right" >
    <asp:Button ID="Button1" runat="server" Text="Delete"  style="border-radius:25px" Width="96px" OnClick="Button1_Click"/></td>
<td align="left">
    <asp:Button ID="Button3" runat="server" Text="Cancel"  style="border-radius:25px" Width="96px" OnClick="Button3_Click"/></td>
</tr>
</table>
    </form>
</body>
</html>
