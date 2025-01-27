using AccesoDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestorCatalogoWeb
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            List<Articulo> listaArticulos = articuloNegocio.listarArticulosConSP();

            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.DataBind();
        }
    }
}