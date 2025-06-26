namespace ProyectoADO
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btVerUsuarios = new System.Windows.Forms.Button();
            this.cbListaUsuarios = new System.Windows.Forms.ComboBox();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.btnAdministrarProductosEnStock = new System.Windows.Forms.Button();
            this.lblGaseosas = new System.Windows.Forms.Label();
            this.cbGaseosas = new System.Windows.Forms.ComboBox();
            this.dgvListaProductoxUsuario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btAgregarProductoACarrito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCigarrillos = new System.Windows.Forms.ComboBox();
            this.lbCervezas = new System.Windows.Forms.Label();
            this.cbCervezas = new System.Windows.Forms.ComboBox();
            this.cbCaramelo = new System.Windows.Forms.ComboBox();
            this.lblCaramelos = new System.Windows.Forms.Label();
            this.btQuitarProducto = new System.Windows.Forms.Button();
            this.btComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btVerUsuarios
            // 
            this.btVerUsuarios.Location = new System.Drawing.Point(12, 12);
            this.btVerUsuarios.Name = "btVerUsuarios";
            this.btVerUsuarios.Size = new System.Drawing.Size(121, 23);
            this.btVerUsuarios.TabIndex = 0;
            this.btVerUsuarios.Text = "Administrar Usuarios";
            this.btVerUsuarios.UseVisualStyleBackColor = true;
            this.btVerUsuarios.Click += new System.EventHandler(this.btVerUsuarios_Click);
            // 
            // cbListaUsuarios
            // 
            this.cbListaUsuarios.FormattingEnabled = true;
            this.cbListaUsuarios.Location = new System.Drawing.Point(12, 77);
            this.cbListaUsuarios.Name = "cbListaUsuarios";
            this.cbListaUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cbListaUsuarios.TabIndex = 1;
            this.cbListaUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbListaUsuarios_SelectedIndexChanged);
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Location = new System.Drawing.Point(12, 61);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(105, 13);
            this.lblListaUsuarios.TabIndex = 2;
            this.lblListaUsuarios.Text = "Seleccionar Usuario:";
            // 
            // btnAdministrarProductosEnStock
            // 
            this.btnAdministrarProductosEnStock.Location = new System.Drawing.Point(861, 449);
            this.btnAdministrarProductosEnStock.Name = "btnAdministrarProductosEnStock";
            this.btnAdministrarProductosEnStock.Size = new System.Drawing.Size(177, 23);
            this.btnAdministrarProductosEnStock.TabIndex = 4;
            this.btnAdministrarProductosEnStock.Text = "Administrar Productos en Stock";
            this.btnAdministrarProductosEnStock.UseVisualStyleBackColor = true;
            this.btnAdministrarProductosEnStock.Click += new System.EventHandler(this.btnAdministrarProductosEnStock_Click);
            // 
            // lblGaseosas
            // 
            this.lblGaseosas.AutoSize = true;
            this.lblGaseosas.Location = new System.Drawing.Point(9, 139);
            this.lblGaseosas.Name = "lblGaseosas";
            this.lblGaseosas.Size = new System.Drawing.Size(57, 13);
            this.lblGaseosas.TabIndex = 5;
            this.lblGaseosas.Text = "Gaseosas:";
            // 
            // cbGaseosas
            // 
            this.cbGaseosas.FormattingEnabled = true;
            this.cbGaseosas.Location = new System.Drawing.Point(12, 155);
            this.cbGaseosas.Name = "cbGaseosas";
            this.cbGaseosas.Size = new System.Drawing.Size(121, 21);
            this.cbGaseosas.TabIndex = 6;
            // 
            // dgvListaProductoxUsuario
            // 
            this.dgvListaProductoxUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductoxUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListaProductoxUsuario.Location = new System.Drawing.Point(231, 77);
            this.dgvListaProductoxUsuario.Name = "dgvListaProductoxUsuario";
            this.dgvListaProductoxUsuario.Size = new System.Drawing.Size(459, 221);
            this.dgvListaProductoxUsuario.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Gaseosas";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cigarrillos";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cervezas";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Caramelos";
            this.Column4.Name = "Column4";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(790, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 17);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "TOTAL:";
            // 
            // btAgregarProductoACarrito
            // 
            this.btAgregarProductoACarrito.Location = new System.Drawing.Point(12, 329);
            this.btAgregarProductoACarrito.Name = "btAgregarProductoACarrito";
            this.btAgregarProductoACarrito.Size = new System.Drawing.Size(75, 23);
            this.btAgregarProductoACarrito.TabIndex = 9;
            this.btAgregarProductoACarrito.Text = "Agregar";
            this.btAgregarProductoACarrito.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cigarrillos:";
            // 
            // cbCigarrillos
            // 
            this.cbCigarrillos.FormattingEnabled = true;
            this.cbCigarrillos.Location = new System.Drawing.Point(12, 204);
            this.cbCigarrillos.Name = "cbCigarrillos";
            this.cbCigarrillos.Size = new System.Drawing.Size(121, 21);
            this.cbCigarrillos.TabIndex = 11;
            // 
            // lbCervezas
            // 
            this.lbCervezas.AutoSize = true;
            this.lbCervezas.Location = new System.Drawing.Point(12, 232);
            this.lbCervezas.Name = "lbCervezas";
            this.lbCervezas.Size = new System.Drawing.Size(54, 13);
            this.lbCervezas.TabIndex = 12;
            this.lbCervezas.Text = "Cervezas:";
            // 
            // cbCervezas
            // 
            this.cbCervezas.FormattingEnabled = true;
            this.cbCervezas.Location = new System.Drawing.Point(12, 248);
            this.cbCervezas.Name = "cbCervezas";
            this.cbCervezas.Size = new System.Drawing.Size(121, 21);
            this.cbCervezas.TabIndex = 13;
            // 
            // cbCaramelo
            // 
            this.cbCaramelo.FormattingEnabled = true;
            this.cbCaramelo.Location = new System.Drawing.Point(12, 292);
            this.cbCaramelo.Name = "cbCaramelo";
            this.cbCaramelo.Size = new System.Drawing.Size(121, 21);
            this.cbCaramelo.TabIndex = 14;
            // 
            // lblCaramelos
            // 
            this.lblCaramelos.AutoSize = true;
            this.lblCaramelos.Location = new System.Drawing.Point(15, 276);
            this.lblCaramelos.Name = "lblCaramelos";
            this.lblCaramelos.Size = new System.Drawing.Size(59, 13);
            this.lblCaramelos.TabIndex = 15;
            this.lblCaramelos.Text = "Caramelos:";
            // 
            // btQuitarProducto
            // 
            this.btQuitarProducto.Location = new System.Drawing.Point(381, 329);
            this.btQuitarProducto.Name = "btQuitarProducto";
            this.btQuitarProducto.Size = new System.Drawing.Size(118, 23);
            this.btQuitarProducto.TabIndex = 16;
            this.btQuitarProducto.Text = "Quitar Producto";
            this.btQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btComprar
            // 
            this.btComprar.Location = new System.Drawing.Point(790, 134);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(75, 23);
            this.btComprar.TabIndex = 17;
            this.btComprar.Text = "Comprar!";
            this.btComprar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 484);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.btQuitarProducto);
            this.Controls.Add(this.lblCaramelos);
            this.Controls.Add(this.cbCaramelo);
            this.Controls.Add(this.cbCervezas);
            this.Controls.Add(this.lbCervezas);
            this.Controls.Add(this.cbCigarrillos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgregarProductoACarrito);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvListaProductoxUsuario);
            this.Controls.Add(this.cbGaseosas);
            this.Controls.Add(this.lblGaseosas);
            this.Controls.Add(this.btnAdministrarProductosEnStock);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.cbListaUsuarios);
            this.Controls.Add(this.btVerUsuarios);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVerUsuarios;
        private System.Windows.Forms.ComboBox cbListaUsuarios;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.Button btnAdministrarProductosEnStock;
        private System.Windows.Forms.Label lblGaseosas;
        private System.Windows.Forms.ComboBox cbGaseosas;
        private System.Windows.Forms.DataGridView dgvListaProductoxUsuario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btAgregarProductoACarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCigarrillos;
        private System.Windows.Forms.Label lbCervezas;
        private System.Windows.Forms.ComboBox cbCervezas;
        private System.Windows.Forms.ComboBox cbCaramelo;
        private System.Windows.Forms.Label lblCaramelos;
        private System.Windows.Forms.Button btQuitarProducto;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

