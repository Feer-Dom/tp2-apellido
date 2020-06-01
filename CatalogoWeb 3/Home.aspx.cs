using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace CatalogoWeb_3
{
    public partial class Home : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        public List<Carrito> listaCarrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                lblproductoInexistente.Visible = false;
                string search = txtBoxBuscar.Text;

                if (Session["listaCarrito"] != null)
                {
                    listaCarrito = (List<Carrito>)Session["listaCarrito"];
                }

                if (search != null && search != "")
                {
                    listaArticulos = articuloNegocio.Listar();
                    listaArticulos = listaArticulos.FindAll(J => J.Nombre.ToLower().Contains(search.ToLower()) ||
                                                                 J.Marca.Descripcion.ToLower().Contains(search.ToLower()) ||
                                                                 J.Categoria.Descripcion.ToLower().Contains(search.ToLower()));
                }
                else
                {
                    listaArticulos = articuloNegocio.Listar();
                }

                if (listaArticulos.Count <= 0)
                {
                    lblproductoInexistente.Visible = true;
                }
            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void btnVerCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerCarrito.aspx");
        }
    }
}