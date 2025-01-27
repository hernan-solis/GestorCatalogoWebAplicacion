<%@ Page Title="Lista de Articulos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaArticulos.aspx.cs" Inherits="GestorCatalogoWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <hr />

        <asp:GridView ID="dgvArticulos" runat="server" CssClass="table table-bordered table-striped" DataKeyNames="Id" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText ="Codigo" DataField ="Codigo"/>
                <asp:BoundField HeaderText ="Nombre" DataField ="Nombre"/>
                <asp:BoundField HeaderText ="Descripcion" DataField ="Descripcion"/>
                <asp:BoundField HeaderText ="Marca" DataField ="Marca.Descripcion"/>
                <asp:BoundField HeaderText ="Categoria" DataField ="Categoria.Descripcion"/>
                <asp:BoundField HeaderText ="UrlImagen" DataField ="ImagenUrl"/>
                <asp:BoundField HeaderText ="Precio" DataField ="Precio"/>
                <asp:CommandField ShowSelectButton="true" SelectText="Editar" HeaderText="Acción" />
            </Columns>

        </asp:GridView>


    </main>
</asp:Content>
