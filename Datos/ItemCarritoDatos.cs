using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ItemCarritoDatos
    {
        private string connectionString = "Data Source=DESKTOP-P5BLGN9\\SQLEXPRESS01;Initial Catalog=PruebaAdo;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True";
       
        public List<ItemCarrito> ObtenerItemsCarrito()
        {
            List<ItemCarrito> itemCarritos = new List<ItemCarrito>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM ItemsCarrito", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var itemCarrito = new ItemCarrito
                            {
                                Id = reader.GetInt32(0),
                                CarritoId = reader.GetInt32(1),
                                ProductoId = reader.GetInt32(1),
                                Cantidad = reader.GetInt32(2),
                                PrecioUnitario = reader.GetDecimal(3)
                            };
                            itemCarritos.Add(itemCarrito);
                        }
                    }
                }
            }
            return itemCarritos;
        }
    }
}
