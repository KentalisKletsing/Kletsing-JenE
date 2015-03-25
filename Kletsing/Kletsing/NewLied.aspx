<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewLied.aspx.cs" Inherits="Kletsing.NewLied" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div role="form" class="form-upload">
        <h2 class="form-upload-heading">Upload een nieuwe woordpagina.</h2>
        <h3>Upload een MP3 liedje.</h3>
        <div class="form-control">
            <asp:FileUpload ID="SongUploadControl" runat="server" />
        </div>
        <div class="alert alert-info" role="alert">
            <asp:Label runat="server" ID="StatusLabel1" Text="Upload status: " />
        </div>
        <h3>Upload een MP4 video.</h3>
        <div class="form-control">
            <asp:FileUpload ID="VideoUploadControl" runat="server" />
        </div>
        <div class="alert alert-info" role="alert">
            <asp:Label runat="server" ID="StatusLabel2" Text="Upload status: " />
        </div>
        <h3>Upload een PDF lesbrief.</h3>
        <div class="form-control">
            <asp:FileUpload ID="LessonUploadControl" runat="server" />
        </div>
        <div class="alert alert-info" role="alert">
            <asp:Label runat="server" ID="StatusLabel3" Text="Upload status: " />
        </div>
        <h3>Voer woorden in welke met dit liedje geoefend kunnen worden.</h3>
        <p>Scheid deze woorden met ';'</p>
        <div class="form-control">
            <asp:TextBox AutoCompleteType="Disabled" ID="WoordenTextBox" runat="server" TextMode="SingleLine" Width="100%"/>
        </div>
        <br />
        <div class="form-control">
            <asp:LinkButton ID="UploadButton" runat="server" CssClass="btn btn-primary" OnClick="UploadButton_Click">
                <i class="glyphicon glyphicon-upload" aria-hidden="true"></i> Submit
            </asp:LinkButton>
        </div>
    </div>
</asp:Content>
