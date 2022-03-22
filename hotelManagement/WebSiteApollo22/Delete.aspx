<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        Are you sure you want to delete this customer ?<br />
        <br />
        <asp:Button ID="yesBtn" runat="server" OnClick="yesBtn_Click" Text="Yes" Width="80px" />
&nbsp;&nbsp;
        <asp:Button ID="noBtn" runat="server" OnClick="noBtn_Click" Text="No" Width="69px" />
       
    </form>
</body>
</html>
