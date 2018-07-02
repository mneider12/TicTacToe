<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="TicTacToe.Views.Main" %>
<%@ Register TagPrefix="uc" TagName="Board" Src="~/Views/Board/Board.ascx" %>

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
            <uc:Board id="board" runat="server" />
        </div>
        
    </div>
    </form>
</body>
</html>
