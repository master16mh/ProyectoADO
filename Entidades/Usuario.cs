using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Usuario()
        {
            Nombre = "";
        }

        public Usuario(int id, string nombre, string email, string fechaNacimiento, bool activo, DateTime fechaRegistro)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            FechadeNacimiento = FechadeNacimiento;
            Activo = activo;
            FechaRegistro = fechaRegistro;
        }
    }
}
