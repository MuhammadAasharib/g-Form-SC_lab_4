<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="G_form_lab_3.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Admin Panel Login</h1>
    </div>
    <div>
        <div style="margin-bottom:15px;">
            <label>User Name:    </label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div style="margin-bottom:15px;">
            <label>Password:     </label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div style="margin-bottom:15px;">
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
