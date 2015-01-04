<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Fonologie.aspx.cs" Inherits="Kletsing.Fonologie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Fonologie</h1>
    <h3>Kies een categorie</h3>

    <asp:Repeater runat="server" ID="repeaterFonologie">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnCategorie_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
</asp:Content>
