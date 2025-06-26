using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 

namespace Datos
{
    public class ProductoDatos
    {
        private string connectionString = @"Data Source=DESKTOP-P5BLGN9\SQLEXPRESS01;Initial Catalog=PruebaAdo;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=True;Trusted_Connection=True";

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Productos", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                TipoProducto = reader.GetString(2), // Manejo de valores nulos
                                Precio = reader.GetDecimal(3),
                                Disponible = reader.GetBoolean(4),
                                FechaAgregado = reader.GetDateTime(5),
                                Stock = reader.GetInt32(6)
                            };
                            productos.Add(producto);
                        }
                    }
                }
            }
            return productos;
        }

        public void AgregarProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Productos (Nombre, TipoProducto, Precio, Disponible, FechaAgregado, Stock) VALUES (@Nombre, @TipoProducto, @Precio, @Disponible, @FechaAgregado, @Stock)", conn))
                {
                    command.Parameters.AddWithValue("@Id", producto.Id);
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@TipoProducto", producto.TipoProducto);
                    command.Parameters.AddWithValue("@Precio", producto.Precio);
                    command.Parameters.AddWithValue("@Disponible", producto.Disponible);
                    command.Parameters.AddWithValue("@FechaAgregado", producto.FechaAgregado);
                    command.Parameters.AddWithValue("@Stock", producto.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Productos SET Nombre = @Nombre, TipoProducto = @TipoProducto, Precio = @Precio, " +
                    "Disponible = @Disponible, FechaAgregado = @FechaAgregado, Stock = @Stock WHERE Id = @Id", conn))
                {
                    command.Parameters.AddWithValue("@Id", producto.Id);
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@TipoProducto", producto.TipoProducto);
                    command.Parameters.AddWithValue("@Precio", producto.Precio);
                    command.Parameters.AddWithValue("@Disponible", producto.Disponible);
                    command.Parameters.AddWithValue("@FechaAgregado", producto.FechaAgregado);
                    command.Parameters.AddWithValue("@Stock", producto.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarProducto(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Productos WHERE Id = @Id", conn))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Producto> ObtenerProductosDisponibles()
        {
            List<Producto> productosDisponibles = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Productos WHERE Disponible = 1", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                TipoProducto = reader.IsDBNull(2) ? null : reader.GetString(2), // Manejo de valores nulos
                                Precio = reader.GetDecimal(3),
                                Disponible = reader.GetBoolean(4),
                                FechaAgregado = reader.GetDateTime(5),
                                Stock = reader.GetInt32(6)
                            };
                            productosDisponibles.Add(producto);
                        }
                    }
                }
            }
            return productosDisponibles;
        }
    }
}
