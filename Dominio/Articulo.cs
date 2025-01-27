using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Articulo
    {
        public Articulo() 
        {
            Marca = new Marca();
            Categoria = new Categoria();
        }
        public int Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public String ImagenUrl { get; set; }
        public float Precio { get; set; }

    }
}
