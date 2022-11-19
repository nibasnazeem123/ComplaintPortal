<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="ComplaintPortal.Admin.confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="admin/css/styles.css" rel="stylesheet" />
            <link href="admin/css/customstylesheet.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1 align="center">List Of Users</h1>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataKeyNames="LID" OnRowDeleting="GridView1_RowDeleting" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
                            <Columns>
                                <asp:TemplateField>
                                     <ItemTemplate>
                                        <input type="checkbox" runat="server" name="ch" value='<%Eval("Id") %>' />
                                     </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="LID" HeaderText="UserId" />
                                <asp:BoundField DataField="uname" HeaderText="UserName" />  
                                <asp:CommandField HeaderText="Status" ShowDeleteButton="true" DeleteText="Confirm" />
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
                    </td>
                </tr>
                
                    
            </table>
</asp:Content>

