<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aplicacao_teste_mysql._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <asp:GridView ID="gdvDados" runat="server" AutoGenerateColumns="true" Width="100%"/>
    
    <asp:TextBox ID="tb_login" runat="server">Login</asp:TextBox>
    <asp:TextBox ID="tb_senha" runat="server">Senha</asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Entrar" onclick="logar"/>

</asp:Content>
