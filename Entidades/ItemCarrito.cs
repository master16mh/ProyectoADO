using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemCarrito
    {
        public int Id { get; set; }
        public int CarritoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => PrecioUnitario * Cantidad ;

        public ItemCarrito()
        {
            Cantidad = 1;
            PrecioUnitario = 0.0m;
        }
        public ItemCarrito(int id, int carritoId, int productoId, int cantidad, decimal precioUnitario)
        {
            Id = id;
            CarritoId = carritoId;
            ProductoId = productoId;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }
    }
}
