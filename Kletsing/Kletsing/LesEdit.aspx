<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LesEdit.aspx.cs" Inherits="Kletsing.Les_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <h1>
            <asp:Label runat="server" ID="lblLessonName" Text=""></asp:Label></h1>

        <p>Algemeen</p>

        <h3>Klaarzetten</h3>
        <asp:TextBox runat="server" ID="tbKlaarzetten" Height="100" Width="400" TextMode="MultiLine" Wrap="true"></asp:TextBox></p>

        <h3>Groepsopstelling</h3>
        <p><asp:TextBox runat="server" ID="tbGroepsopstelling" Height="100" Width="400" TextMode="MultiLine" Wrap="true"></asp:TextBox></p>

        <h3>Introductie activiteit</h3>
        <p><asp:TextBox runat="server" ID="tbIntroductie" Height="100" Width="400" TextMode="MultiLine" Wrap="true"></asp:TextBox></p>

        <h3>Oefenen met de tekst (passief)</h3>
        <p><asp:TextBox runat="server" ID="tbPassief" Height="100" Width="400" TextMode="MultiLine" Wrap="true"></asp:TextBox></p>

        <h3>Oefenen met de tekst (actief)</h3>
        <p><asp:TextBox runat="server" ID="tbActief" Height="100" Width="400" TextMode="MultiLine" Wrap="true"></asp:TextBox></p>

        <h3>Zingen maar!</h3>
        <p><asp:TextBox runat="server" ID="tbZingen" Height="100" Width="400" TextMode="MultiLine" Wrap="true"></asp:TextBox></p>

        <h3>Variaties</h3>
        <p><asp:TextBox runat="server" ID="tbVariaties" Height="100" Width="400" TextMode="MultiLine" Wrap="true"></asp:TextBox></p>
        
        <br />
        <br />

        <asp:Button
            runat="server"
            CssClass="btn btn-primary"
            OnClick="btnSave_Click"
            Text="Opslaan">
        </asp:Button>
    </form>
</asp:Content>
