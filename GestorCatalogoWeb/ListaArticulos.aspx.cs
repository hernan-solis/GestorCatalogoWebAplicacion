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
            if (!IsPostBack)
                CargaInicial(dgvArticulos);




        }

        protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {


            string idArticuloSeleccionado; 

            Response.Redirect("Edicion.aspx");

        }

        protected void CargaInicial(GridView dgvArticulos) 
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            List<Articulo> listaArticulos = articuloNegocio.listarArticulos();

            // carga de lista y ordena por codigo
            listaArticulos.Sort((a, b) => a.Codigo.CompareTo(b.Codigo));

            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.DataBind();
        }

    }
}