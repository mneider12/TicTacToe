<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Board.ascx.cs" Inherits="TicTacToe.Views.Board" %>
<%@Register TagPrefix="uc" TagName="BoardRow" Src="~/Views/Board/BoardRow.ascx" %>

<uc:BoardRow runat="server" ID="BoardRow0" />
<uc:BoardRow runat="server" ID="BoardRow1" />
<uc:BoardRow runat="server" ID="BoardRow2" />