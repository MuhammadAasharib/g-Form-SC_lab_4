<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="G_form_lab_3.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Admin Logged In</h2>
    <asp:Button ID="Button1" runat="server" Text="Display Data" OnClick="Button1_Click" />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
.
</asp:Content>
