<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RolesPage.aspx.cs" Inherits="Admin.RolesPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div class="container" style="padding-top: 60px;">


        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblRoleHeaderTxt" runat="server" Font-Bold="True" Font-Size="24" Text="Label">Rolle Oversigt</asp:Label>
            </div>
        </div>
        <div class="row">


            <div class="col-md-3">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12" style="padding-top: 15px;">
                            <div class="row">
                                <div class="col-md-6">
                                    <asp:TextBox ID="idTextbox" CssClass="input-sm" Placeholder="Indtast rolle" runat="server" Width="339px"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6" style="padding-top: 15px;">
                            <asp:Button ID="idCreateBtn" CssClass="btn btn-default" runat="server" Text="Indsæt" OnClick="idCreateBtn_Click" />
                            <asp:Button ID="idDeleteBtn" CssClass="btn btn-default" runat="server" Text="Slet" OnClick="idDeleteBtn_Click" />
                            <asp:Label ID="lblRoleInputConfirm" runat="server" Font-Bold="True" Text=""></asp:Label>
                        </div>
                    </div>
                   
                </div>
            </div>
        </div>










        <div class="row" style="padding-top: 15px">
            <div class="col-md-6">
                <asp:Label ID="lblAmountOfRoles" runat="server" Font-Bold="True" Text="Antal roller:  "></asp:Label><asp:Label ID="lblAmountRolesCount" runat="server" Font-Bold="True" Text=""></asp:Label>
            </div>
        </div>





        <div class="row" style="padding-top: 15px;">

            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12">
                        <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Alle roller</asp:Label>
                        </div>
                    </div>
                </div>
                <div class="well-lg" style="width: 100%; text-align: center; -webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                    <asp:Repeater ID="RepeaterRoles" runat="server">
                        <ItemTemplate>
                            <asp:Label ID="lblRole" runat="server" Font-Bold="True" Text='<%#Eval("Role1")%>'></asp:Label><br />
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>

    </div>
</asp:Content>

