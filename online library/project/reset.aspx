<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reset.aspx.cs" Inherits="online_library.project.reset1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="lightgreen">
    <form id="form1" runat="server">
        <table align="center">
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
            <th>
           Enter Answer of Security Questions 
            </th>
           </tr>
            <tr>
            <td>
                 What was the first U G course of your college?
            </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="249px"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td>
              What was the first PG course of your college?
            </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="252px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                  <td>
               Enter four digit code
                </td>  
            </tr>
            <tr>
                <td>
<asp:TextBox ID="TextBox3" runat="server" Width="249px" MaxLength="4" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
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
        <br />
        <br />
    </form>
</body>
</html>
