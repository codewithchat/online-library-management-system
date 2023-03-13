<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="finerecord.aspx.cs" Inherits="online_library.project.finerecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 306px;
        }
        .auto-style2 {
            height: 40px;
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
<td align ="center" class="auto-style2"><font size="6">Fine Record</font></td>
</tr>
</table> 
        <br />
        <br />
        <table align="center" bgcolor="black" style="color:white;width:300px;border:1px solid white;height:150px;border-radius:25px">
  <tr>
    <td align="center">
        <asp:Button ID="Button2" runat="server" Text="See Record" OnClick="Button2_Click" Width="84px" />
        </td>

  </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" Text="Cancel" Width="79px" OnClick="Button1_Click" />
                </td>
            </tr>
</table>
<br>

        <br /><br />
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1"  Width="207px" BackColor="Black" ForeColor="White">
        </asp:GridView>
    </form>
</body>
</html>
