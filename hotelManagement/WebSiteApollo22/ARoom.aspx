<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ARoom.aspx.cs" Inherits="ARoom" %>

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
        <asp:TextBox ID="txtroom" runat="server" style="margin-left: 24px" Width="152px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Type"></asp:Label>
            <asp:TextBox ID="txttype" runat="server" style="margin-left: 49px" Width="150px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtprice" runat="server" style="margin-left: 47px" Width="152px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Decription"></asp:Label>
            <asp:TextBox ID="txtdescription" runat="server" style="margin-left: 17px" Width="142px" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="Label6" runat="server" Text="Availability"></asp:Label>
        <asp:TextBox ID="txtavailability" runat="server" style="margin-left: 14px" Width="143px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Ok" Width="44px" />
        <asp:Button ID="Button2" runat="server" Text="Cancel" style="margin-left: 28px" Width="79px" />
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
