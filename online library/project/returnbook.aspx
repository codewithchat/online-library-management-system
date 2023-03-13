<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="returnbook.aspx.cs" Inherits="online_library.project.returnbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<body>
    
    <form id="form2" runat="server">
        <table align="center" bgcolor="black" style="color:white;width:1345px;border:1px solid white;height:150px;border-radius:25px">
<tr>
<td align ="center"><font size="6">Online Library Management System</font></td>
</tr>
</table>
<br>
<br>
<table align="center" bgcolor="black" style="color:white;width:870px;border:1px solid white;border-radius:25px"">
<tr>
<td align ="center"><font size="6">Return Book</font></td>
</tr>
</table>
<br>
<table align="center"  cellspacing="40" bgcolor="black" style="color:white;border-radius:25px">
<tr>
<th colspan="3" align ="center">Enter Book Detail</th>
<th colspan="3" align ="center">Enter Student Detail</th>
</tr>
<tr>
<td align ="left">BooK_id</td>
<td  align ="left">
    <asp:TextBox ID="TextBox1" runat="server" style="border-radius:25px" Width="96px"></asp:TextBox>
</td>
<td align ="left">
    <asp:Button ID="Button1" runat="server" Text="Search" style="border-radius:25px" Width="96px" OnClick="Button1_Click" />
</td>
<td align ="left">Student_id</td>
<td align ="left">
    <asp:TextBox ID="TextBox2" runat="server" style="border-radius:25px" Width="96px"></asp:TextBox>
</td>
<td  align ="left">
    <asp:Button ID="Button4" runat="server" Text="Search"  style="border-radius:25px" Width="96px" OnClick="Button4_Click"  />
</td>
</tr>
<tr>
<td align ="left">BooK_Name</td>
<td  align ="left">
    <asp:TextBox ID="TextBox3" runat="server" style="border-radius:25px" Width="96px"></asp:TextBox>
</td>
<td>
</td>
<td align ="left">Student_Name</td>
<td align ="left">
    <asp:TextBox ID="TextBox4" runat="server" style="border-radius:25px" Width="96px"></asp:TextBox>
</td>
</tr>
</tr>
<tr>
<td align ="left">Publisher</td>
<td  align ="left">
    <asp:TextBox ID="TextBox5" runat="server" style="border-radius:25px" Width="96px"></asp:TextBox>
</td>
<td>
</td>
<td align ="left">Class</td>
<td align ="left">
    <asp:TextBox ID="TextBox6" runat="server" style="border-radius:25px" Width="96px"></asp:TextBox>
</td>
</tr>
<tr>
<td align ="left">Writer</td>
<td  align ="left">
    <asp:TextBox ID="TextBox7" runat="server" style="border-radius:25px" Width="96px"></asp:TextBox>
</td>
</tr>
</table>
<table align="center" cellspacing="40" bgcolor="black" style="color:white;width:865px; border:2px solid white;border-radius:25px">
<tr >
<td align ="right">Date of Return</td>
<td align ="left">
    <asp:TextBox ID="TextBox8" runat="server" style="border-radius:25px" Width="96px" TextMode="Date"></asp:TextBox>
</td>
</tr>
<tr>
<td align ="Right">
    <asp:Button ID="Button2" runat="server" Text="Return" style="border-radius:25px" Width="96px" OnClick="Button2_Click"/></td>
<td align ="left">
    <asp:Button ID="Button3" runat="server" Text="Cancel" style="border-radius:25px" Width="96px" OnClick="Button3_Click"/></td>
</tr>
</table>
    </form>
</body>
</html>
