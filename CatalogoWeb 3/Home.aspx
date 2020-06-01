<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CatalogoWeb_3.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row text-primary justify-content-between">
            <div class="col-6">
                <p class="display-3"><%= Session["userName"] %>, Bienvenid@!
                <asp:Button Text="Ir al Carrito" CssClass="btn btn-primary" ID="btnVerCarrito" runat="server" OnClick="btnVerCarrito_Click"   />
                </p>
            </div>
        </div>
        <div class="row form-inline mb-2">
            <asp:TextBox CssClass="form-control mr-sm-2" Columns="140" MaxLength="100" ID="txtBoxBuscar" placeholder="Buscar productos, marcas y más..." runat="server" />
            <asp:Button Text="Buscar" ID="btnBuscar" CssClass="btn btn-outline-primary" runat="server" OnClick="btnBuscar_Click" />

        </div>
        <div class="row text-primary">
            <div class="col">
                <h1 class="display-4">Catalogo de Productos</h1>
            </div>
        </div>

        <div class="row">
            <div class="card-deck">
                <%foreach (var item in listaArticulos)
                    {
                        if (listaArticulos.Count < 3)
                        {
                %><div class="col-6">
                    <%}
                        else
                        {
                    %><div class="col-4">
                        <%
                            }%>
                        <div class="card border-primary mb-3" style="width: 18rem;">
                            <img src="<%= item.ImagenURL %>" class="card-img-top" alt="...">
                            <div class="card-body text-dark">
                                <h5 class="card-title"><% = item.Nombre %></h5>
                                <p class="card-text"><% = item.Descripcion %></p>
                                <a href="Detalle.aspx?cArt=<%= item.CodArt %>" class="btn btn-primary">Detalle</a>
                            </div>
                        </div>
                    </div>
                    <%}%>
                </div>
            </div>
            <div class="row">
                <asp:Label Text="No se econtraron Productos con ese nombre..." CssClass="display-4" Visible="false" ID="lblproductoInexistente" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
