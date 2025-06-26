using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class CarritoDatos
    {
        private string connectionString = "Data Source=DESKTOP-P5BLGN9\\SQLEXPRESS01;Initial Catalog=PruebaAdo;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True";

        public List<Carrito> ObtenerCarritos()
        {
            List<Carrito> carritos= new List<Carrito>();
            using (SqlConnection conn = new SqlConnection(connectionString))

            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Carritos", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Carrito carrito = new Carrito
                            {
                                Id = reader.GetInt32(0),
                                UsuarioId = reader.GetInt32(1),
                                FechaCreacion = reader.GetDateTime(2)
                            };
                            carritos.Add(carrito);
                        }
                    }
                }
            }return carritos;
        }
    }
}
