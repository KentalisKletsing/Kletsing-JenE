<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FonLiqL.aspx.cs" Inherits="Kletsing.FonLiqL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Liquidae L</h3>
    <div class="row">
        <div class="col-md-4">
            <p>
                <asp:Label runat="server" Text="L -"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterFBegin">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
                <div class="col-md-4">
            <p>
                <asp:Label runat="server" Text="- l -"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterRMid">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-4">
            <p>
                <asp:Label runat="server" Text="- l"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterFEnd">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
