<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThemaDetail.aspx.cs" Inherits="Kletsing.ThemaDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Liedjes</h4>

    <asp:Repeater runat="server" ID="repeaterSong">
        <ItemTemplate>
            <asp:LinkButton OnCommand="linkbtnLiedje_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
            <br />
        </ItemTemplate>
    </asp:Repeater>

    <asp:Label runat="server" ID="lblNoSongs"></asp:Label>
</asp:Content>
