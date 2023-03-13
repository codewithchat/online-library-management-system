<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fine.aspx.cs" Inherits="online_library.project.fine" %>

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
<td align ="center"><font size="6">Pay Fine and Fine Record</font></td>
</tr>
</table>
        <br />
        <br />
        <table align="center"  cellspacing="40" bgcolor="black" style="color:white;border-radius:25px">
<tr>
<th colspan="3" align ="center">Choose Option</th>
</tr>
<td  align ="Center">
    <asp:Button ID="Button1" runat="server" Text="Pay Fine" OnClick="Button1_Click" Width="101px" />
</td>
</tr>
<tr>
<td  align ="Center">
    <asp:Button ID="Button2" runat="server" Text="Fine Record"  Width="101px"  OnClick="Button2_Click" />
</td>
</tr>
 <tr>
<td  align ="Center">
 <asp:Button ID="Button3" runat="server" Text="Cancel"  Width="101px" OnClick="Button3_Click" />
</td>
 </tr>
 </table>
    </form>
</body>
</html>
