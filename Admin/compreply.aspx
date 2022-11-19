<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="compreply.aspx.cs" Inherits="ComplaintPortal.Admin.compreply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Closed</asp:ListItem>
        <asp:ListItem>In Process</asp:ListItem>
        <asp:ListItem>Not Yet </asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="submit" runat="server" Text="Reply" OnClick="submit_Click" />
</asp:Content>
