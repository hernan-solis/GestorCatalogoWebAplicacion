<%@ Page Title="Edicion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edicion.aspx.cs" Inherits="GestorCatalogoWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <hr />
        <h3>subtitulo</h3>

        <%--public int Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public String ImagenUrl { get; set; }
        public float Precio { get; set; }--%>

        <section>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Codigo: </label>
                <asp:TextBox ID="tbxCodigo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Nombre: </label>
                <asp:TextBox ID="tbxNombre" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="exampleFormControlTextarea1" class="form-label">Descripcion: </label>
                <asp:TextBox ID="tbxDescripcion" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Marca: </label>
                <asp:TextBox ID="tbxMarca" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Categoria: </label>
                <asp:TextBox ID="tbxCategoria" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Precio: </label>
                <asp:TextBox ID="tbxPrecio" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div>
                <div>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar Cambios" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </div>

            </div>
        </section>


    </main>
</asp:Content>
