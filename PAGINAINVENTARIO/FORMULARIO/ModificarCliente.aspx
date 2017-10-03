<%@ Page Title="" Language="C#" MasterPageFile="~/FORMULARIO/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ModificarCliente.aspx.cs" Inherits="PAGINAINVENTARIO.FORMULARIO.ModificarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentTitle" runat="server">
    Modificar Cliente
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">
    <div id="cliente">

        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label> <br />
        <asp:TextBox ID="txtNombreModificar" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Direccion"></asp:Label><br />
        <asp:TextBox ID="txtDireccionModificar" runat="server"></asp:TextBox><br /> <br />
        <asp:Button ID="btnGuardarModificar" runat="server" Text="Guardar" CssClass="btn btn-default" OnClick="btnGuardarModificar_Click" />

    </div>
</asp:Content>
