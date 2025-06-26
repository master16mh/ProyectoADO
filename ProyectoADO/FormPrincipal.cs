using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ProyectoADO
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btVerUsuarios_Click(object sender, EventArgs e)
        {
            var form = new FormRegUsuario();
            form.ShowDialog();
        }

        private void btnAdministrarProductosEnStock_Click(object sender, EventArgs e)
        {
            var form = new FormProductos();
            form.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            UsuarioDatos usuarioDatos = new UsuarioDatos();
            List<Entidades.Usuario> usuarios = usuarioDatos.ObtenerUsuariosActivos();
            cbListaUsuarios.DataSource = usuarios;
            cbListaUsuarios.DisplayMember = "Nombre"; // Mostrar el nombre del usuario en el ComboBox
            cbListaUsuarios.ValueMember = "Id"; // Establecer el Id como valor del ComboBox
            cbListaUsuarios.SelectedIndex = -1; // No seleccionar ningún usuario al inicio
        }

        private void cbListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }
    }
}
