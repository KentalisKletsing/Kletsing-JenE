<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Woord.aspx.cs" Inherits="Kletsing.Woord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>
        <asp:Label runat="server" ID="lblCat"></asp:Label></h3>
    <h4>Liedjes</h4>
    <asp:Repeater runat="server" ID="repeaterSongs">
        <ItemTemplate>
            <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
            <br />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
