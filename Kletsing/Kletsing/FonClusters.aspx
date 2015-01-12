<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FonClusters.aspx.cs" Inherits="Kletsing.FonClusters" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h3>Clusters</h3>

    <asp:Repeater runat="server" ID="repeaterCluster">
        <ItemTemplate>
            <asp:LinkButton OnCommand="linkCluster_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
            <br />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
