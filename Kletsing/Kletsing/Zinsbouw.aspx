<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Zinsbouw.aspx.cs" Inherits="Kletsing.Zinsbouw" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Zinnen</h1>
    <h3>Kies een zinslengte</h3>

    <asp:Repeater runat="server" ID="repeaterZinslengte">
        <ItemTemplate>
            <asp:LinkButton OnCommand="linkbtnZinLengte_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
            <br />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
