<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateSession.aspx.cs" Inherits="Admin.CreateSession" %>

<%@ Import Namespace="System.Diagnostics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="padding-top: 60px; padding-bottom: 30px;">
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblSessionHeader" Font-Bold="True" Font-Size="24" runat="server" Text="Opret En Session"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12" style="padding-top: 15px;">
                <asp:TextBox ID="txtSesName" CssClass="input-sm" Placeholder="Sessions Navn" runat="server" Width="339px"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6" style="padding-top: 15px;">
                <asp:Button ID="btnCreateSession" CssClass="btn btn-default" runat="server" Text="Opret" OnClick="btnCreateSession_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6" style="padding-top: 15px;">
                <asp:Label ID="lblCreateSessionInfo" runat="server" Font-Bold="True" Text="Vælg hvilke ord, roller og billeder. Som du ønsker på sessionen, herunder."></asp:Label>
            </div>
        </div>
        <div class="row">

            <!-- Images container start-->
            <div class="col-md-3 col-sm-4 col-xs-12" style="padding-top: 15px;">
                <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                    <asp:Label ID="lblSesImgInfo" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Vælg Billeder</asp:Label>
                    <div style="float: right; padding-right: 37px;">
                        <asp:CheckBox ID="checkAllImgs" runat="server" AutoPostBack="True" OnCheckedChanged="checkAllImgs_CheckedChanged" />
                    </div>
                    <div style="float: right; padding-right: 15px;">
                        <asp:Label ID="lblAllImgs" Font-Bold="True" ForeColor="White" runat="server" Text="Alle  "></asp:Label>
                    </div>
                </div>
                <div class="well-lg" style="-webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                    <asp:Repeater ID="repImagesOnSes" runat="server">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-10 col-sm-10 col-xs-10">
                                    <asp:Image ID="imgForSession" CssClass="img-responsive lazy" runat="server" ImageUrl='<%# string.Format("~/Images/{0}", Eval("FileName")) %>' Height="150px" />
                                </div>
                                <div class="col-md-2 col-sm-2 col-xs-2" style="padding-top: 65px;">
                                    <asp:CheckBox ID="imgCheckBox" runat="server" />
                                </div>
                            </div>
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <!-- Images container end-->

            <!-- Words container start-->
            <div class="col-md-3 col-sm-4 col-xs-12" style="padding-top: 15px;">
                <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                    <asp:Label ID="lblSesWrdInfo" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Vælg Ord</asp:Label>
                    <div style="float: right; padding-right: 37px;">
                        <asp:CheckBox ID="checkAllWrds" runat="server" AutoPostBack="True" OnCheckedChanged="checkAllWrds_CheckedChanged" />
                    </div>
                    <div style="float: right; padding-right: 15px;">
                        <asp:Label ID="lblAllWrds" Font-Bold="True" ForeColor="White" runat="server" Text="Alle  "></asp:Label>
                    </div>
                </div>
                <div class="well-lg" style="-webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                    <asp:Repeater ID="repWordsOnSes" runat="server">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-10 col-sm-10 col-xs-10" style="text-align: center">
                                    <asp:Label ID="lblWordSes" Font-Bold="True" EnableViewState="True" ViewStateMode="Enabled" runat="server" Text='<%# string.Format(Eval("Word1").ToString()) %>'></asp:Label>
                                </div>
                                <div class="col-md-2 col-sm-2 col-xs-2" style="">
                                    <asp:CheckBox ID="checkWord" runat="server" />
                                </div>
                            </div>
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <!-- Words container end-->

            <!-- Roles container start-->
            <div class="col-md-3 col-sm-4 col-xs-12" style="padding-top: 15px;">
                <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                    <asp:Label ID="lblSesRolInfo" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Vælg Roller</asp:Label>
                    <div style="float: right; padding-right: 37px;">
                        <asp:CheckBox ID="checkAllRols" runat="server" AutoPostBack="True" OnCheckedChanged="checkAllRols_CheckedChanged" />
                    </div>
                    <div style="float: right; padding-right: 15px;">
                        <asp:Label ID="lblAllRols" Font-Bold="True" ForeColor="White" runat="server" Text="Alle  "></asp:Label>
                    </div>
                </div>
                <div class="well-lg" style="-webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                    <asp:Repeater ID="repRolesOnSes" runat="server">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-10 col-sm-10 col-xs-10" style="text-align: center">
                                    <asp:Label ID="lblRoleSes" Font-Bold="True" runat="server" Text='<%# string.Format(Eval("Role1").ToString()) %>'></asp:Label>
                                </div>
                                <div class="col-md-2 col-sm-2 col-xs-2" style="">
                                    <asp:CheckBox ID="checkRole" runat="server" />
                                </div>
                            </div>
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <!-- Roles container end-->

            <!-- Audio container start-->
            <div class="col-md-3 col-sm-4 col-xs-12" style="padding-top: 15px;">
                <div style="padding-left: 10px; padding-top: 6px; background-color: #000000; min-height: 30px; max-width: 100%; -moz-border-radius-topleft: 5px; -webkit-border-top-left-radius: 5px; border-top-left-radius: 5px; -moz-border-radius-topright: 5px; -webkit-border-top-right-radius: 5px; border-top-right-radius: 5px;">
                    <asp:Label ID="lblSesAudInfo" runat="server" Font-Bold="True" ForeColor="White" Text="Label">Vælg Lyd</asp:Label>
                    <div style="float: right; padding-right: 37px;">
                        <asp:CheckBox ID="checkAllAuds" runat="server" AutoPostBack="True" OnCheckedChanged="checkAllAuds_CheckedChanged" />
                    </div>
                    <div style="float: right; padding-right: 15px;">
                        <asp:Label ID="lblAllAuds" Font-Bold="True" ForeColor="White" runat="server" Text="Alle  "></asp:Label>
                    </div>
                </div>
                <div class="well-lg" style="-webkit-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); -moz-box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75); box-shadow: 0px 8px 12px 0px rgba(50, 50, 50, 0.75);">
                    <asp:Repeater ID="repAudiosOnSes" runat="server">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-10 col-sm-10 col-xs-10" style="text-align: center">
                                    <asp:Label ID="lblAudioSes" Font-Bold="True" runat="server" Text='<%# string.Format(Eval("AudioName").ToString()) %>'></asp:Label>
                                </div>
                                <div class="col-md-2 col-sm-2 col-xs-2" style="">
                                    <asp:CheckBox ID="checkAudio" runat="server" OnCheckedChanged="checkAudio_CheckedChanged"/>
                                </div>
                            </div>
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <!-- Audio container end-->
        </div>

    </div>
</asp:Content>

