<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="Images.aspx.cs" Inherits="Images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top: 60px;">
        <div class="panel panel-default">
          <div class="panel-body">
            <asp:FileUpload AllowMultiple="true" ID="FileUpload1" style="padding-top: 5px;float:left;" runat="server" />
            <asp:Button ID="btnUpload" CssClass="btn btn-success" style="float: right;" runat="server" Text="Upload billedet" OnClick="Upload" />
          </div>
        </div>
        
<hr />

        <ul class="list-group">
        <asp:Repeater ID="RepeaterIMG" runat="server">
            
            <ItemTemplate>

                  <li class="list-group-item">
                    <asp:LinkButton ID="btnDelete" OnClick="DeleteImage" CommandArgument='<%# Eval("id") %>' CssClass="btn btn-danger" style="margin-left: 20px; float: right;" Text="Slet billedet" runat="server"/>
                    <span class="badge">ID: <%# Eval("id") %></span>
                    <asp:Image ID="Image1" CssClass="img-responsive" runat="server" ImageUrl='<%# string.Format("~/Images/{0}", Eval("FileName")) %>' Height="150px" />
                  </li>
            </ItemTemplate>
             
        </asp:Repeater>
            </ul>
     </div>   
</asp:Content>


