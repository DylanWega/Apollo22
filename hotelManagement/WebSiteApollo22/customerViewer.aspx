<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerViewer.aspx.cs" Inherits="customerViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css" type="text/css">
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
            width: 453px;
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
            width: 453px;
            height: 67px;
        }
        .auto-style17 {
            width: 453px;
            height: 79px;
            text-align: center;
        }
    </style>
</head>
<body style="width: 963px; height: 392px; background-color:rgb(0, 45, 80)">
    
    <form id="form1" runat="server">
        <nav class="navbar">
        <img src="img/Apollo 22 white.png" class="logo">
    <ul>
        <li> <a class="active" href="main.aspx">Home</a></li>
        <li> <a href="#">Rooms</a></li>
        <li> <a href="#">About us</a> </li>
    </ul>

    <ul style="float: right;">
        <asp:Button ID="Button1" runat="server" OnClick="logOutBtn_Click" Text="Log out" CssClass="btn2" />
    </ul>

    
    </nav>
        <table class="auto-style15">
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style16"></td>
            <td class="auto-style12">
                
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style17">
                <asp:Label ID="Label1" runat="server" Text="Account created successfully. Welcome to the future" ForeColor="White" Font-Names="century gothic" Font-Size="XX-Large"></asp:Label>
            </td>
            <td class="auto-style13"></td>
        </tr>
             <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style14"></td>
        </tr>
        </table>
        
    </form>
</body>
</html>
