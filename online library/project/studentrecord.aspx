<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentrecord.aspx.cs" Inherits="online_library.project.studentrecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <style type="text/css">
        .auto-style1 {
            margin-left: 429px;
            margin-top: 0px;
        }
        .auto-style2 {
            margin-left: 534px;
            margin-top: 23px;
        }
        .auto-style3 {
            margin-left: 14px;
            margin-top: 0px;
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
<td align ="center"><font size="6"> Student Record</font></td>
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
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td align ="left">Student_Name</td>
<td  align ="left">
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
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
        <asp:Image ID="Image1" runat="server" CssClass="auto-style2" Visible="False" Width="92px" />
        &nbsp;<asp:Label ID="Label1" runat="server" BackColor="Black" ForeColor="White" Text="Label" Visible="False" Width="114px" CssClass="auto-style3" Height="16px"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="Black" CssClass="auto-style1" ForeColor="White" Width="455px" HorizontalAlign="Center">
        </asp:GridView>
            <br><b>
        <br />
        <br />
    </form>
</body>
</html>
