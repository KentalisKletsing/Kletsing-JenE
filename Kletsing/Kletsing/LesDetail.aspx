<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LesDetail.aspx.cs" Inherits="Kletsing.LesDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <asp:Label runat="server" ID="lblLessonName" Text=""></asp:Label></h1>

    <p>Algemeen</p>

    <h3>Klaarzetten</h3>
    <p>
        <asp:Label runat="server" ID="lblKlaarzetten" Text=""></asp:Label></p>

    <h3>Groepsopstelling</h3>
    <p>
        <asp:Label runat="server" ID="lblGroepsopstelling" Text=""></asp:Label></p>

    <h3>Introductie activiteit</h3>
    <p>
        <asp:Label runat="server" ID="lblIntroductie" Text=""></asp:Label></p>

    <h3>Oefenen met de tekst (passief)</h3>
    <p>
        <asp:Label runat="server" ID="lblPassief" Text=""></asp:Label></p>

    <h3>Oefenen met de tekst (actief)</h3>
    <p>
        <asp:Label runat="server" ID="lblActief" Text=""></asp:Label></p>

    <h3>Zingen maar!</h3>
    <p>
        <asp:Label runat="server" ID="lblZingen" Text=""></asp:Label></p>

    <h3>Variaties</h3>
    <p>
        <asp:Label runat="server" ID="lblVariaties" Text=""></asp:Label></p>
</asp:Content>
