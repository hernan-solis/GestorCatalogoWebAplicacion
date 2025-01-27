using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class MarcaNegocio
    {
        public List<Marca> listarMarca() 
        {
            List<Marca> listaMarca = new List<Marca>();
            AccesoDatos accesoDatos = new AccesoDatos();

            accesoDatos.setearConsulta("select Id, Descripcion from MARCAS");


            try
            {
                accesoDatos.ejecutarLectura();

                foreach (var item in accesoDatos.Lector)
                {
                    Marca marca = new Marca();

                    marca.Id = (int)accesoDatos.Lector ["Id"];
                    marca.Descripcion = (string)accesoDatos.Lector ["Descripcion"];

                    listaMarca.Add(marca);
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

       

            return listaMarca;
        }
        public List<Marca> filtrarMarca(String cadena)
        {
            List<Marca> listaMarca = new List<Marca>();
            AccesoDatos accesoDatos = new AccesoDatos();

            accesoDatos.setearConsulta("select Id, Descripcion from MARCAS where Descripcion like '%"+cadena+"%'");
            

            try
            {
                accesoDatos.ejecutarLectura();

                foreach (var item in accesoDatos.Lector)
                {
                    Marca marca = new Marca();

                    marca.Id = (int)accesoDatos.Lector["Id"];
                    marca.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    listaMarca.Add(marca);
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



            return listaMarca;
        }
        public void editarMarca(Marca marca, String Cadena) 
        {
            List<Marca> listaMarca = new List<Marca>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("update Marcas set Descripcion = '"+Cadena+"' where Id = '"+marca.Id.ToString()+"'");
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
        public void eliminarMarca(Marca marca)
        {
           
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("delete from MARCAS where Id = " + marca.Id.ToString() + "");
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
        public void agregarMarca(String cadena) 
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("insert into MARCAS (Descripcion) values('"+cadena+"')");
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
