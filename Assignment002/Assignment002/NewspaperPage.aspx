<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewspaperPage.aspx.cs" Inherits="Assignment002.NewspaperPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 553px;
        }
        .auto-style2 {
            width: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Welcome Page"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Application" Width="120px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
