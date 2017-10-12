﻿<%@ Page Title="" Language="C#" MasterPageFile="~/FORMULARIO/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="PAGINAINVENTARIO.FORMULARIO.Articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentTitle" runat="server">
    Articulos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 254px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" runat="server">

    <div id="formularioArticulo">

        <table class="nav-justified">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Articulo"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtArticulo" runat="server" CssClass="form-inline"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Cantidad"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-inline"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Precio" CssClass="form-inline"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-inline"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnGuardar" runat="server" Text="GUARDAR" CssClass="btn btn-default" OnClick="btnGuardar_Click" />

                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>

    <br />
    <asp:GridView ID="gvArticulo" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" CssClass="table-condensed" DataKeyNames="id_articulo" DataSourceID="ArticuloSource" PageIndex="5" PageSize="5">
        <Columns>
            <asp:BoundField DataField="id_articulo" HeaderText="id_articulo" InsertVisible="False" ReadOnly="True" SortExpression="id_articulo" />
            <asp:BoundField DataField="Articulo" HeaderText="Articulo" SortExpression="Articulo" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="ArticuloSource" runat="server" ConnectionString="<%$ ConnectionStrings:INVENTARIODBConnectionString %>" SelectCommand="SELECT * FROM [ARTICULOS]" UpdateCommand="UPDATE [ARTICULOS] SET [Articulo]=@Articulo, [Cantidad]=@Cantidad,[Precio]=@Precio WHERE [id_articulo]=@id_articulo" DeleteCommand="DELETE FROM [ARTICULOS] WHERE [id_articulo]=@id_articulo"></asp:SqlDataSource>
</asp:Content>