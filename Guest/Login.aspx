<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ComplaintPortal.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-page">
  <div class="form">
      <link href="css/login.css" rel="stylesheet" />
      <div>LOGIN PAGE</div>
      <asp:TextBox ID="user" placeholder="USERNAME" runat="server"  ></asp:TextBox>
      <asp:TextBox ID="pass" placeholder="PASSWORD" runat="server" TextMode="Password"></asp:TextBox> 
      
      <p class="message">Not registered? <a href="regi.aspx">Create an account</a></p>
      
      <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"  />
      </div>
        </div>
</asp:Content>
