<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerFindForm.aspx.cs" Inherits="customerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css" type="text/css">
    <title></title>
    <style type="text/css">
        .auto-style6 {
            height: 87px;
            width: 339px;
        }
        .auto-style7 {
            height: 76px;
            width: 339px;
        }
        .auto-style9 {
            height: 64px;
            width: 339px;
        }
        .auto-style11 {
            height: 72px;
            width: 339px;
        }
        .auto-style13 {
            height: 62px;
            width: 339px;
        }
        .auto-style15 {
            width: 100%;
            height: 363px;
        }
        .auto-style21 {
            height: 76px;
            width: 390px;
        }
        .auto-style22 {
            height: 64px;
            width: 390px;
        }
        .auto-style23 {
            height: 72px;
            width: 390px;
        }
        .auto-style24 {
            height: 62px;
            width: 390px;
        }
        .auto-style25 {
            height: 87px;
            width: 390px;
        }
        .auto-style26 {
            height: 76px;
            width: 370px;
        }
        .auto-style27 {
            height: 64px;
            width: 370px;
        }
        .auto-style28 {
            height: 72px;
            width: 370px;
        }
        .auto-style29 {
            height: 62px;
            width: 370px;
        }
        .auto-style30 {
            height: 87px;
            width: 370px;
        }
    </style>
</head>
<body style="width: 963px; height: 392px; background-color:rgb(0, 39, 100)">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label16" runat="server" Text="Admin Dashboard" ForeColor="White" Font-Names="century gothic" Font-Size="X-Large"></asp:Label>
    <table class="auto-style15">
        <tr>
            <td class="auto-style7"> <asp:Label ID="Label15" runat="server" Text="Customer ID" ForeColor="White" Font-Names="century gothic" Font-Size="X-Large"></asp:Label> </td>
            <td class="auto-style26">
                <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style21">
                <asp:Button ID="findBtn" runat="server" Height="47px" OnClick="findBtn_Click" Text="Find" Width="107px" CssClass="btn2"/>

            </td>
        </tr>
        <tr>
            <td class="auto-style9"> <asp:Label ID="Label14" runat="server" Text="First Name" ForeColor="White" Font-Names="century gothic" Font-Size="X-Large"></asp:Label> </td>
            <td class="auto-style27">
                <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style22"></td>
        </tr>
        <tr>
            <td class="auto-style11"><asp:Label ID="Label13" runat="server" Text="Last Name" ForeColor="White" Font-Names="century gothic" Font-Size="X-Large"></asp:Label></td>
            <td class="auto-style28">
                <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style13"> <asp:Label ID="Label12" runat="server" Text="Email" ForeColor="White" Font-Names="century gothic" Font-Size="X-Large"></asp:Label> </td>
            <td class="auto-style29">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style24"></td>
        </tr>
        <tr>
            <td class="auto-style6"> <asp:Label ID="Label11" runat="server" Text="Phone Number" ForeColor="White" Font-Names="century gothic" Font-Size="X-Large"></asp:Label> </td>
            <td class="auto-style30">
                <asp:TextBox ID="txtPhonenum" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style25"></td>
        </tr>
        <tr>
            <td class="auto-style6"> <asp:Label ID="Label0" runat="server" Text="Date of birth" ForeColor="White" Font-Names="century gothic" Font-Size="X-Large"></asp:Label> </td>
            <td class="auto-style30">
                <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style25"></td>
        </tr>
    </table>
    </form>
    </body>
</html>
