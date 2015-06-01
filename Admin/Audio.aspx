<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Audio.aspx.cs" Inherits="Admin_Audio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top: 60px">
        <div class="panel">
            <asp:FileUpload ID="fileUploader" runat="server" AllowMultiple="true" />
            <hr />
            <asp:Button ID="btnUpload" Text="Upload" runat="server" OnClick="btnUpload_Click" />
            <asp:Label ID="lblErrorText" Text="" ForeColor="Red" runat="server" />
        </div>
        <div class="container" style="padding-top: 30px">
            <ul>
                <asp:Repeater ID="repeaterAudio" runat="server">
                    <ItemTemplate>
                        <li class="list-group-item">
                            <asp:Label ID="lblListItemName" Text='<%# Eval("AudioName") %>' runat="server" />
                            <asp:LinkButton ID="btnDeleteListItem" Text="Remove" CommandArgument='<%# Eval("id") %>' OnClick= "btnDeleteListItem_Click" CssClass="pull-right" runat="server" />
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>
</asp:Content>

