<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="G_form_lab_3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>G Forms</h1>
        <div style="float:right; padding-bottom:10px;">
            <!--<asp:Button ID="Button2" runat="server" Text="Admin" CssClass="admin_button" OnClick="Button2_Click"/>-->
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Please Fill in your credentials</h2>
            <div style="margin-bottom:10px;">
                <label>Name</label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div style="margin-bottom:10px;">
                <label>Father Name</label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <div style="margin-bottom:10px;">
                <label>Contact Number</label>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>

            </div>
            <div style="margin-bottom:10px;">
                <label>Address</label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </div>
            <div style="margin-bottom:10px;">
                <label>Email</label>
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Email"></asp:TextBox>
            </div>
            <div style="margin-bottom:15px;">
                <label>Date Of Birth</label>
                <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
            </div>            
            <asp:Button ID="Button1" runat="server"  Text="Submit" OnClick="Button1_Click" />

            <h2> Delete Student</h2>
            <div style="margin-bottom:15px;">
                <label>Enter id of student to be deleted</label>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </div> 
            <asp:Button ID="Button3" runat="server"  Text="Delete" OnClick="Button3_Click" />
        </div>
        
    </div>

</asp:Content>
