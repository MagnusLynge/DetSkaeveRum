<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Images.aspx.cs" Inherits="Images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top: 60px;">
        <asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
<hr />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowHeader="False" OnRowDeleting="OnRowDataBound">
    <Columns>
        <asp:BoundField DataField="Text" />
        <asp:ImageField DataImageUrlField="Value" ControlStyle-Height="100" ControlStyle-Width="100" />
        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
    </Columns>
</asp:GridView>
        
        <asp:Repeater ID="RepeaterIMG" runat="server">
            <ItemTemplate>
                <asp:Image ID="Image1" CssClass="img-responsive" runat="server" ImageUrl='<%# string.Format("~/Images/{0}", Eval("FileName")) %>' Height="150px" />

            </ItemTemplate>

        </asp:Repeater>
     </div>   
</asp:Content>


