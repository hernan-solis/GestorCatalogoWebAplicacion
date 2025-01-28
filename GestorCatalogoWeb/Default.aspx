<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GestorCatalogoWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Gestor de Catalogo</h1>
            <p class="lead">ACA VA EL FILTRO</p>
        </section>

        <div class="row row-cols-1 row-cols-md-3 g-4">

            <%
                foreach (var item in ListaArticulos)
                {
            %>

            <div class="col">
                <div class="card h-100">
                    <img src="<%:item.ImagenUrl %>" class="card-img-top" alt="<%:item.Nombre %>">
                    <div class="card-body">
                        <h5 class="card-title"><%:item.Nombre%></h5>
                        <p class="card-text"><%:item.Descripcion %></p>
                    </div>
                    <div class="card-footer">
                        <small class="text-muted">$ <%:item.Precio %></small>
                    </div>
                </div>
            </div>

            <%}%>

        </div>

    </main>

</asp:Content>
