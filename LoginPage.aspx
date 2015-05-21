﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container" style="padding-top: 200px;">
        <div class="row" style="padding-top: 15px;">
            <div class="col-lg-offset-3 col-lg-6 col-md-offset-3 col-md-6" style="padding-bottom: 30px;">
                <div class="row">
                    <div class="col-md-12">
                        <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Login</asp:Label>
                        </div>
                    </div>
                </div>
                
                <div class="well-lg" style="width: 100%; text-align: center; -webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                    <asp:TextBox ID="UserName" Placeholder="Brugernavn" CssClass="input-lg" runat="server"></asp:TextBox><br />
                    <div style="margin-top: 5px;">
                        <asp:TextBox ID="Password" Placeholder="Password" CssClass="input-lg" runat="server" TextMode="Password"></asp:TextBox><br />
                    </div>
                    <div style="margin-top: 10px;">
                        <asp:Button CssClass="btn-lg btn-success" runat="server" Text="Login" OnClick="SignIn"  />

                        <asp:Label ID="lblStatus" runat="server" Text="Login forkert" ForeColor="red" Visible="False"></asp:Label>
                    </div>
                </div>

            </div>
        </div>
    </div>


</asp:Content>

