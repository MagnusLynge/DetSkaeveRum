<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RolesPage.aspx.cs" Inherits="RolesPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top: 60px;">   
        <asp:TextBox ID="idTextbox" runat="server"></asp:TextBox>
        <asp:TextBox ID="idStringTextbox" runat="server"></asp:TextBox>
        <asp:Button ID="idCreateBtn" runat="server" Text="Create" OnClick="idCreateBtn_Click" />
        <asp:Button ID="idUpdateBtn" runat="server" Text="Update" Onclick="idUpdateBtn_Click"/>
        <asp:Button ID="idDeleteBtn" runat="server" Text="Delete" Onclick="idDeleteBtn_Click"/>
        <asp:Button ID="idGetSingleBtn" runat="server" Text="Get Single" OnClick="idGetSingleBtn_Click" />
        
    </div>
    <div class="container" style="padding-top: 60px;">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>

