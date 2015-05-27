<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AllMySessions.aspx.cs" Inherits="AllMySessions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="padding-top: 60px;">

        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblWordHeaderTxt" runat="server" Font-Bold="True" Font-Size="24" Text="Label">Alle Dine Aktive Sessioner</asp:Label>
            </div>
        </div>

        <div class="row" style="padding-top: 15px;">
            <div class="col-md-12" style="padding-bottom: 30px;">
                <div class="row">
                    <div class="col-md-12">
                        <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Sessioner</asp:Label>
                        </div>
                    </div>
                </div>
                <div class="well-lg" style="width: 100%; text-align: center; -webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                    <asp:Repeater ID="RepeaterSesOnTeacher" runat="server">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-2 col-sm-3 col-xs-3">
                                    <asp:Label ID="lblSesName" runat="server" Font-Bold="True" Text="Sessions Navn: "></asp:Label>
                                </div>
                                <div class="col-md-8 col-sm-7 col-xs-5" style="text-align: left">
                                    <asp:Label ID="lblSesOnTeacher" runat="server" Font-Bold="True" Text='<%#Eval("SesName")%>'></asp:Label>
                                </div>
                                <div class="col-md-2 col-sm-2 col-xs-4">
                                    <a class="btn btn-default" style="width: 100px;" href="ActiveSession.aspx?id=<%# Eval("id") %>" role="button">Mere info</a>
                                </div>
                            </div>
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

