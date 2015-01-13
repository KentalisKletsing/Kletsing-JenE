<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FonLiqR.aspx.cs" Inherits="Kletsing.FonLiqR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Liquidae R</h3>
    <div class="row">
        <div class="col-md-4">
            <p>
                <asp:Label runat="server" Text="R -"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterRBegin">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-4">
            <p>
                <asp:Label runat="server" Text="- r -"></asp:Label>
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
                <asp:Label runat="server" Text="- r"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterREnd">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
