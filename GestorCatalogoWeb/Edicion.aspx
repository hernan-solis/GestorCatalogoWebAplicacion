<%@ Page Title="Edicion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edicion.aspx.cs" Inherits="GestorCatalogoWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="d-flex justify-content-center align-items-center">
            <h2 id="title"><%: Title %></h2>
        </div>
        <hr />

        <%--public int Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public String ImagenUrl { get; set; }
        public float Precio { get; set; }--%>

        <section class="d-flex justify-content-center align-items-center">
            <div>
                <div class="mb-4 mt-2">
                    <label for="exampleFormControlInput1" class="form-label d-flex justify-content-center align-items-center">Codigo</label>
                    <asp:TextBox ID="tbxCodigo" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-4">
                    <label for="exampleFormControlInput1" class="form-label d-flex justify-content-center align-items-center">Nombre</label>
                    <asp:TextBox ID="tbxNombre" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-4">
                    <label for="exampleFormControlTextarea1" class="form-label d-flex justify-content-center align-items-center">Descripcion</label>
                    <asp:TextBox ID="tbxDescripcion" CssClass="form-control " runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="mb-4">
                    <label for="exampleFormControlInput1" class="form-label d-flex justify-content-center align-items-center">Marca</label>
                    <div></div>
                    <div class="d-flex justify-content-center align-items-center">
                        <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
                    </div>

                </div>
                <div class="mb-4">
                    <label for="exampleFormControlInput1" class="form-label d-flex justify-content-center align-items-center">Categoria</label>
                    <div></div>
                    <div class="d-flex justify-content-center align-items-center">
                        <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
                    </div>

                </div>
                <div class="mb-4">
                    <label for="exampleFormControlInput1" class="form-label d-flex justify-content-center align-items-center">Imagen URL</label>
                    <asp:TextBox ID="tbxImagenUrl" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-5">
                    <label for="exampleFormControlInput1" class="form-label d-flex justify-content-center align-items-center">Precio</label>
                    <asp:TextBox ID="tbxPrecio" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <div class="d-flex justify-content-center align-items-center gap-3">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </div>

        </section>


    </main>
</asp:Content>
