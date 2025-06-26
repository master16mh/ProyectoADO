using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADO
{
    public partial class FormRegUsuario : Form
    {
        public FormRegUsuario()
        {
            InitializeComponent();
            GvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa
            GvUsuarios.AllowUserToAddRows = false; // No permitir agregar filas manualmente
            GvUsuarios.ReadOnly = true; // Hacer el DataGridView de solo lectura
            GvUsuarios.AutoGenerateColumns = true;
            GvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al tamaño del grid
            GvUsuarios.Columns.Clear(); // Limpiar columnas antes de cargar los datos

            CargarUsuarios(); // Cargar los usuarios al iniciar el formulario
        }

        public UsuarioDatos usuarioDatos = new UsuarioDatos();
        private void FormRegUsuario_Load(object sender, EventArgs e)
        {
            
        }

        public void CargarUsuarios()
        {
            GvUsuarios.DataSource = GvUsuarios.DataSource; 
            GvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al tamaño del grid

            Usuario usuario = new Usuario();
            List<Usuario> usuarios = usuarioDatos.ObtenerUsuarios();
            GvUsuarios.DataSource = usuarios;
            GvUsuarios.Columns["Id"].Visible = false;// Ocultar columna Id
            GvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// Ajustar columnas al tamaño del grid
        }



        private void btAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombreUsuario.Text) || string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else if (FechaNacimTimePicker1.Value >= DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento debe ser anterior a la fecha actual.");
                return;
            }
            
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = tbNombreUsuario.Text,
                Email = tbEmail.Text,
                FechadeNacimiento = FechaNacimTimePicker1.Value,
                Activo = chkBoxActivo.Checked,
                FechaRegistro = DateTime.Now
            };

            usuarioDatos.AgregarUsuario(nuevoUsuario);
            CargarUsuarios(); // Recargar la lista de usuarios en el DataGridView
            MessageBox.Show("Usuario agregado correctamente.");
            tbNombreUsuario.Clear();
            tbEmail.Clear();
        }

        private void btEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (GvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
                return;
            }
            else if (GvUsuarios.SelectedRows.Count > 1)
            {
                MessageBox.Show("Por favor, seleccione solo un usuario para eliminar.");
                return;
            }

            Usuario usuarioSeleccionado = (Usuario)GvUsuarios.SelectedRows[0].DataBoundItem;

            usuarioDatos.EliminarUsuario(usuarioSeleccionado.Id);
            CargarUsuarios(); // Recargar la lista de usuarios en el DataGridView
            MessageBox.Show("Usuario eliminado correctamente.");
            tbNombreUsuario.Clear();
            tbEmail.Clear();
        }

        private void btModificarUsuario_Click(object sender, EventArgs e)
        {
            if (GvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para modificar.");
                return;
            }
            else if (string.IsNullOrEmpty(tbNombreUsuario.Text)|| string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de modificar el usuario.");
                return;
            }
            else if (FechaNacimTimePicker1.Value >= DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento debe ser anterior a la fecha actual.");
                return;
            }


            Usuario usuarioSeleccionado = (Usuario)GvUsuarios.SelectedRows[0].DataBoundItem;

            usuarioSeleccionado.Nombre = tbNombreUsuario.Text;
            usuarioSeleccionado.Email = tbEmail.Text;
            usuarioSeleccionado.FechadeNacimiento = FechaNacimTimePicker1.Value;
            usuarioSeleccionado.Activo = chkBoxActivo.Checked;

            usuarioDatos.ActualizarUsuario(usuarioSeleccionado);
            CargarUsuarios(); // Recargar la lista de usuarios en el DataGridView
            MessageBox.Show("Usuario modificado correctamente.");
            tbNombreUsuario.Clear();
            tbEmail.Clear();
        }
    }
}
