﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choosepass.aspx.cs" Inherits="online_library.project.cpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="orange">
    <form id="form1" runat="server">
       <table align="center" >
            <tr>
                <th>
                    Online Library Management System
                </th>
            </tr>
        </table>
        <br />
        <br />

        <table align="center" height="300px">
   
            <tr>
            <td>
               Choose Password
            </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="249px"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td>
               Confirm Password
            </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="252px"></asp:TextBox>
                </td>
            </tr>
            </table>
          <table align="center" class="auto-style1">
            <tr>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
                </td>
                <td align="center">
                    <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
