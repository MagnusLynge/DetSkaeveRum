<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ActiveSession.aspx.cs" Inherits="ActiveSession" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="width: 100%; padding-top: 10px;">

        <div id="wordDiv" class="row" runat="server" style="padding-top: 45px;">
            <div class="col-lg-12">
                <div class="container">
                    <div class="fotorama" style="text-align: -webkit-center" data-loop="false" data-maxheight="50" data-autoplay="5000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="true">
                        <asp:Repeater ID="repWrd" runat="server">
                            <ItemTemplate>
                                <label id="wrdPah" class="rolPah" runat="server" style="color: green; text-align: center; font-weight: bold;"><%#Eval("Word1")%></label>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>

        <div id="roleDiv" class="row" runat="server" style="">
            <div class="col-lg-12">
                <div class="container">
                    <div class="fotorama" style="text-align: -webkit-center" data-loop="false" data-maxheight="50" data-autoplay="5000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="true">
                        <asp:Repeater ID="repRol" runat="server">
                            <ItemTemplate>
                                <div>
                                    <label class="rolPah" id="rolPah" runat="server" style="color: red; text-align: center; font-weight: bold;"><%#Eval("Role1")%></label>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>

        <div id="imgBack" runat="server" class="row" style="background-color: black;">
            <div class="col-lg-12">
                <div class="container">
                    <div class="fotorama" data-arrows="false" data-maxheight="750" data-allowfullscreen="native" data-loop="false" data-ratio="1024/750" data-nav="false" data-autoplay="5000" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="true" data-fit="contain">
                        <asp:Repeater ID="repImgs" runat="server">
                            <ItemTemplate>
                                <asp:Image ID="imgs" ImageUrl='<%# string.Format("~/Images/{0}", Eval("FileName")) %>' runat="server" />
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>

        <div id="audioDiv" runat="server">
            <asp:Repeater ID="repAudio" runat="server">
                <ItemTemplate>
                    <audio id="audioPlayer" runat="server" loop="loop" autoplay="autoplay">
                        <source src='<%# string.Format("/Audio/{0}", Eval("AudioName")) %>' type="audio/mp3" />
                    </audio>
                </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>
</asp:Content>

