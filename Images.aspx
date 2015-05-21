<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Images.aspx.cs" Inherits="Images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top: 60px;">
        <asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
<hr />

        <ul class="list-group">
        <asp:Repeater ID="RepeaterIMG" runat="server">
            
            <ItemTemplate>

                  <li class="list-group-item">
                    <asp:Button ID="btnDelete" OnClick="DeleteImage" CommandArgument='<%# Eval("id") %>' CssClass="btn btn-danger" style="margin-left: 20px; float: right;" Text="Slet billedet" runat="server"/>
                    <span class="badge">ID: <%# Eval("id") %></span>
                    <asp:Image ID="Image1" CssClass="img-responsive" runat="server" ImageUrl='<%# string.Format("~/Images/{0}", Eval("FileName")) %>' Height="150px" />
                  </li>
        
                
            </ItemTemplate>
             
        </asp:Repeater>
            </ul>
     </div>   
</asp:Content>


