<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AED.aspx.cs" Inherits="AED" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Height="40px" style="margin-left: 0px" Text="Rooms Main Page" Width="143px"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        
        <asp:ListBox ID="listbDisplay" runat="server" Height="147px" Width="241px"></asp:ListBox>
        
        <p>
            <asp:Label ID="Label2" runat="server" Text="Please Enter a RoomNo"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="208px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="30px" OnClick="btnAdd_Click" Text="Add" Width="100px" />
            <asp:Button ID="btnUpdate" runat="server" Height="30px" style="margin-left: 48px" Text="Update" Width="100px" />
        </p>
        <p>
            <asp:Button ID="btnDelete" runat="server" Height="30px" style="margin-left: 0px" Text="Delete" Width="100px" />
            <asp:Button ID="btnDisplay" runat="server" Height="30px" style="margin-left: 48px" Text="Display All" Width="100px" />
        </p>
        <p>
            <asp:Button ID="btnBack" runat="server" Height="30px" style="margin-left: 85px" Text="Back" Width="100px" OnClick="btnBack_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
