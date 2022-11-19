<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="viewQuery.aspx.cs" Inherits="ComplaintPortal.Admin.viewQuery" %>
<asp:Content ID="Content1"  ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">View Queries</h1>
    
    <asp:GridView align="center" ID="GridView1" runat="server"  DataKeyNames="queid" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowUpdating="gridView_update" >
        <Columns>
            <asp:BoundField DataField="uname" HeaderText="User Name" ReadOnly="True" SortExpression="uname" />
            <asp:BoundField DataField="prodname" HeaderText="Product Name" ReadOnly="True" SortExpression="prodname" />
            <asp:BoundField DataField="date" HeaderText="Date" ReadOnly="True" SortExpression="date" />
            <asp:BoundField DataField="query" HeaderText="Query" ReadOnly="True" />
             <asp:BoundField DataField="reply" HeaderText="Reply" />
            <asp:HyperLinkField HeaderText="Confirm" DataNavigateUrlFields="queid" DataNavigateUrlFormatString="queryreply.aspx?ID={0}" Text="Reply" />

                               
        </Columns>

    </asp:GridView>
</asp:Content>
