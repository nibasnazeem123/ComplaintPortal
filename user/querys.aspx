<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="querys.aspx.cs" Inherits="ComplaintPortal.user.querys" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 420px;
            height: 134px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>QUERES</h1>
     <asp:DropDownList runat="server" name=drop1 id=drop1 DataSourceID="SqlDataSource1" DataTextField="prodname" DataValueField="prodid"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:compportalConnectionString %>" SelectCommand="SELECT [prodid], [prodname] FROM [product]"></asp:SqlDataSource>

   

    <textarea id="text1" name="text1" class="auto-style1"></textarea>

    <p>
         <asp:Button runat="server" Text="Submit" OnClick="Unnamed2_Click" />
    </p>
    </asp:Content>
