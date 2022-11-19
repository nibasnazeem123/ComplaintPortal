<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="regi.aspx.cs" Inherits="ComplaintPortal.Guest.regi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/reg.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="auto-style1" align="center" > 
                <tr>  
                    <td>UserName :</td>  
                    <td>  
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr> 

         <tr>  
                    <td>Password :</td>  
                    <td>  
                        <asp:TextBox ID="pass" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr> 

         <tr>  
                    <td>Phone :</td>  
                    <td>  
                        <asp:TextBox ID="phone" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr> 

         <tr>  
                    <td>Email</td>  
                    <td>  
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>  
                        </td>
                        <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="submit_Click" />
                    </td>  

               </tr> 
         
      </table>
    
</asp:Content>
