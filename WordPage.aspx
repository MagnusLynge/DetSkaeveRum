<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WordPage.aspx.cs" Inherits="WordPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container" style="padding-top: 60px;">
        

                <asp:Repeater ID="RepeaterWord" runat="server">
                    <ItemTemplate>
                        <asp:Label ID="lblWord" runat="server" Text='<%#Eval("Word1")%>'></asp:Label><br />
                    </ItemTemplate>
                </asp:Repeater>


                <asp:TextBox ID="txtWord" runat="server" Width="450px"></asp:TextBox>
                <asp:Button ID="btnSubmit" runat="server" Text="Indsæt" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnDel" runat="server" Text="Slet" OnClick="btnDel_Click" />
            


    </div>
</asp:Content>

