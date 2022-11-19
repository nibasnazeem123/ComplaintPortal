<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="viewQuery.aspx.cs" Inherits="ComplaintPortal.Admin.viewQuery" %>
<asp:Content ID="Content1"  ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">View Queries</h1>
    
    <asp:GridView align="center" ID="GridView1" runat="server"  DataKeyNames="queid" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal"  >
        <Columns>
            <asp:BoundField DataField="uname" HeaderText="User Name" ReadOnly="True" SortExpression="uname" >
            <ControlStyle BorderStyle="Solid" />
            </asp:BoundField>
            <asp:BoundField DataField="prodname" HeaderText="Product Name" ReadOnly="True" SortExpression="prodname" />
            <asp:BoundField DataField="date" HeaderText="Date" ReadOnly="True" SortExpression="date" />
            <asp:BoundField DataField="query" HeaderText="Query" ReadOnly="True" />
             <asp:BoundField DataField="reply" HeaderText="Reply" />
            <asp:HyperLinkField HeaderText="Confirm" DataNavigateUrlFields="queid" DataNavigateUrlFormatString="queryreply.aspx?ID={0}" Text="Reply" />

                               
        </Columns>

        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />

    </asp:GridView>
</asp:Content>
