<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lessen.aspx.cs" Inherits="Kletsing.Lessen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lessen</h1>
        <asp:Repeater runat="server" ID="repeaterLessons">
        <ItemTemplate>
            <asp:LinkButton OnCommand="linkbtnLesson_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
            <br />
        </ItemTemplate>
    </asp:Repeater>
    <a runat="server" href="Les_samenstellen.aspx">Zelf een les samenstellen</a>
</asp:Content>
