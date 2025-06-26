namespace ProyectoADO
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GvProductosEnStock = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.tBNombreProducto = new System.Windows.Forms.TextBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btEditarCamposProducto = new System.Windows.Forms.Button();
            this.lblCantidadAgregar = new System.Windows.Forms.Label();
            this.numCantidadDeProducto = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProductoDisponible = new System.Windows.Forms.CheckBox();
            this.tbtipoproducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductosEnStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadDeProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // GvProductosEnStock
            // 
            this.GvProductosEnStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProductosEnStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GvProductosEnStock.Location = new System.Drawing.Point(248, 44);
            this.GvProductosEnStock.Name = "GvProductosEnStock";
            this.GvProductosEnStock.Size = new System.Drawing.Size(540, 311);
            this.GvProductosEnStock.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(34, 312);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(126, 23);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(31, 44);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(108, 13);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre de Producto:";
            // 
            // tBNombreProducto
            // 
            this.tBNombreProducto.Location = new System.Drawing.Point(34, 73);
            this.tBNombreProducto.Name = "tBNombreProducto";
            this.tBNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.tBNombreProducto.TabIndex = 3;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(31, 109);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(91, 13);
            this.lblTipoProducto.TabIndex = 4;
            this.lblTipoProducto.Text = "Tipo de producto:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(34, 201);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(31, 176);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // btEditarCamposProducto
            // 
            this.btEditarCamposProducto.Location = new System.Drawing.Point(34, 358);
            this.btEditarCamposProducto.Name = "btEditarCamposProducto";
            this.btEditarCamposProducto.Size = new System.Drawing.Size(75, 52);
            this.btEditarCamposProducto.TabIndex = 8;
            this.btEditarCamposProducto.Text = "Editar campos de producto";
            this.btEditarCamposProducto.UseVisualStyleBackColor = true;
            this.btEditarCamposProducto.Click += new System.EventHandler(this.btEditarCamposProducto_Click);
            // 
            // lblCantidadAgregar
            // 
            this.lblCantidadAgregar.AutoSize = true;
            this.lblCantidadAgregar.Location = new System.Drawing.Point(31, 240);
            this.lblCantidadAgregar.Name = "lblCantidadAgregar";
            this.lblCantidadAgregar.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadAgregar.TabIndex = 9;
            this.lblCantidadAgregar.Text = "Cantidad:";
            // 
            // numCantidadDeProducto
            // 
            this.numCantidadDeProducto.Location = new System.Drawing.Point(34, 272);
            this.numCantidadDeProducto.Name = "numCantidadDeProducto";
            this.numCantidadDeProducto.Size = new System.Drawing.Size(120, 20);
            this.numCantidadDeProducto.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo de Producto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FechaAgregado";
            this.Column5.Name = "Column5";
            // 
            // cbProductoDisponible
            // 
            this.cbProductoDisponible.AutoSize = true;
            this.cbProductoDisponible.Location = new System.Drawing.Point(155, 377);
            this.cbProductoDisponible.Name = "cbProductoDisponible";
            this.cbProductoDisponible.Size = new System.Drawing.Size(81, 17);
            this.cbProductoDisponible.TabIndex = 11;
            this.cbProductoDisponible.Text = "Disponible?";
            this.cbProductoDisponible.UseVisualStyleBackColor = true;
            // 
            // tbtipoproducto
            // 
            this.tbtipoproducto.Location = new System.Drawing.Point(34, 137);
            this.tbtipoproducto.Name = "tbtipoproducto";
            this.tbtipoproducto.Size = new System.Drawing.Size(100, 20);
            this.tbtipoproducto.TabIndex = 12;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbtipoproducto);
            this.Controls.Add(this.cbProductoDisponible);
            this.Controls.Add(this.numCantidadDeProducto);
            this.Controls.Add(this.lblCantidadAgregar);
            this.Controls.Add(this.btEditarCamposProducto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.tBNombreProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.GvProductosEnStock);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvProductosEnStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadDeProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GvProductosEnStock;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox tBNombreProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btEditarCamposProducto;
        private System.Windows.Forms.Label lblCantidadAgregar;
        private System.Windows.Forms.NumericUpDown numCantidadDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.CheckBox cbProductoDisponible;
        private System.Windows.Forms.TextBox tbtipoproducto;
    }
}