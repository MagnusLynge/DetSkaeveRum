<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WordPage.aspx.cs" Inherits="WordPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container" style="padding-top: 60px;">
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblWordHeaderTxt" runat="server" Font-Bold="True" Font-Size="24" Text="Label">Ord Oversigt</asp:Label>
            </div>
        </div>
        <div class="row">


            <div class="col-md-3">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12" style="padding-top: 15px;">
                            <div class="row">
                                <div class="col-md-6">
                                    <asp:TextBox ID="txtWord" CssClass="input-sm" Placeholder="Indtast ord" runat="server" Width="339px"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6" style="padding-top: 15px;">
                            <asp:Button ID="btnSubmit" CssClass="btn btn-default" runat="server" Text="Indsæt" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnDel" CssClass="btn btn-default" runat="server"  Text="Slet" OnClick="btnDel_Click" />
                            <asp:Label ID="lblWordAddedSuccess" runat="server" Visible="False" ForeColor="Green" Font-Bold="True" Text=""></asp:Label>
                            <asp:Label ID="lblWordAllreadyExists" runat="server" Visible="False" ForeColor="Red" Font-Bold="True" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="row" style="padding-top: 15px">
                        <div class="col-md-6">
                            <asp:Label ID="lblAmountOfWords" runat="server" Font-Bold="True" Text="Antal ord:  "></asp:Label><asp:Label ID="lblAmountWordsCount" runat="server" Font-Bold="True" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div class="row" style="padding-top: 15px;">

            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12">
                        <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Alle ord</asp:Label>
                        </div>
                    </div>
                </div>
                <div class="well-lg" style="width: 100%; text-align: center; -webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">                    
                    <asp:Repeater ID="RepeaterWord" runat="server">
                        <ItemTemplate>
                            <asp:Label ID="lblWord" runat="server" Font-Bold="True" Text='<%#Eval("Word1")%>'></asp:Label><br />
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>

    </div>
</asp:Content>

