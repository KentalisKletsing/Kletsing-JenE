<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Letters.aspx.cs" Inherits="Kletsing.Letters" EnableEventValidation="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-5">
            <asp:GridView runat="server" AutoGenerateColumns="false" ID="LetterTable" GridLines="None" AllowSorting="true" 
                CssClass="table table-hover table-striped" OnRowDataBound="LetterTable_RowDataBound" OnSelectedIndexChanged="LetterTable_SelectedIndexChanged">
                <Columns>
                    <asp:HyperLinkField DataTextField="Letter" DataNavigateUrlFields="Letter" DataNavigateUrlFormatString="Letter.aspx?letter={0}" DataTextFormatString="{0}" HeaderText="Letter" />
                    <asp:BoundField DataField="Aantal" HeaderText="Aantal woorden" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="col-md-7">
            <asp:Label runat="server" ID="detailHeader" CssClass="panel-heading" Text="Klik op een letter"/>
        </div>
    </div>
</asp:Content>
