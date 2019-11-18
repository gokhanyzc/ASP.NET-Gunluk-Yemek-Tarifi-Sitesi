<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Hakkimizda.aspx.cs" Inherits="Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            font-size: x-large;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p class="auto-style2" style="font-weight: 700">
        HAKKIMIZDA</p>
    <p class="auto-style2" style="font-weight: 700">
        <asp:DataList ID="DataList3" runat="server"  Width="448px" Height="102px" style="text-align: left" >
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Eval("Metin") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList>
    </p>


    <asp:Image ID="Image1" runat="server" Height="156px" ImageUrl="~/resimler/team.jpg" Width="449px" />
</asp:Content>

