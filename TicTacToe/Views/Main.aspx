<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="TicTacToe.Views.Main" %>
<%@ Register TagPrefix="ttt" Namespace="TicTacToe.Controls" Assembly="TicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Styles/Style.css" type="text/css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="split">
            <ttt:BoardTile id="tile" runat="server" />
            <ttt:BoardTile ID="tile2" runat="server" Team="X" />
        </div>
        
    </div>
    </form>
</body>
</html>
