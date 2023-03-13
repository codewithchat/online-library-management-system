<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="online_library.project.update" %>

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
<table align="center" bgcolor="black" style="color:white;width:805px;border:1px solid white;border-radius:25px">
<tr>
<td align ="center"><font size="6"> Update</font></td>
</tr>
</table>
        <br /><br />
        <table  align="center" bgcolor="black" style="color:white;width:300px;border:1px solid white;border-radius:25px;height:300px">
            <tr>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" Text="Update Student Detail" Width="169px" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Button2" runat="server" Text="Update Book Detail" Width="169px" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Button3" runat="server" Text="Cancel" Width="169px" OnClick="Button3_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
