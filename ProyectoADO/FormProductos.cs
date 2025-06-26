using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADO
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            GvProductosEnStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa
            GvProductosEnStock.AllowUserToAddRows = false; // No permitir agregar filas manualmente
            GvProductosEnStock.ReadOnly = true; // Hacer el DataGridView de solo lectura
            GvProductosEnStock.AutoGenerateColumns = true;
            GvProductosEnStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al tamaño del grid
            GvProductosEnStock.Columns.Clear(); // Limpiar columnas antes de cargar los datos

            CargarProductos(); // Cargar los productos al iniciar el formulario
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            
        }

        public ProductoDatos productoDatos = new ProductoDatos();

        public void CargarProductos()
        {
            GvProductosEnStock.DataSource = GvProductosEnStock.DataSource; // Limpiar el DataSource antes de cargar nuevos datos
            GvProductosEnStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al tamaño del grid

            Producto producto = new Producto();
            List<Producto> productos = productoDatos.ObtenerProductos();
            GvProductosEnStock.DataSource = productos;
            GvProductosEnStock.Columns["Id"].Visible = false; // Ocultar columna Id
            GvProductosEnStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al tamaño del grid
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBNombreProducto.Text) || string.IsNullOrWhiteSpace(tbtipoproducto.Text) ||
                string.IsNullOrWhiteSpace(tbPrecio.Text) || string.IsNullOrWhiteSpace(numCantidadDeProducto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Producto nuevoProducto = new Producto
            {
                Nombre = tBNombreProducto.Text,
                TipoProducto = tbtipoproducto.Text,
                Precio = decimal.Parse(tbPrecio.Text),
                FechaAgregado = DateTime.Now,
                Disponible = true, // Asumimos que el producto está disponible al agregarlo
                Stock = int.Parse(numCantidadDeProducto.Text)
            };

            productoDatos.AgregarProducto(nuevoProducto);
            CargarProductos(); // Recargar la lista de productos después de agregar uno nuevo
            MessageBox.Show("Producto agregado exitosamente.");
            tBNombreProducto.Clear();
            tbtipoproducto.Clear();
            tbPrecio.Clear();
            numCantidadDeProducto.Value = 0; // Reiniciar el NumericUpDown a 0
        }

        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            if (GvProductosEnStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }
            
            Producto productoSeleccionado = (Producto)GvProductosEnStock.SelectedRows[0].DataBoundItem;

            productoDatos.EliminarProducto(productoSeleccionado.Id);
            CargarProductos(); // Recargar la lista de productos después de eliminar uno
            MessageBox.Show("Producto eliminado exitosamente.");
            tBNombreProducto.Clear();
            tbPrecio.Clear();
            numCantidadDeProducto.Value = 0; // Reiniciar el NumericUpDown a 0
        }

        private void btEditarCamposProducto_Click(object sender, EventArgs e)
        {
            if (GvProductosEnStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(tBNombreProducto.Text) || string.IsNullOrWhiteSpace(tbtipoproducto.Text) ||
                string.IsNullOrWhiteSpace(tbPrecio.Text) || string.IsNullOrWhiteSpace(numCantidadDeProducto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Producto productoSeleccionado = (Producto)GvProductosEnStock.SelectedRows[0].DataBoundItem;

            productoSeleccionado.Nombre = tBNombreProducto.Text;
            productoSeleccionado.TipoProducto = tbtipoproducto.Text;
            productoSeleccionado.Precio = decimal.Parse(tbPrecio.Text);
            productoSeleccionado.Stock = int.Parse(numCantidadDeProducto.Text);

            productoDatos.ActualizarProducto(productoSeleccionado);
            CargarProductos(); // Recargar la lista de productos después de editar uno
            MessageBox.Show("Producto editado exitosamente.");
            tBNombreProducto.Clear();
            tbtipoproducto.Clear();
            tbPrecio.Clear();
            numCantidadDeProducto.Value = 0; // Reiniciar el NumericUpDown a 0   
        }
    }
}
