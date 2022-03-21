<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style7 {
            width: 1037px;
            height: 537px;
        }
        .auto-style17 {
            width: 223px;
            height: 31px;
            text-align: center;
        }
        .auto-style18 {
            width: 201px;
            height: 31px;
            text-align: right;
        }
        .auto-style19 {
            width: 220px;
            height: 31px;
        }
        .auto-style20 {
            width: 223px;
            height: 24px;
        }
        .auto-style21 {
            width: 201px;
            height: 24px;
        }
        .auto-style22 {
            width: 220px;
            height: 24px;
        }
        .auto-style23 {
            width: 223px;
            height: 13px;
        }
        .auto-style24 {
            width: 201px;
            height: 13px;
        }
        .auto-style25 {
            width: 220px;
            height: 13px;
        }
    </style>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        <table class="auto-style7">
        <tr>
            <td class="auto-style17">
                <asp:Button ID="signupBtn" runat="server" Text="Sign Up" OnClick="signupBtn_Click" />
            </td>
            <td class="auto-style18">
                <asp:Button ID="bookBtn" runat="server" Text="Book a room" />
            </td>
            <td class="auto-style19"></td>
        </tr>
        <tr>
            <td class="auto-style20"></td>
            <td class="auto-style21">
                <asp:Image ID="Image1" runat="server" Height="212px" ImageUrl="~/img/Apollo 22 blue.png" Width="365px" />
            </td>
            <td class="auto-style22"></td>
        </tr>
             <tr>
            <td class="auto-style23"></td>
            <td class="auto-style24"></td>
            <td class="auto-style25"></td>
        </tr>
        </table>
    </form>
</body>
</html>
