<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WordPage.aspx.cs" Inherits="WordPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container" style="padding-top: 60px;">
        <div class="row">

            <div class="col-md-3">
                <div class="well-lg" style="text-align: center; border: black; border-style: solid; border-width: thin">
                    <asp:Repeater ID="RepeaterWord" runat="server">
                        <ItemTemplate>
                            <asp:Label ID="lblWord" runat="server" Font-Bold="True" Text='<%#Eval("Word1")%>'></asp:Label><br />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>

            <div class="col-md-9">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12" style="padding-top: 15px;">
                            <div class="row">
                                <div class="col-md-6" style="padding-top: 5px;">
                                    <asp:Button ID="btnSubmit" CssClass="btn btn-default" runat="server" Text="Indsæt" OnClick="btnSubmit_Click" />
                                    <asp:Button ID="btnDel" CssClass="btn btn-default" runat="server" Text="Slet" OnClick="btnDel_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12" style="padding-top: 15px;">
                            <asp:TextBox ID="txtWord" CssClass="input-sm" runat="server" Width="384px"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

