<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css" type="text/css">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
    </style>
</head>
<body style="width: 963px; height: 392px; background-color:rgb(0, 39, 100)">
    <form id="form1" runat="server">
       
        <div class="auto-style1">
       
        <asp:Label ID="label" runat="server" Text="Are you sure you want to delete this customer ?" ForeColor="White" Font-Names="century gothic" Font-Size="X-Large"> </asp:Label><br />
        <br />
        <asp:Button ID="yesBtn" runat="server" OnClick="yesBtn_Click" Text="Yes" Width="80px" CssClass="btn2" />
&nbsp;&nbsp;
        <asp:Button ID="noBtn" runat="server" OnClick="noBtn_Click" Text="No" Width="69px" CssClass="btn2" />
       
        </div>
       
    </form>
</body>
</html>
