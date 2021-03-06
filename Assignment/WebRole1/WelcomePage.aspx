﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="WebRole1.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
            width: 100%;
        }
        .auto-style8 {
            height: 23px;
        }
        .auto-style9 {
            width: 170px;
        }
        .auto-style10 {
            width: 170px;
            height: 23px;
        }
        .auto-style11 {
            width: 156px;
        }
        .auto-style12 {
            width: 156px;
            height: 23px;
        }
        .auto-style15 {
            width: 170px;
            height: 26px;
        }
        .auto-style16 {
            width: 156px;
            height: 26px;
        }
        .auto-style18 {
            height: 26px;
        }
        .auto-style19 {
            width: 148px;
        }
        .auto-style20 {
            width: 148px;
            height: 26px;
        }
        .auto-style21 {
            width: 148px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style5">
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style19">
                        <asp:Label ID="Label1" runat="server" Text="Newspaper Application"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style19"></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        </td>
                    <td class="auto-style16">
                        <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
                    </td>
                    <td class="auto-style20"></td>
                    <td class="auto-style18">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style18">
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style19">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
                    </td>
                    <td class="auto-style19">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="Label5" runat="server" Text="Country of Delivery"></asp:Label>
                    </td>
                    <td class="auto-style19">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style12">
                        <asp:Label ID="Label6" runat="server" Text="Search"></asp:Label>
                    </td>
                    <td class="auto-style21"></td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style12">
                        <asp:Button ID="Button1" runat="server" Text="Next" Width="144px" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="Button2" runat="server" Text="Previous" Width="126px" OnClick="Button2_Click" />
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style12">
                        <asp:Button ID="Button3" runat="server" Text="Insert" Width="144px" OnClick="Button3_Click" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" Width="123px" />
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style12">
                        <asp:Button ID="Button5" runat="server" Text="Update" Width="143px" OnClick="Button5_Click" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="Button6" runat="server" Text="Search" Width="123px" OnClick="Button6_Click" />
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style12">
                        <asp:Button ID="Button7" runat="server" Text="Close" Width="143px" OnClick="Button7_Click" />
                    </td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style21">
                        <asp:Label ID="Label7" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
