<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerListForm.aspx.cs" Inherits="customerListForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css" type="text/css">
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
        .auto-style12 {
            width: 296px;
            height: 90px;
            text-align: right;
        }
        .auto-style13 {
            width: 279px;
            height: 90px;
            text-align: center;
        }
        .auto-style14 {
            text-align: center;
        }
    </style>
</head>
<body style="width: 963px; height: 392px; background-color:rgb(0, 39, 100)">
    <form id="form1" runat="server">
                <div class="auto-style14">
                <asp:Label ID="Label16" runat="server" Text="Admin Dashboard" ForeColor="White" Font-Names="century gothic" Font-Size="XX-Large"></asp:Label>
        <table class="auto-style15">
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style5">
                <asp:TextBox ID="txtFilter" runat="server" Width="266px"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:Button ID="searchBtn" runat="server" OnClick="searchBtn_Click" Text="Search" CssClass="btn2" />
            </td>
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
                <asp:Button ID="addBtn" runat="server" Text="Add" OnClick="addBtn_Click" CssClass="btn2"/>
                 </td>
            <td class="auto-style5">
                <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" CssClass="btn2" />
                 </td>
            <td class="auto-style6">
                <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click" CssClass="btn2" />
                 </td>                 
        </tr>
             <tr>
            <td class="auto-style12">
                 &nbsp;</td>
            <td class="auto-style13">
                 <asp:Label ID="lblError" runat="server" Text="."></asp:Label>
                 <asp:Button ID="displayAllBtn" runat="server" Text="Display All" CssClass="btn2" />
                 </td>
            <td class="auto-style6">
                 </td>                 
        </tr>
        </table>

                </div>

    </form>
</body>
</html>
