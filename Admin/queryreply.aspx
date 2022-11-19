<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="queryreply.aspx.cs" Inherits="ComplaintPortal.Admin.queryreply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="reply" runat="server" TextMode="MultiLine"></asp:TextBox>
    <asp:Button ID="submit" runat="server" Text="Reply" />
</asp:Content>
