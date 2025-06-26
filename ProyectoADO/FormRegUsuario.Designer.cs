namespace ProyectoADO
{
    partial class FormRegUsuario
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
            this.GvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAgregarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaNacimTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btEliminarUsuario = new System.Windows.Forms.Button();
            this.btModificarUsuario = new System.Windows.Forms.Button();
            this.chkBoxActivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // GvUsuarios
            // 
            this.GvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GvUsuarios.Location = new System.Drawing.Point(317, 13);
            this.GvUsuarios.Name = "GvUsuarios";
            this.GvUsuarios.Size = new System.Drawing.Size(545, 426);
            this.GvUsuarios.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha de Nacimiento";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Activo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de Registro";
            this.Column5.Name = "Column5";
            // 
            // btAgregarUsuario
            // 
            this.btAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregarUsuario.Location = new System.Drawing.Point(16, 334);
            this.btAgregarUsuario.Name = "btAgregarUsuario";
            this.btAgregarUsuario.Size = new System.Drawing.Size(118, 23);
            this.btAgregarUsuario.TabIndex = 1;
            this.btAgregarUsuario.Text = "Registrar Usuario";
            this.btAgregarUsuario.UseVisualStyleBackColor = true;
            this.btAgregarUsuario.Click += new System.EventHandler(this.btAgregarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crear Usuario:";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(16, 54);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbNombreUsuario.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(19, 151);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // FechaNacimTimePicker1
            // 
            this.FechaNacimTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimTimePicker1.Location = new System.Drawing.Point(19, 103);
            this.FechaNacimTimePicker1.Name = "FechaNacimTimePicker1";
            this.FechaNacimTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.FechaNacimTimePicker1.TabIndex = 8;
            // 
            // btEliminarUsuario
            // 
            this.btEliminarUsuario.Location = new System.Drawing.Point(19, 392);
            this.btEliminarUsuario.Name = "btEliminarUsuario";
            this.btEliminarUsuario.Size = new System.Drawing.Size(101, 23);
            this.btEliminarUsuario.TabIndex = 9;
            this.btEliminarUsuario.Text = "Eliminar Usuario";
            this.btEliminarUsuario.UseVisualStyleBackColor = true;
            this.btEliminarUsuario.Click += new System.EventHandler(this.btEliminarUsuario_Click);
            // 
            // btModificarUsuario
            // 
            this.btModificarUsuario.Location = new System.Drawing.Point(16, 363);
            this.btModificarUsuario.Name = "btModificarUsuario";
            this.btModificarUsuario.Size = new System.Drawing.Size(118, 23);
            this.btModificarUsuario.TabIndex = 10;
            this.btModificarUsuario.Text = "Modificar Usuario";
            this.btModificarUsuario.UseVisualStyleBackColor = true;
            this.btModificarUsuario.Click += new System.EventHandler(this.btModificarUsuario_Click);
            // 
            // chkBoxActivo
            // 
            this.chkBoxActivo.AutoSize = true;
            this.chkBoxActivo.Location = new System.Drawing.Point(175, 368);
            this.chkBoxActivo.Name = "chkBoxActivo";
            this.chkBoxActivo.Size = new System.Drawing.Size(62, 17);
            this.chkBoxActivo.TabIndex = 11;
            this.chkBoxActivo.Text = "Activo?";
            this.chkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // FormRegUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 533);
            this.Controls.Add(this.chkBoxActivo);
            this.Controls.Add(this.btModificarUsuario);
            this.Controls.Add(this.btEliminarUsuario);
            this.Controls.Add(this.FechaNacimTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgregarUsuario);
            this.Controls.Add(this.GvUsuarios);
            this.Name = "FormRegUsuario";
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.FormRegUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GvUsuarios;
        private System.Windows.Forms.Button btAgregarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaNacimTimePicker1;
        private System.Windows.Forms.Button btEliminarUsuario;
        private System.Windows.Forms.Button btModificarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox chkBoxActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}