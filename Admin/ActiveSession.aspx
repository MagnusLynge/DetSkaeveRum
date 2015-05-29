<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ActiveSession.aspx.cs" Inherits="ActiveSession" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container" style="width: 100%">
        <div class="row" style="background-color: black">
            <div class="col-md-12" style="align-content: center; max-height: 641px;">
                <div class="container">
                    <div class="fotorama" data-arrows="false" data-nav="false" data-autoplay="true" data-autoplay="1000" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false" data-fit="contain" data-maxheight="641">
                        <asp:Repeater ID="repImgs" runat="server">
                            <ItemTemplate>
                                <asp:Image ID="imgs" ImageUrl='<%# string.Format("~/Images/{0}", Eval("FileName")) %>' runat="server" />
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="container">
                    <div class="fotorama" data-autoplay="true" data-autoplay="1000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false">
                        <asp:Repeater ID="repWrd" runat="server">
                            <ItemTemplate>
                                <div class="any">
                                    <p id="wrdPah" runat="server" style="text-align: center; font-weight: bold; font-size: xx-large"><%#Eval("Word1")%></p>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="container">
                    <div class="fotorama" data-autoplay="true" data-autoplay="1000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false">
                        <asp:Repeater ID="repRol" runat="server">
                            <ItemTemplate>
                                <div>
                                    <p id="rolPah" runat="server" style="text-align: center; font-weight: bold; font-size: xx-large"><%#Eval("Role1")%></p>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

