<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="complaints.aspx.cs" Inherits="ComplaintPortal.user.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Complaints</h1>
    <asp:DropDownList runat="server" name=drop1 id=drop1 DataSourceID="SqlDataSource1" DataTextField="prodname" DataValueField="prodid"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:compportalConnectionString %>" SelectCommand="SELECT [prodid], [prodname] FROM [product]"></asp:SqlDataSource>

    <textarea id="text1" name="text1" cols="20" rows="10"></textarea>
    <asp:Button runat="server" Text="Button" OnClick="Unnamed2_Click" />
</asp:Content>
