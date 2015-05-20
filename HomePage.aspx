<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container" style="padding-top: 60px;">
        <div class="row" style="margin-top: 15px;">
            <div class="col-md-12">
                <asp:Label ID="lblWelcome" runat="server" Font-Bold="True" Font-Size="24" Text="Det Skæve Rum"></asp:Label><br />
                <div style="margin-top: -5px;">
                    <asp:Label ID="lblOnline" runat="server" Font-Size="14" Font-Bold="True" Text="Online!"></asp:Label>
                </div>
            </div>
        </div>


        <div class="row" style="margin-top: 35px;">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-8">
                        <div class="row">
                            <div class="col-md-12">
                                <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                                    <asp:Label ID="lblFrontPageInfo" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Info</asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="well-lg" style="width: 100%; text-align: left; -webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                            <div class="row">
                                <div class="col-sm-6 col-xs-6">
                                    <img src="Images/klokkenDetSkæveRum.jpg" alt="..." class="img-rounded" style="max-width: 99%;  height: auto;" />
                                </div>
                                <div class="col-sm-6 col-xs-6">
                                    <p id="frontPageWelcomeParagarph" runat="server" style="font-weight: bold; font-size: 18px;">Kom og få nogle ideer i det Skæve Rum! Det er nu muligt at få ideer igennem det skæve rum online.</p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-12 col-xs-12" style="padding-top: 5px;">
                                    <p id="fronPageImgInfoParagraph" runat="server" style=" font-weight: lighter">Billede af klokken fra det skæve rum.</p>
                                </div>
                            </div>

                            <div class="row" style="margin-top: 10px;">
                                <div class="col-sm-12 col-xs-12">
                                    <p id="frontPageInfoParagarph1" runat="server" style=" font-weight: bold">Hvis du er elev og vil bruge det skæve rum online. Skal du enten gå ind på en session for at se de samme billeder som dine klassekammerater.</p><br/>
                                    <p id="frontPageInfoParagarph2" runat="server" style=" font-weight: bold">Hvis du er lærer og ønsker at oprette en session. Eller tilføje nye ord, eller billeder, skal du blot logge ind med dit brugernavn og password.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


    </div>
    <!--/.container-->
</asp:Content>

