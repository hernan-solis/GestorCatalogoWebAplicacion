<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GestorCatalogoWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Gestor de Catalogo</h1>
            <hr />
            <p class="lead">ACA VA EL FILTRO</p>
        </section>

        <div class="row row-cols-1 row-cols-md-3 g-4">
            <%--ARJETAS CON FOREACH

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

            TARJETAS CON REPEAT--%>

            <asp:Repeater ID="repRepeater" runat="server">
                <ItemTemplate>
                    <div class="col">
                        <div class="card h-100">
                            <img src="<%#Eval("ImagenUrl") %>" alt="<%#Eval("Nombre")%>" class="card-img-top img-fluid" style=" object-fit: contain; height: 500px;">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Nombre")%></h5>
                                <h6 class="card-subtitle mb-2 text-muted"><%#Eval("Marca.Descripcion") %></h6>
                                <h5 class="card-title">$<%#Eval("Precio")%></h5>
                                <hr />
                                <p class="card-text text-muted"><%#Eval("Descripcion") %></p>
                            </div>
                            <div class="card-footer">
                                <asp:Button ID="btnEditar" CssClass="btn btn-secondary" runat="server" Text="Editar" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" OnClick="btnEditar_Click" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>

    </main>

</asp:Content>
