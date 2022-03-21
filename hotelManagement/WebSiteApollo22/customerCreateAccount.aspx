<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerCreateAccount.aspx.cs" Inherits="customerCreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style7 {
            width: 280px;
            height: 67px;
        }
        .auto-style8 {
            width: 343px;
            height: 67px;
            text-align: right;
        }
        .auto-style9 {
            width: 311px;
            height: 67px;
        }
        .auto-style10 {
            width: 280px;
            height: 74px;
        }
        .auto-style11 {
            width: 343px;
            height: 74px;
            text-align: right;
        }
        .auto-style12 {
            width: 311px;
            height: 74px;
        }
        .auto-style13 {
            width: 1012px;
            height: 300px;
        }
        .auto-style14 {
            width: 280px;
            height: 61px;
        }
        .auto-style15 {
            width: 343px;
            height: 61px;
        }
        .auto-style16 {
            width: 311px;
            height: 61px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style13">
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15">Create Account</td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            </td>
        </tr>
             <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                 </td>
            <td class="auto-style12">
                <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                 </td>
        </tr>
            <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Label ID="Label3" runat="server" Text="Date of birth"></asp:Label>
                 </td>
            <td class="auto-style12">
                <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                </td>
        </tr>
            <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                 </td>
            <td class="auto-style12">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
        </tr>
            <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Label ID="Label5" runat="server" Text="Phone number" ></asp:Label>
                 </td>
            <td class="auto-style12">
                <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                </td>
        </tr>
            <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Label ID="Errorlbl" runat="server" Text="."></asp:Label>
                </td>
            <td class="auto-style12"></td>
        </tr>
            <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Button ID="createBtn" runat="server" OnClick="createBtn_Click" Text="Create Account" />
                </td>
            <td class="auto-style12">
                <asp:Button ID="backBtn" runat="server" Text="Back" />
                </td>
        </tr>
        </table>
    </form>
</body>
</html>
