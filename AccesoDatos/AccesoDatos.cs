using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class AccesoDatos
    {
        public AccesoDatos() 
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true;");
            comando = new SqlCommand();
        }


        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector { get { return lector; } }

        public void setearConsulta(String consulta) 
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura() 
        {
            comando.Connection = conexion;
            try
            {
   
                comando.Connection.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion() 
        {
            try
            {
                if (lector != null) 
                {
                    lector.Close(); 
                }
                comando.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void setearParametros(String parametro, String valor) 
        {
            comando.Parameters.AddWithValue(parametro, valor);  
        }

        public void ejecutarAccion() 
        {
            comando.Connection = conexion;
            try
            {
         
                comando.Connection.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
                
        }



    }
}
