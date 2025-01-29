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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        public Articulo ArticuloSeleccionado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            CargaInicial();





        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }

        protected void CargarListas()
        {
            // --- CARGA DDL LISTA MARCA Y ORDENA ---

            MarcaNegocio marcaNegocio = new MarcaNegocio();

            List<Marca> marcas = marcaNegocio.ListarMarca();

            marcas = (marcas.OrderBy(marca => marca.Descripcion)).ToList();

            ddlMarca.DataSource = marcas;
            ddlMarca.DataBind();


            // --- CARGA DDL LISTA CATEGORIA Y ORDENA ---

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            List<Categoria> categorias = categoriaNegocio.ListarCaterogia();

            categorias = (categorias.OrderBy(c => c.Descripcion)).ToList();

            ddlCategoria.DataSource = categorias;
            ddlCategoria.DataBind();
        }

        protected void CargaInicial()
        {
            CargarListas();

            //setea lista y artSel
            if (Session["listaArticulos"] != null && Session["idArticulo"] != null)
            {
                ListaArticulos = (List<Articulo>)Session["listaArticulos"];
                int idArticulo = int.Parse((string)Session["idArticulo"]);

                ArticuloSeleccionado = ListaArticulos.FirstOrDefault(a => a.Id == idArticulo);

                //completa campos
                tbxCodigo.Text = ArticuloSeleccionado.Codigo;
                tbxNombre.Text = ArticuloSeleccionado.Nombre;
                tbxDescripcion.Text = ArticuloSeleccionado.Descripcion;
                ddlMarca.SelectedValue = ArticuloSeleccionado.Marca.ToString();
                ddlCategoria.SelectedValue = ArticuloSeleccionado.Categoria.ToString();
                tbxImagenUrl.Text = ArticuloSeleccionado.ImagenUrl;
                tbxPrecio.Text = ArticuloSeleccionado.Precio.ToString();
            }



        }
    }
}