namespace Gestor_de_Encargos
{
    partial class AgregarEncargo
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregarNuevoCliente = new System.Windows.Forms.Button();
            this.cboBuscarCliente = new System.Windows.Forms.ComboBox();
            this.grbEncargo = new System.Windows.Forms.GroupBox();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtSucursalOrigen = new System.Windows.Forms.TextBox();
            this.lblSucursalOrigen = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgwListaArticulos = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbArticulos = new System.Windows.Forms.GroupBox();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.gpbCliente.SuspendLayout();
            this.grbEncargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaArticulos)).BeginInit();
            this.grbArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(25, 46);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(59, 20);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar";
            // 
            // gpbCliente
            // 
            this.gpbCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpbCliente.Controls.Add(this.lblContacto);
            this.gpbCliente.Controls.Add(this.lblApellido);
            this.gpbCliente.Controls.Add(this.lblNombre);
            this.gpbCliente.Controls.Add(this.btnAgregarNuevoCliente);
            this.gpbCliente.Controls.Add(this.cboBuscarCliente);
            this.gpbCliente.Controls.Add(this.lblBuscar);
            this.gpbCliente.Location = new System.Drawing.Point(38, 24);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(921, 155);
            this.gpbCliente.TabIndex = 0;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Seleccionar Cliente";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(563, 109);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(0, 20);
            this.lblContacto.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(563, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 20);
            this.lblApellido.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(563, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 20);
            this.lblNombre.TabIndex = 4;
            // 
            // btnAgregarNuevoCliente
            // 
            this.btnAgregarNuevoCliente.Location = new System.Drawing.Point(29, 90);
            this.btnAgregarNuevoCliente.Name = "btnAgregarNuevoCliente";
            this.btnAgregarNuevoCliente.Size = new System.Drawing.Size(306, 41);
            this.btnAgregarNuevoCliente.TabIndex = 2;
            this.btnAgregarNuevoCliente.Text = "Agregar Nuevo";
            this.btnAgregarNuevoCliente.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoCliente.Click += new System.EventHandler(this.btnAgregarNuevoCliente_Click);
            // 
            // cboBuscarCliente
            // 
            this.cboBuscarCliente.FormattingEnabled = true;
            this.cboBuscarCliente.Location = new System.Drawing.Point(110, 43);
            this.cboBuscarCliente.Name = "cboBuscarCliente";
            this.cboBuscarCliente.Size = new System.Drawing.Size(225, 28);
            this.cboBuscarCliente.TabIndex = 1;
            this.cboBuscarCliente.SelectionChangeCommitted += new System.EventHandler(this.cboBuscarCliente_SelectionChangeCommitted);
            // 
            // grbEncargo
            // 
            this.grbEncargo.Controls.Add(this.txtPrecioTotal);
            this.grbEncargo.Controls.Add(this.cboEstado);
            this.grbEncargo.Controls.Add(this.lblPrecioTotal);
            this.grbEncargo.Controls.Add(this.lblEstado);
            this.grbEncargo.Controls.Add(this.txtDetalles);
            this.grbEncargo.Controls.Add(this.label2);
            this.grbEncargo.Controls.Add(this.lblFecha);
            this.grbEncargo.Controls.Add(this.dtpFecha);
            this.grbEncargo.Controls.Add(this.txtSucursalOrigen);
            this.grbEncargo.Controls.Add(this.lblSucursalOrigen);
            this.grbEncargo.Location = new System.Drawing.Point(38, 580);
            this.grbEncargo.Name = "grbEncargo";
            this.grbEncargo.Size = new System.Drawing.Size(899, 351);
            this.grbEncargo.TabIndex = 6;
            this.grbEncargo.TabStop = false;
            this.grbEncargo.Text = "Datos del Encargo";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(653, 142);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(209, 26);
            this.txtPrecioTotal.TabIndex = 3;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(175, 132);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(209, 28);
            this.cboEstado.TabIndex = 1;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(482, 145);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(151, 20);
            this.lblPrecioTotal.TabIndex = 12;
            this.lblPrecioTotal.Text = "Precio Total en U$D";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 140);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalles.Location = new System.Drawing.Point(29, 236);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(833, 86);
            this.txtDetalles.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Detalles:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(482, 74);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Location = new System.Drawing.Point(653, 69);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(209, 26);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtSucursalOrigen
            // 
            this.txtSucursalOrigen.Location = new System.Drawing.Point(175, 69);
            this.txtSucursalOrigen.Name = "txtSucursalOrigen";
            this.txtSucursalOrigen.Size = new System.Drawing.Size(209, 26);
            this.txtSucursalOrigen.TabIndex = 0;
            // 
            // lblSucursalOrigen
            // 
            this.lblSucursalOrigen.AutoSize = true;
            this.lblSucursalOrigen.Location = new System.Drawing.Point(25, 69);
            this.lblSucursalOrigen.Name = "lblSucursalOrigen";
            this.lblSucursalOrigen.Size = new System.Drawing.Size(122, 20);
            this.lblSucursalOrigen.TabIndex = 3;
            this.lblSucursalOrigen.Text = "Sucursal Origen";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(110, 188);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(209, 26);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(25, 190);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(110, 61);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(209, 26);
            this.txtArticulo.TabIndex = 0;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(25, 64);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(62, 20);
            this.lblArticulo.TabIndex = 1;
            this.lblArticulo.Text = "Articulo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Location = new System.Drawing.Point(683, 960);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 42);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Location = new System.Drawing.Point(848, 960);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgwListaArticulos
            // 
            this.dgwListaArticulos.AllowUserToResizeRows = false;
            this.dgwListaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListaArticulos.Location = new System.Drawing.Point(391, 39);
            this.dgwListaArticulos.MultiSelect = false;
            this.dgwListaArticulos.Name = "dgwListaArticulos";
            this.dgwListaArticulos.ReadOnly = true;
            this.dgwListaArticulos.RowHeadersWidth = 62;
            this.dgwListaArticulos.RowTemplate.Height = 28;
            this.dgwListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListaArticulos.Size = new System.Drawing.Size(493, 248);
            this.dgwListaArticulos.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 119);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(209, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 122);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código";
            // 
            // grbArticulos
            // 
            this.grbArticulos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grbArticulos.Controls.Add(this.btnEliminarArticulo);
            this.grbArticulos.Controls.Add(this.btnAgregarArticulo);
            this.grbArticulos.Controls.Add(this.txtArticulo);
            this.grbArticulos.Controls.Add(this.dgwListaArticulos);
            this.grbArticulos.Controls.Add(this.txtCodigo);
            this.grbArticulos.Controls.Add(this.lblArticulo);
            this.grbArticulos.Controls.Add(this.lblCodigo);
            this.grbArticulos.Controls.Add(this.lblCantidad);
            this.grbArticulos.Controls.Add(this.nudCantidad);
            this.grbArticulos.Location = new System.Drawing.Point(38, 228);
            this.grbArticulos.Name = "grbArticulos";
            this.grbArticulos.Size = new System.Drawing.Size(921, 317);
            this.grbArticulos.TabIndex = 12;
            this.grbArticulos.TabStop = false;
            this.grbArticulos.Text = "Agregar Articulo(s)";
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(222, 248);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(86, 42);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "-";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(110, 248);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(86, 42);
            this.btnAgregarArticulo.TabIndex = 3;
            this.btnAgregarArticulo.Text = "+";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // AgregarEncargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(800, 600);
            this.ClientSize = new System.Drawing.Size(1002, 1024);
            this.Controls.Add(this.grbArticulos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbEncargo);
            this.Controls.Add(this.gpbCliente);
            this.MinimumSize = new System.Drawing.Size(1002, 1078);
            this.Name = "AgregarEncargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AgregarEncargo_Load);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.grbEncargo.ResumeLayout(false);
            this.grbEncargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaArticulos)).EndInit();
            this.grbArticulos.ResumeLayout(false);
            this.grbArticulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.GroupBox grbEncargo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtSucursalOrigen;
        private System.Windows.Forms.Label lblSucursalOrigen;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgwListaArticulos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grbArticulos;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregarNuevoCliente;
        private System.Windows.Forms.ComboBox cboBuscarCliente;
    }
}