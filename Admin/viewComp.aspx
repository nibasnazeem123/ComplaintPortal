<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="viewComp.aspx.cs" Inherits="ComplaintPortal.Admin.viewComp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">View Complaints</h1>
    <asp:GridView align="center" ID="GridView1" runat="server"  AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="uname" HeaderText="User Name" ReadOnly="True" SortExpression="uname" />
            <asp:BoundField DataField="prodname" HeaderText="Product Name" ReadOnly="True" SortExpression="prodname" />
            <asp:BoundField DataField="date" HeaderText="Date" ReadOnly="True" SortExpression="date" />
            <asp:BoundField DataField="complaint" HeaderText="Complaints" ReadOnly="True" />
            <asp:BoundField DataField="reply" HeaderText="Reply" SortExpression="reply" />
            <asp:CommandField ShowEditButton="True" ButtonType="Button" EditText="Reply" />
                               
        </Columns>

    </asp:GridView>
    </asp:Content>
