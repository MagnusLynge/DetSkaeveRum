﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WordPage.aspx.cs" Inherits="WordPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="padding-top: 60px;">
        <asp:GridView ID="WordGrid" runat="server"></asp:GridView>
        <asp:TextBox ID="txtWord" runat="server" Width="450px"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Indsæt" OnClick="btnSubmit_Click" />
    </div>
</asp:Content>

