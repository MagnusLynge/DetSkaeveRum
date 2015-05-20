<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RolesPage.aspx.cs" Inherits="RolesPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top: 60px;">
        <asp:Label ID="Label" runat="server" Text="Get/Create/Delete Role"></asp:Label>   
        <asp:TextBox ID="idTextbox" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Functionality"></asp:Label>
        <asp:TextBox ID="idStringTextbox" runat="server"></asp:TextBox>
        <asp:Button ID="idCreateBtn" runat="server" Text="Create" OnClick="idCreateBtn_Click" />
        <asp:Button ID="idUpdateBtn" runat="server" Text="Update" Onclick="idUpdateBtn_Click"/>
        <asp:Button ID="idDeleteBtn" runat="server" Text="Delete" Onclick="idDeleteBtn_Click"/>
        <asp:Button ID="idGetSingleBtn" runat="server" Text="Get Role" OnClick="idGetSingleBtn_Click" />
        
    </div>
    <div class="container" style="padding-top: 60px;">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>

    <div class="row" style="padding-top: 15px;">

            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12">
                        <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Alle Roller</asp:Label>
                        </div>
                    </div>
                </div>
                <div class="well-lg" style="width: 100%; text-align: center; -webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                    <asp:Repeater ID="RepeaterRoles" runat="server">
                        <ItemTemplate>
                            <asp:Label ID="lblAmountOfRoles" runat="server" Text="Antal roller: "></asp:Label><asp:Label ID="lblAmountOfWordsCount" runat="server" Text=""></asp:Label>
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
</asp:Content>

