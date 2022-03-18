<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerListForm.aspx.cs" Inherits="customerListForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
            width: 279px;
            height: 90px;
        }
        .auto-style6 {
            width: 254px;
            height: 90px;
        }
        .auto-style8 {
            width: 279px;
            height: 213px;
        }
        .auto-style9 {
            width: 254px;
            height: 213px;
        }
        .auto-style10 {
            width: 296px;
            height: 90px;
        }
        .auto-style11 {
            width: 296px;
            height: 213px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style15">
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style5"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style8">
                <asp:ListBox ID="listCustomers" runat="server" Height="167px" Width="255px"></asp:ListBox>
            </td>
            <td class="auto-style9"></td>
        </tr>
             <tr>
            <td class="auto-style10">
                <asp:Button ID="addBtn" runat="server" Text="Add" />
                 </td>
            <td class="auto-style5">
                <asp:Button ID="updateBtn" runat="server" Text="Update" />
                 </td>
            <td class="auto-style6">
                <asp:Button ID="deleteBtn" runat="server" Text="Delete" />
                 </td>
        </tr>
        </table>

    </form>
</body>
</html>
