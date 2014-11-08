<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kletsing.Login" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Page.Title %>.</h2>
    <div class="row">
        <div class="col-md-8">
            <div class="form-signin" role="form">
                <h2 class="form-signin-heading">Please sign in</h2>
                <input type="email" class="form-control" placeholder="Email address" required autofocus>
                <input type="password" class="form-control" placeholder="Password" required>
                <div class="checkbox">
                    <label>
                        <input type="checkbox" value="remember-me">
                        Remember me
                    </label>
                </div>
                <button class="btn btn-lg btn-primary btn-block" type="submit">Sign in</button>
            </div>
        </div>
        <div class="col-md-4">
            <section id="socialLoginForm">
            </section>
        </div>
    </div>
</asp:Content>
