using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<ItemCarrito> Items { get; set; }
        public Carrito()
        {
            Items = new List<ItemCarrito>();
            UsuarioId = 0;
            FechaCreacion = DateTime.Now;
        }
        public Carrito(int id, int usuarioId, DateTime fechaCreacion, List<ItemCarrito> items)
        {
            Id = id;
            UsuarioId = usuarioId;
            FechaCreacion = fechaCreacion;
            Items = items ?? new List<ItemCarrito>();
        }
    }
}
