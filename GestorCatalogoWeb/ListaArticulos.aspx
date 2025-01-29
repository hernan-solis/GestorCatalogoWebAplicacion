<%@ Page Title="Lista de Articulos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaArticulos.aspx.cs" Inherits="GestorCatalogoWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="d-flex justify-content-center align-items-center">
            <h2 id="title"><%: Title %></h2>
        </div>
        <hr />
        <h3>ACA VA EL FILTRO</h3>


        <asp:GridView ID="dgvArticulos" runat="server" OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged" CssClass="table table-bordered table-striped" DataKeyNames="Id" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
                <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
                <asp:BoundField HeaderText="UrlImagen" DataField="ImagenUrl" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />
                <asp:CommandField ShowSelectButton="true" SelectText="✒" HeaderText="Editar" />
                <asp:CommandField ShowSelectButton="true" SelectText="✘" HeaderText="Eliminar" />
            </Columns>

        </asp:GridView>


    </main>
</asp:Content>
