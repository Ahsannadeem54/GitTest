﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="DataView">
            <div id="lawnData">
                <img src="black.jpg" id="dataimg" />
                <div id="Namediv">
                    <asp:Label runat="server" ID="Namelbl" Text="Lawn Name"></asp:Label>
                </div>
                <div id="Addressdiv">
                    <asp:Label runat="server" ID="Addresslbl" Text="Lawn Address"></asp:Label>
                </div>
                <div id="Capacitydiv">
                    <asp:Label runat="server" ID="Capacitylbl" Text="Lawn Capacity"></asp:Label>
                </div>
                <div id="Rentdiv">
                    <asp:Label runat="server" ID="Rentlbl" Text="Lawn Rent"></asp:Label>
                </div>
                <div id="Buttondiv">
                    <asp:Button runat="server" Text="Check Availability" CssClass="btn" />
                </div>
            </div>
    </div>
</asp:Content>
