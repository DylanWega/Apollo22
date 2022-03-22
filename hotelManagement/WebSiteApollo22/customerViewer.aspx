<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerViewer.aspx.cs" Inherits="customerViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 221px;
            height: 67px;
        }
        .auto-style7 {
            width: 221px;
            height: 79px;
        }
        .auto-style10 {
            width: 221px;
            height: 99px;
        }
        .auto-style11 {
            width: 443px;
            height: 99px;
            text-align: center;
            font-size: x-large;
        }
        .auto-style12 {
            width: 204px;
            height: 67px;
        }
        .auto-style13 {
            width: 204px;
            height: 79px;
        }
        .auto-style14 {
            width: 204px;
            height: 99px;
        }
        .auto-style15 {
            width: 1145px;
            height: 716px;
        }
        .auto-style16 {
            width: 443px;
            height: 67px;
        }
        .auto-style17 {
            width: 443px;
            height: 79px;
            text-align: center;
        }
    </style>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        <table class="auto-style15">
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style16"></td>
            <td class="auto-style12">
                <asp:Button ID="logOutBtn" runat="server" OnClick="logOutBtn_Click" Text="Log out" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style17">
                <asp:Image ID="Image1" runat="server" Height="155px" ImageUrl="~/img/Apollo 22 blue.png" Width="259px" />
            </td>
            <td class="auto-style13"></td>
        </tr>
             <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">Account created successfully<br />
                Welcome to Apollo22</td>
            <td class="auto-style14"></td>
        </tr>
        </table>
    </form>
</body>
</html>
