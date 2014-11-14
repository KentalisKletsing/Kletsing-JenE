<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LetterDetail.aspx.cs" Inherits="Kletsing.LetterDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3><asp:Label runat="server" ID="lblChosen_letter">Gekozen letter:</asp:Label></h3>
    <h4>Liedjes</h4>
    <div class="row">
        <div class="col-md-4">
            <asp:Label runat="server" ID="lblChosen_letterBegin"><p class="lead"></p></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label runat="server" ID="lblChosen_letterMid"><p class="lead"></p></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label runat="server" ID="lblChosen_letterEnd"><p class="lead"></p></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <asp:Repeater runat="server" ID="repeaterBegin">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnWord_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-4">
            <asp:Repeater runat="server" ID="repeaterMid">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnWord_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-4">
            <asp:Repeater runat="server" ID="repeaterEnd">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnWord_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
