<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lessen.aspx.cs" Inherits="Kletsing.Lessen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lessen</h1>

        <table class="table table-striped">
            <asp:Repeater runat="server" ID="repeaterLessons">
                <ItemTemplate>
                    <tr>
                        <td>
                            <h4><%# Container.DataItem %></h4>
                        </td>
                        <td>
                            <h4><asp:LinkButton OnCommand="linkbtnOpenen_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="Openen"></asp:LinkButton></h4>
                        </td>
                        <td>
                            <h4><asp:LinkButton OnCommand="linkbtnBewerken_Click" CommandArgument="<%# Container.DataItem %>" runat="server" Text="Bewerken"></asp:LinkButton></h4>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    <a runat="server" href="NewLesson.aspx">Zelf een les samenstellen</a>
</asp:Content>
