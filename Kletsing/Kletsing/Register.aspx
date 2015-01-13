<%@ Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Kletsing.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Page.Title %>.</h2>
    <div class="row">
        <div class="col-md-8">
            <div class="form-signin" role="form">
                <h2 class="form-signin-heading">Registreer</h2>
                <asp:TextBox runat="server" ID="TextEmail" TextMode="email" class="form-control" placeholder="Email-adres" autofocus="autofocus" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                    ControlToValidate="TextEmail"
                    Display="Dynamic"
                    ErrorMessage="Cannot be empty."
                    runat="server" />
                <asp:TextBox runat="server" ID="TextPassword1" TextMode="password" class="form-control" placeholder="Wachtwoord"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                    ControlToValidate="TextPassword1"
                    Display="Dynamic"
                    ErrorMessage="Leeg veld niet toegestaan."
                    runat="server" />
                <asp:TextBox runat="server" ID="TextPassword2" TextMode="password" class="form-control" placeholder="Bevestig wachtwoord"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                    ControlToValidate="TextPassword2"
                    Display="Dynamic"
                    ErrorMessage="Leeg veld niet toegestaan."
                    runat="server" />
                <asp:CompareValidator ID="CompareValidator1"
                    ControlToValidate="TextPassword2"
                    ControlToCompare="TextPassword1"
                    ErrorMessage="Wachtwoorden moeten hetzelfde zijn."
                    runat="server" />
                <asp:Button runat="server" ID="Submit1" class="btn btn-lg btn-primary btn-block" Text="Registreer" OnClick="Submit1_Click" />
                <p>
                    <asp:Label ID="Msg" ForeColor="Red" runat="server" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>
