<%@ Page Title="" Language="C#" MasterPageFile="~/FORMULARIO/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PAGINAINVENTARIO.FORMULARIO.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentTitle" runat="server">
    LOGIN
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <div id="formulario">
        
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label><br />
        <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox><br /> <br />
        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" CssClass="btn btn-default" OnClick="btnEntrar_Click" />
    </div>
</asp:Content>
