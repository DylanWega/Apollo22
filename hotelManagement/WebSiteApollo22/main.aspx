<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="RoomNo"></asp:Label>
        <asp:TextBox ID="txtroom" runat="server" Height="16px" style="margin-left: 43px" Width="141px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Type"></asp:Label>
            <asp:TextBox ID="txttype" runat="server" Height="16px" style="margin-left: 70px" Width="141px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtdescription" runat="server" Height="16px" style="margin-left: 31px" Width="141px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtprice" runat="server" Height="16px" style="margin-left: 70px" Width="141px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Availability"></asp:Label>
            <asp:TextBox ID="txtavailability" runat="server" Height="16px" style="margin-left: 33px" Width="144px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" style="margin-left: 31px" Text="Back" Width="57px" OnClick="Button2_Click" />
    </form>
</body>
</html>
