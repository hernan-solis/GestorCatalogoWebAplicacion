using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCaterogia()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                accesoDatos.ejecutarLectura();

                foreach (var item in accesoDatos.Lector)
                {
                    Categoria categoria = new Categoria();

                    categoria.Id = (int)accesoDatos.Lector["Id"];
                    categoria.Descripcion = (String)accesoDatos.Lector["Descripcion"];

                    listaCategoria.Add(categoria);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                accesoDatos.cerrarConexion();
            }

            return listaCategoria;

        }
        public List<Categoria> filtrarCategoria(String cadena)
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos accesoDatos = new AccesoDatos();

            accesoDatos.setearConsulta("select Id, Descripcion from CATEGORIAS where Descripcion like '%" + cadena + "%'");


            try
            {
                accesoDatos.ejecutarLectura();

                foreach (var item in accesoDatos.Lector)
                {
                    Categoria categoria = new Categoria();

                    categoria.Id = (int)accesoDatos.Lector["Id"];
                    categoria.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    listaCategoria.Add(categoria);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }



            return listaCategoria;
        }
        public void editarCategoria(Categoria categoria, String Cadena)
        {
            
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("update CATEGORIAS set Descripcion = '" + Cadena + "' where Id = '" + categoria.Id.ToString() + "'");
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
        public void eliminarCategoria(Categoria categoria)
        {
            
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("delete from CATEGORIAS where Id = " + categoria.Id.ToString() + "");
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
        public void agregarCategoria(String cadena)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("insert into CATEGORIAS (Descripcion) values('" + cadena + "')");
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }


        }
    }
}

