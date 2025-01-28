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
    public partial class _Default : Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            List<Articulo> listaArticulos = articuloNegocio.listarArticulos();

            //minimamente ordenado
            listaArticulos.Sort((a, b) => a.Codigo.CompareTo(b.Codigo));
            listaArticulos.Sort((a, b) => a.Marca.Descripcion.CompareTo(b.Marca.Descripcion));
            listaArticulos.Sort((a, b) => a.Categoria.Descripcion.CompareTo(b.Categoria.Descripcion));

            ListaArticulos = listaArticulos;

            if (!IsPostBack) 
            {
                repRepeater.DataSource = listaArticulos;
                repRepeater.DataBind();
            }
            


        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string pokemonId = ((Button)sender).CommandArgument;

            Session.Add("pokemonId", pokemonId);
            
            Response.Redirect("Edicion.aspx",false);

        }
    }
}