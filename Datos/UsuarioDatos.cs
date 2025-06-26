using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class UsuarioDatos
    {
        private string connectionString = @"Data Source=DESKTOP-P5BLGN9\SQLEXPRESS01;Initial Catalog=PruebaAdo;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=True;Trusted_Connection=True";
      
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection conn = new SqlConnection(connectionString)) 

            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Usuarios", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Email = reader.GetString(2),
                                FechadeNacimiento = reader.GetDateTime(3),
                                Activo = reader.GetBoolean(4),
                                FechaRegistro = reader.GetDateTime(5)
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }return usuarios;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Usuarios (Nombre, Email, FechaNacimiento, Activo, FechaRegistro) VALUES (@Nombre, @Email, @FechaNacimiento, @Activo, @FechaRegistro)", conn))
                {
                    command.Parameters.AddWithValue("@Id", usuario.Id);
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@FechaNacimiento", usuario.FechadeNacimiento);
                    command.Parameters.AddWithValue("@Activo", usuario.Activo);
                    command.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Usuarios SET Nombre = @Nombre, Email = @Email, FechaNacimiento = @FechaNacimiento, Activo = @Activo WHERE Id = @Id", conn))
                {
                    command.Parameters.AddWithValue("@Id", usuario.Id);
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@FechaNacimiento", usuario.FechadeNacimiento);
                    command.Parameters.AddWithValue("@Activo", usuario.Activo);
                    command.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Usuarios WHERE Id = @Id", conn))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Usuario> ObtenerUsuariosActivos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Usuarios WHERE Activo = 1", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Email = reader.GetString(2),
                                FechadeNacimiento = reader.GetDateTime(3),
                                Activo = reader.GetBoolean(4),
                                FechaRegistro = reader.GetDateTime(5)
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            return usuarios;
        }
    }
}
