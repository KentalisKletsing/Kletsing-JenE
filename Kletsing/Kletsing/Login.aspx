<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kletsing.Login" EnableEventValidation="false" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Page.Title %>.</h2>
    <div class="row">
        <div class="col-md-8">
            <form>
                <div class="form-signin" role="form">
                    <h2 class="form-signin-heading">Log in</h2>
                    <asp:TextBox runat="server" ID="textEmail" type="email" class="form-control" placeholder="Email-adres" autofocus="autofocus" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                        ControlToValidate="textEmail"
                        Display="Dynamic"
                        ErrorMessage="Cannot be empty."
                        runat="server" />
                    <asp:TextBox runat="server" ID="textPassword" TextMode="password" class="form-control" placeholder="Wachtwoord" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                        ControlToValidate="textPassword"
                        ErrorMessage="Cannot be empty."
                        runat="server" />
                    <div class="checkbox">
                        <asp:CheckBox ID="Persist" runat="server" />
                        Remember me?
                    </div>
                    <asp:Button runat="server" ID="Submit1" class="btn btn-lg btn-primary btn-block" Text="Log in" OnClick="LogIn" />
                    <p>
                        <asp:Label ID="Msg" ForeColor="Red" runat="server" />
                    </p>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
