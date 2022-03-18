<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <link rel="stylesheet" href="style.css" type="text/css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>home</title>
</head>
<!--The title/navigation bar-->
<body>
     <form id="form1" runat="server">
    <nav class="navbar">
        <img src="img/Apollo 22 white.png" class="logo">
    <ul>
        <li> <a class="active" href="home.html">Home</a></li>
        <li> <a href="#">Rooms</a></li>
        <li> <a href="#">About us</a> </li>
    </ul>

    <ul style="float: right;">
        <button class="btn2">Sign Up</button>
    </ul>

    
    </nav>
<!--The title/navigation bar ENDS-->

<!--Banner/Header STARTS--> 
<div class="banner">
    <img src="img/Apollo 22 white.png" class="logo2">
    <h1>Rooms & Suits on the Moon</h1> <br>
    <button>Book now</button>   
</div>
<!--Banner/Header ENDS--> 
    </form>
</body>
</html>
