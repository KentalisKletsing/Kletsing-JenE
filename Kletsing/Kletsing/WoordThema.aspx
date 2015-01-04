<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WoordThema.aspx.cs" Inherits="Kletsing.WoordThema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Thema's</h3>
    <asp:Repeater runat="server" ID="repeaterThema">
        <ItemTemplate>
            <asp:LinkButton OnCommand="linkbtnThema_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
            <br />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
