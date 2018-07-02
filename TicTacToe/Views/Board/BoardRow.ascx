<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BoardRow.ascx.cs" Inherits="TicTacToe.Views.BoardRow" %>
<%@ Register TagPrefix="uc" TagName="BoardSpace" Src="~/Views/Board/BoardSpace.ascx" %>

<div id="divRow" class="boardRow" >
    <uc:BoardSpace runat="server" ID="BoardSpace0" />
    <uc:BoardSpace runat="server" ID="BoardSpace1" />
    <uc:BoardSpace runat="server" ID="BoardSpace2" />
</div>
