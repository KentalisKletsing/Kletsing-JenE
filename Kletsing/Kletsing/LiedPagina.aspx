<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LiedPagina.aspx.cs" Inherits="Kletsing.LiedPagina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>
        <asp:Label runat="server" ID="lblGekozen_lied"></asp:Label></h3>

    <br />
    <h4>Lesbrief</h4>
    <p>Klik op onderstaande link om de lesbrief te openen</p>
    <a href="#">Lesbrief</a>
    <hr />
    <h4>Geluidsfragment</h4>
    <audio controls>
        <source src="testgeluid.mp3" type="audio/mpeg">
        Your browser does not support the audio element.
    </audio>
    <hr />
    <h4>Video</h4>
</asp:Content>
