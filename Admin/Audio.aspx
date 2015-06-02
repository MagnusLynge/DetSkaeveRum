<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Audio.aspx.cs" Inherits="Admin_Audio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="padding-top: 60px">
        <div class="panel panel-default">
            <div class="panel-body">
                <asp:FileUpload ID="fileUploader" runat="server" AllowMultiple="true" Style="padding-top: 5px; float: left;" />
                <asp:Button ID="btnUpload" Text="Upload" runat="server" OnClick="btnUpload_Click" CssClass="btn btn-success" Style="float: right;" />
                <asp:Label ID="lblErrorText" Text="" ForeColor="Red" runat="server" />
            </div>
        </div>
        <hr />
        <ul class="list-group">
            <asp:Repeater ID="repeaterAudio" runat="server">
                <ItemTemplate>
                    <li class="list-group-item">
                        <asp:Label ID="lblListItemName" Text='<%# Eval("AudioName") %>' runat="server" />
                        <asp:LinkButton ID="btnDeleteListItem" Text="Slet" CommandArgument='<%# Eval("id") %>' OnClick="btnDeleteListItem_Click" CssClass="btn btn-danger" style="margin-left: 20px; float: right;" runat="server" />
                        <div style="padding-top: 8px">
                            <audio controls="controls" runat="server">
                                <source src='<%# string.Format("/Audio/{0}", Eval("AudioName")) %>' type="audio/mp3" />
                            </audio>
                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>



        </ul>


        <div class="container" style="padding-top: 30px">
            <ul>
            </ul>
        </div>
    </div>
</asp:Content>

