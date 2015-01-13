<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FonFricatieven.aspx.cs" Inherits="Kletsing.FonFricatieven" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Fricatieven</h3>
    <div class="row">
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="F-"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterFBegin">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="-f"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterFEnd">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <hr />

    <div class="row">
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="G-"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterGBegin">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="-g"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterGEnd">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <hr />

    <div class="row">
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="S-"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterSBegin">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="-s"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterSEnd">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    
    <hr />

    <div class="row">
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="V-"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterVBegin">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="-v"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterVEnd">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <hr />

    <div class="row">
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="Z-"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterZBegin">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-6">
            <p>
                <asp:Label runat="server" Text="-z"></asp:Label>
            </p>
            <asp:Repeater runat="server" ID="repeaterZEnd">
                <ItemTemplate>
                    <asp:LinkButton OnCommand="linkbtnSong_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="<%# Container.DataItem %>"></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
