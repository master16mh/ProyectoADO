using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoProducto { get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }
        public DateTime FechaAgregado { get; set; }
        public int Stock { get; set; }
        public Producto()
        {
            Nombre = string.Empty;
            TipoProducto = string.Empty;
            Precio = 0.0m;
            Disponible = true;
            FechaAgregado = DateTime.Now;
            Stock = 0;
        }
        public Producto(int id, string nombre, string tipoProducto, decimal precio, bool disponible, DateTime fechaAgregado, int stock)
        {
            Id = id;
            Nombre = nombre;
            TipoProducto = tipoProducto;
            Precio = precio;
            Disponible = disponible;
            FechaAgregado = fechaAgregado;
            Stock = stock;
        }
    }
}
