using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Producto
    {
        public int IdProducto;
        public int IdUnidad;
        public string ProductoVenta;
        public bool Estado;

        public Producto(int idProducto, int idUnidad, string producto, bool estado)
        {
            IdProducto = idProducto;
            IdUnidad = idUnidad;
            ProductoVenta = producto;
            Estado = estado;
        }

        public string guardarRegistro()
        {
            return $"[InsertarProducto] {IdProducto},{IdUnidad},'{ProductoVenta}',{(Estado ? 1 : 0)}";
        }
    }
}
