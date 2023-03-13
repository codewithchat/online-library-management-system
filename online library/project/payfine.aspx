<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="payfine.aspx.cs" Inherits="online_library.project.payfine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 504px;
        }
        .auto-style3 {
            margin-left: 507px;
        }
        .auto-style4 {
            margin-left: 284px;
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
<td align ="center"><font size="6">Pay Fine</font></td>
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
    <td>
        <asp:Button ID="Button2" runat="server" Text="Cancel" style="height: 26px" Width="69px" OnClick="Button2_Click1" />
    </td>
</tr>
    </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="Black" CssClass="auto-style4" ForeColor="White">
        </asp:GridView>
        </br>
            <asp:Table ID="Table1" runat="server" CssClass="auto-style2" Width="294px" BackColor="Black" CellSpacing="10" ForeColor="White" Visible="False">
                <asp:TableRow>
                    <asp:TableCell>
                        Date
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Status
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    
                </asp:TableRow>
            </asp:Table>
      <br />
        <asp:Button ID="Button4" runat="server" CssClass="auto-style3" Text="Paid" Width="292px" BackColor="Black" ForeColor="White" Height="30px" Visible="False" OnClick="Button4_Click" />
    </form>
</body>
</html>
