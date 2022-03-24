<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css" type="text/css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>home</title>
    <style type="text/css">
        .auto-style1 {
            float: right;
            background-color: transparent;
            color: white;
            text-align: center;
            border: 1px solid white;
            margin-top: 25px;
            margin-right: 15px;
            margin-left: 40px;
            font-family: 'century gothic';
            cursor: pointer;
            border-radius: 12px;
            padding: 7px 10px;
        }
    </style>
</head>
    <!--The title/navigation bar-->
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        <nav class="navbar">
        <img src="img/Apollo 22 white.png" class="logo">
    <ul>
        <li> <a class="active" href="main.aspx">Home</a></li>
        <li> <a href="#">Rooms</a></li>
        <li> <a href="#">About us</a> </li>
    </ul>

    <ul style="float: right;">
        <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="signupBtn_Click" CssClass="btn2" />
    </ul>

    
    </nav>
        <!--The title/navigation bar ENDS-->

<!--Banner/Header STARTS--> 
        <div class="banner">
    <img src="img/Apollo 22 white.png" class="logo2">
    <h1>Rooms & Suits on the Moon</h1> <br>
    <asp:Button ID="Button2" runat="server" Text="Book now" CssClass="btn2"/>   
</div>
            
    </form>
</body>
</html>
