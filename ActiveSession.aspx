<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ActiveSession.aspx.cs" Inherits="ActiveSession" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="width: 100%; padding-top: 10px;">

        <div class="row" style="padding-top: 41px; background-color: black;">
            <div class="col-lg-12">
                <div class="container">
                    <div class="fotorama" data-arrows="false" data-maxheight="750" data-loop="false" data-ratio="1024/750" data-nav="false" data-autoplay="5000" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="true" data-fit="contain">
                        <asp:Repeater ID="repImgs" runat="server">
                            <ItemTemplate>
                                <asp:Image ID="imgs" ImageUrl='<%# string.Format("~/Images/{0}", Eval("FileName")) %>' runat="server" />
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>

        <div style="padding-top: 5px; padding-bottom: 5px; -webkit-box-shadow: 0px 10px 16px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 10px 16px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 10px 16px 0px rgba(50, 50, 50, 0.75);-moz-border-radius-bottomright: 10px; -webkit-border-bottom-right-radius: 10px; border-bottom-right-radius: 10px; -moz-border-radius-bottomleft: 10px; -webkit-border-bottom-left-radius: 10px; border-bottom-left-radius: 10px;">
            <div class="row">
                <div class="col-lg-12">
                    <div class="container">
                        <div class="fotorama" style="text-align: -webkit-center" data-loop="false" data-maxheight="50" data-autoplay="5000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="true">
                            <asp:Repeater ID="repWrd" runat="server">
                                <ItemTemplate>
                                    <div id="rolPah" class="rolPah" runat="server" style="text-align: center; font-weight: bold;"><%#Eval("Word1")%></div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <div class="container">
                        <div class="fotorama" style="text-align: -webkit-center" data-loop="false" data-maxheight="50" data-autoplay="5000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="true">
                            <asp:Repeater ID="repRol" runat="server">
                                <ItemTemplate>
                                    <div>
                                        <div class="rolPah" id="rolPah" runat="server" style="text-align: center; font-weight: bold; "><%#Eval("Role1")%></div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>

