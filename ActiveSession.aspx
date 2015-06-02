<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ActiveSession.aspx.cs" Inherits="ActiveSession" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="width: 100%; padding-top: 45px;">

        <div class="row" style="padding-top: 15px;">
            <div class="col-lg-12">
                <div class="container">
                    <div class="fotorama" data-arrows="false" data-maxheight="641" data-nav="false" data-autoplay="5000" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false" data-fit="contain">
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
            <div class="col-lg-12">
                <div class="container">
                    <div class="fotorama" style="text-align: -webkit-center" data-maxheight="50" data-autoplay="5000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false">
                        <asp:Repeater ID="repWrd" runat="server">
                            <ItemTemplate>
                                <div id="rolPah" runat="server" style="text-align: center; font-weight: bold; font-size: xx-large"><%#Eval("Word1")%></div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>


        <div class="row">
            <div class="col-lg-12">
                <div class="container">
                    <div class="fotorama" style="text-align: -webkit-center" data-maxheight="50" data-autoplay="5000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false">
                        <asp:Repeater ID="repRol" runat="server">
                            <ItemTemplate>
                                <div>
                                    <div id="rolPah" runat="server" style="text-align: center; font-weight: bold; font-size: xx-large"><%#Eval("Role1")%></div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>


    </div>
</asp:Content>

