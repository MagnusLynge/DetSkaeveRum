<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ActiveSession.aspx.cs" Inherits="ActiveSession" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="width: 100%">
        <div class="row" style="background-color: black">
            <div class="col-md-12" style="align-content: center; max-height: 641px;">
                <div class="container">
                    <div class="fotorama" data-arrows="false" data-maxheight="641" data-nav="false" data-autoplay="1000" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false" data-fit="contain" data-maxheight="641">
                        <asp:Repeater ID="repImgs" runat="server">
                            <ItemTemplate>
                                <asp:Image ID="imgs" ImageUrl='<%# string.Format("~/Images/{0}", Eval("FileName")) %>' runat="server" />
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
        <div class="row" style="padding-bottom: 100px; max-height: 250px; background: rgb(0, 0, 0); background: -moz-linear-gradient(90deg, rgb(0, 0, 0) 0%, rgb(255, 255, 255) 100%); background: -webkit-linear-gradient(90deg, rgb(0, 0, 0) 0%, rgb(255, 255, 255) 100%); background: -o-linear-gradient(90deg, rgb(0, 0, 0) 0%, rgb(255, 255, 255) 100%); background: -ms-linear-gradient(90deg, rgb(0, 0, 0) 0%, rgb(255, 255, 255) 100%); background: linear-gradient(180deg, rgb(0, 0, 0) 0%, rgb(255, 255, 255) 100%); -webkit-box-shadow: 0px 10px 10px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 10px 10px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 10px 10px 0px rgba(50, 50, 50, 0.75); -moz-border-radius-bottomright: 10px; -webkit-border-bottom-right-radius: 10px; border-bottom-right-radius: 10px; -moz-border-radius-bottomleft: 10px; -webkit-border-bottom-left-radius: 10px; border-bottom-left-radius: 10px;">

            <div class="row">
                <div class="col-lg-offset-2 col-lg-3" style="max-height: 50px">
                    <div class="container" style="width: 100%">
                        <div class="fotorama" data-maxheight="50" data-maxwidth="1170" data-autoplay="1000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false">
                            <asp:Repeater ID="repWrd" runat="server">
                                <ItemTemplate>
                                    <p id="rolPah" runat="server" style="color: white; text-align: center; font-weight: bold; font-size: xx-large"><%#Eval("Word1")%></p>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4" style="max-height: 50px;">
                    <div class="container">
                        <div class="fotorama" data-maxheight="50" data-autoplay="1000" data-nav="false" data-arrows="false" data-click="false" data-swipe="false" data-stopautoplayontouch="false" data-transition="crossfade" data-shuffle="false">
                            <asp:Repeater ID="repRol" runat="server">
                                <ItemTemplate>
                                    <div>
                                        <p id="rolPah" runat="server" style="color: white; text-align: center; font-weight: bold; font-size: xx-large"><%#Eval("Role1")%></p>
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

