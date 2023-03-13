<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usd.aspx.cs" Inherits="online_library.project.usd" %>

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
<td align ="center"><font size="6">Update</font></td>
</tr>
</table>
<br>
<table align="center"  cellspacing="40" bgcolor="black" style="color:white;border-radius:25px">
<tr>
<th colspan="3" align ="center">Enter Student Detail</th>
</tr>
<tr>
<td align ="left">Student_id</td>
<td  align ="left">
    <asp:TextBox ID="TextBox1" runat="server" style="border-radius:25px" Width="96px"  ForeColor="Black"  /></asp:TextBox></td>
    <td>
        <asp:Button ID="Button3" runat="server" Text="Search" Width="78px" OnClick="Button3_Click" />
    </td>
</tr>
<tr>
<td align ="left">Student_Name</td>
<td  align ="left">
    <asp:TextBox ID="TextBox2" runat="server" style="border-radius:25px" Width="96px" ForeColor="White" /></asp:TextBox>
    
<td rowspan="2" class="auto-style4">
    <asp:Image ID="Image1" runat="server" Height="88px" Width="85px" />
</td>
    <td>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </td>
</td>
</tr>
<tr>
<td align ="left">Father_Name</td>
<td  align ="left">
    <asp:TextBox ID="TextBox3" runat="server" style="border-radius:25px" Width="96px" /></asp:TextBox>
</td>
    <td>
        <asp:Button ID="Button4" runat="server" Text="upload" Width="218px" OnClick="Button4_Click" />
    </td>
</tr>
<tr>
<td align ="left">Class</td>
<td  align ="left">
    <asp:TextBox ID="TextBox4" runat="server" style="border-radius:25px" Width="96px" /></asp:TextBox>
</td>
</tr>
<tr>
<td align ="left">Mobile.No</td>
<td  align ="left">
    <asp:TextBox ID="TextBox5" runat="server" style="border-radius:25px" Width="96px" MaxLength="10" TextMode="Number" /></asp:TextBox>
</td>
</tr>
</table>
<table align="center" cellspacing="40" bgcolor="black" style="color:white;width:700px; border:2px solid white;border-radius:25px">
<tr>
<td align ="Right">
    <asp:Button ID="Button1" runat="server" Text="Update" style="border-radius:25px" Width="96px" OnClick="Button1_Click"  /></td>
<td align ="left">
    <asp:Button ID="Button2" runat="server" Text="Cancel"  style="border-radius:25px" Width="96px" OnClick="Button2_Click" /></td>
</tr>
</table>
    </form>
</body>
</html>
