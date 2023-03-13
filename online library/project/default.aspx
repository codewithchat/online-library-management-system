  <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="online_library.project._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 
    <style type="text/css">
     
        .i{
         height:15px;
border-radius:25px;
        }
        .b
        {
           width:80px;
        background-color: skyblue;
        }
        .auto-style1 {
            height: 48px;
        }
        .auto-style2 {
            border-radius: 25px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
    </style>
    </head>
<body background="bg.jpg">
    <form id="form1" runat="server">
     
      <table align="center" style="height:100px;">
<tr>
<th><font color="white" size="5"><u>Online Library Management System</u></font></th>
   </tr>
</table>
      <br />    
<table align="right" cellspacing="10">
    <tr>
        <td>
            <asp:Button ID="Button3" runat="server" Text="Reset Password" CssClass="auto-style3" OnClick="Button3_Click" />

        </td>
        <td>
            <asp:Button ID="Button4" runat="server" Text="Change Password" OnClick="Button4_Click" />
        </td>
    </tr>
</table>     
      <br />
        <br />
        <br />
        <br />
<table align="center"  style="border-color:white;border-radius:25px;border:1px solid white;;" cellspacing="25" width="300px">
<tr align="center">
<td colspan="3" class="auto-style1"><img src="logo.png" style="width:100px; border-radius:25px;"></td>
</tr>
<tr align="center">
<td colspan="3"><font color="white" size="5">Admin login</font></td>
</tr>
<tr>
<td colspan="3"><font color="white" size="5">Username</font></td>
</tr>
<tr>
<td colspan="2" class="auto-style1">
    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2" Width="200px"></asp:TextBox>
</td>
</tr>
<tr>
<td colspan="3"><font color="white" size="5">Password</font></td>
</tr>
<tr>
<td colspan="2">
    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" TextMode="Password" Width="200px"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Login" CssClass="b" OnClick="Button1_Click" />
</td>
<td>
    <asp:Button ID="Button2" runat="server" Text="Cancel" class="b" OnClick="Button2_Click"/>
</td>
    </tr>
</table>
       <br /></br><br /><br /></br><br /><br />
        <br />
        <br />
        <br />
    </form>

</body>
</html>
