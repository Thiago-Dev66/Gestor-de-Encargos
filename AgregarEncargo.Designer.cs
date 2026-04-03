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
            this.tlpBuscarCliente = new System.Windows.Forms.TableLayoutPanel();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cboBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevoCliente = new System.Windows.Forms.Button();
            this.grbEncargo = new System.Windows.Forms.GroupBox();
            this.tlpDatosEncargo = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtSucursalOrigen = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSucursalOrigen = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.dgwListaArticulos = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbArticulos = new System.Windows.Forms.GroupBox();
            this.tloAgregarArticulos = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.tloPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVendedorACargo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbCliente.SuspendLayout();
            this.tlpBuscarCliente.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbEncargo.SuspendLayout();
            this.tlpDatosEncargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaArticulos)).BeginInit();
            this.grbArticulos.SuspendLayout();
            this.tloAgregarArticulos.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tloPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(2, 16);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.tlpBuscarCliente);
            this.gpbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.Location = new System.Drawing.Point(2, 2);
            this.gpbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbCliente.Size = new System.Drawing.Size(648, 94);
            this.gpbCliente.TabIndex = 0;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Seleccionar Cliente";
            // 
            // tlpBuscarCliente
            // 
            this.tlpBuscarCliente.ColumnCount = 3;
            this.tlpBuscarCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17871F));
            this.tlpBuscarCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82129F));
            this.tlpBuscarCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tlpBuscarCliente.Controls.Add(this.panelLabel, 2, 0);
            this.tlpBuscarCliente.Controls.Add(this.lblBuscar, 0, 0);
            this.tlpBuscarCliente.Controls.Add(this.cboBuscarCliente, 1, 0);
            this.tlpBuscarCliente.Controls.Add(this.btnAgregarNuevoCliente, 1, 1);
            this.tlpBuscarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBuscarCliente.Location = new System.Drawing.Point(2, 16);
            this.tlpBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpBuscarCliente.Name = "tlpBuscarCliente";
            this.tlpBuscarCliente.RowCount = 2;
            this.tlpBuscarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.28369F));
            this.tlpBuscarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.71631F));
            this.tlpBuscarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpBuscarCliente.Size = new System.Drawing.Size(644, 76);
            this.tlpBuscarCliente.TabIndex = 7;
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.tableLayoutPanel1);
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLabel.Location = new System.Drawing.Point(346, 2);
            this.panelLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLabel.Name = "panelLabel";
            this.tlpBuscarCliente.SetRowSpan(this.panelLabel, 2);
            this.panelLabel.Size = new System.Drawing.Size(296, 72);
            this.panelLabel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContacto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 72);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(2, 4);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 15);
            this.lblNombre.TabIndex = 4;
            // 
            // lblContacto
            // 
            this.lblContacto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(2, 51);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(0, 15);
            this.lblContacto.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(2, 27);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 15);
            this.lblApellido.TabIndex = 5;
            // 
            // cboBuscarCliente
            // 
            this.cboBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboBuscarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.cboBuscarCliente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscarCliente.FormattingEnabled = true;
            this.cboBuscarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboBuscarCliente.Location = new System.Drawing.Point(109, 12);
            this.cboBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBuscarCliente.Name = "cboBuscarCliente";
            this.cboBuscarCliente.Size = new System.Drawing.Size(160, 21);
            this.cboBuscarCliente.TabIndex = 0;
            this.cboBuscarCliente.SelectionChangeCommitted += new System.EventHandler(this.cboBuscarCliente_SelectionChangeCommitted);
            // 
            // btnAgregarNuevoCliente
            // 
            this.btnAgregarNuevoCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregarNuevoCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevoCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarNuevoCliente.Location = new System.Drawing.Point(109, 47);
            this.btnAgregarNuevoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarNuevoCliente.Name = "btnAgregarNuevoCliente";
            this.btnAgregarNuevoCliente.Size = new System.Drawing.Size(160, 27);
            this.btnAgregarNuevoCliente.TabIndex = 1;
            this.btnAgregarNuevoCliente.Text = "Agregar Nuevo";
            this.btnAgregarNuevoCliente.UseVisualStyleBackColor = false;
            this.btnAgregarNuevoCliente.Click += new System.EventHandler(this.btnAgregarNuevoCliente_Click);
            // 
            // grbEncargo
            // 
            this.grbEncargo.Controls.Add(this.tlpDatosEncargo);
            this.grbEncargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbEncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEncargo.Location = new System.Drawing.Point(2, 248);
            this.grbEncargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEncargo.Name = "grbEncargo";
            this.grbEncargo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEncargo.Size = new System.Drawing.Size(648, 163);
            this.grbEncargo.TabIndex = 2;
            this.grbEncargo.TabStop = false;
            this.grbEncargo.Text = "Datos del Encargo";
            // 
            // tlpDatosEncargo
            // 
            this.tlpDatosEncargo.ColumnCount = 4;
            this.tlpDatosEncargo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.95608F));
            this.tlpDatosEncargo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.89071F));
            this.tlpDatosEncargo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.92547F));
            this.tlpDatosEncargo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.54037F));
            this.tlpDatosEncargo.Controls.Add(this.label2, 0, 2);
            this.tlpDatosEncargo.Controls.Add(this.txtPrecioTotal, 3, 1);
            this.tlpDatosEncargo.Controls.Add(this.txtSucursalOrigen, 1, 0);
            this.tlpDatosEncargo.Controls.Add(this.dtpFecha, 3, 0);
            this.tlpDatosEncargo.Controls.Add(this.lblPrecioTotal, 2, 1);
            this.tlpDatosEncargo.Controls.Add(this.lblFecha, 2, 0);
            this.tlpDatosEncargo.Controls.Add(this.txtDetalles, 0, 3);
            this.tlpDatosEncargo.Controls.Add(this.lblEstado, 0, 1);
            this.tlpDatosEncargo.Controls.Add(this.lblSucursalOrigen, 0, 0);
            this.tlpDatosEncargo.Controls.Add(this.cboEstado, 1, 1);
            this.tlpDatosEncargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosEncargo.Location = new System.Drawing.Point(2, 16);
            this.tlpDatosEncargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpDatosEncargo.Name = "tlpDatosEncargo";
            this.tlpDatosEncargo.RowCount = 4;
            this.tlpDatosEncargo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tlpDatosEncargo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tlpDatosEncargo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tlpDatosEncargo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tlpDatosEncargo.Size = new System.Drawing.Size(644, 145);
            this.tlpDatosEncargo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Detalles:";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecioTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(429, 36);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(177, 20);
            this.txtPrecioTotal.TabIndex = 3;
            // 
            // txtSucursalOrigen
            // 
            this.txtSucursalOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSucursalOrigen.BackColor = System.Drawing.SystemColors.Window;
            this.txtSucursalOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursalOrigen.Location = new System.Drawing.Point(110, 5);
            this.txtSucursalOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSucursalOrigen.Name = "txtSucursalOrigen";
            this.txtSucursalOrigen.Size = new System.Drawing.Size(162, 20);
            this.txtSucursalOrigen.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(429, 5);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(177, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(321, 40);
            this.lblPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(104, 13);
            this.lblPrecioTotal.TabIndex = 12;
            this.lblPrecioTotal.Text = "Precio Total en U$D";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(321, 9);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDetalles.BackColor = System.Drawing.SystemColors.Window;
            this.tlpDatosEncargo.SetColumnSpan(this.txtDetalles, 4);
            this.txtDetalles.Location = new System.Drawing.Point(2, 95);
            this.txtDetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(640, 48);
            this.txtDetalles.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(2, 40);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            // 
            // lblSucursalOrigen
            // 
            this.lblSucursalOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSucursalOrigen.AutoSize = true;
            this.lblSucursalOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalOrigen.Location = new System.Drawing.Point(2, 9);
            this.lblSucursalOrigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucursalOrigen.Name = "lblSucursalOrigen";
            this.lblSucursalOrigen.Size = new System.Drawing.Size(82, 13);
            this.lblSucursalOrigen.TabIndex = 3;
            this.lblSucursalOrigen.Text = "Sucursal Origen";
            // 
            // cboEstado
            // 
            this.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(110, 36);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(162, 21);
            this.cboEstado.TabIndex = 2;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(111, 65);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(159, 20);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(2, 68);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.Location = new System.Drawing.Point(111, 5);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(159, 20);
            this.txtArticulo.TabIndex = 0;
            // 
            // lblArticulo
            // 
            this.lblArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(2, 8);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(42, 13);
            this.lblArticulo.TabIndex = 1;
            this.lblArticulo.Text = "Articulo";
            // 
            // dgwListaArticulos
            // 
            this.dgwListaArticulos.AllowUserToAddRows = false;
            this.dgwListaArticulos.AllowUserToDeleteRows = false;
            this.dgwListaArticulos.AllowUserToResizeRows = false;
            this.dgwListaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListaArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwListaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwListaArticulos.Location = new System.Drawing.Point(278, 2);
            this.dgwListaArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwListaArticulos.MultiSelect = false;
            this.dgwListaArticulos.Name = "dgwListaArticulos";
            this.dgwListaArticulos.ReadOnly = true;
            this.dgwListaArticulos.RowHeadersVisible = false;
            this.dgwListaArticulos.RowHeadersWidth = 62;
            this.dgwListaArticulos.RowTemplate.Height = 28;
            this.dgwListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListaArticulos.Size = new System.Drawing.Size(364, 122);
            this.dgwListaArticulos.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(111, 35);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(2, 38);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código";
            // 
            // grbArticulos
            // 
            this.grbArticulos.Controls.Add(this.tloAgregarArticulos);
            this.grbArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbArticulos.Location = new System.Drawing.Point(2, 100);
            this.grbArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbArticulos.Name = "grbArticulos";
            this.grbArticulos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbArticulos.Size = new System.Drawing.Size(648, 144);
            this.grbArticulos.TabIndex = 1;
            this.grbArticulos.TabStop = false;
            this.grbArticulos.Text = "Agregar Articulo(s)";
            // 
            // tloAgregarArticulos
            // 
            this.tloAgregarArticulos.ColumnCount = 2;
            this.tloAgregarArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tloAgregarArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tloAgregarArticulos.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tloAgregarArticulos.Controls.Add(this.dgwListaArticulos, 1, 0);
            this.tloAgregarArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tloAgregarArticulos.Location = new System.Drawing.Point(2, 16);
            this.tloAgregarArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tloAgregarArticulos.Name = "tloAgregarArticulos";
            this.tloAgregarArticulos.RowCount = 1;
            this.tloAgregarArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tloAgregarArticulos.Size = new System.Drawing.Size(644, 126);
            this.tloAgregarArticulos.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.21053F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.78947F));
            this.tableLayoutPanel3.Controls.Add(this.txtArticulo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblArticulo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCodigo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCantidad, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCodigo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudCantidad, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(272, 122);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminarArticulo);
            this.panel1.Controls.Add(this.btnAgregarArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(111, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 28);
            this.panel1.TabIndex = 13;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminarArticulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(100, -2);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(57, 28);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "-";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregarArticulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(1, -2);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(57, 28);
            this.btnAgregarArticulo.TabIndex = 3;
            this.btnAgregarArticulo.Text = "+";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // tloPrincipal
            // 
            this.tloPrincipal.ColumnCount = 1;
            this.tloPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tloPrincipal.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tloPrincipal.Controls.Add(this.gpbCliente, 0, 0);
            this.tloPrincipal.Controls.Add(this.grbEncargo, 0, 2);
            this.tloPrincipal.Controls.Add(this.grbArticulos, 0, 1);
            this.tloPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tloPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tloPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tloPrincipal.Name = "tloPrincipal";
            this.tloPrincipal.RowCount = 4;
            this.tloPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.79189F));
            this.tloPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.77115F));
            this.tloPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.43696F));
            this.tloPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tloPrincipal.Size = new System.Drawing.Size(652, 467);
            this.tloPrincipal.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.07407F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.96296F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.86008F));
            this.tableLayoutPanel2.Controls.Add(this.lblVendedorACargo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 415);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(648, 50);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblVendedorACargo
            // 
            this.lblVendedorACargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVendedorACargo.AutoSize = true;
            this.lblVendedorACargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorACargo.Location = new System.Drawing.Point(2, 16);
            this.lblVendedorACargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedorACargo.Name = "lblVendedorACargo";
            this.lblVendedorACargo.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lblVendedorACargo.Size = new System.Drawing.Size(7, 17);
            this.lblVendedorACargo.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Location = new System.Drawing.Point(482, 13);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 7, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 28);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(566, 13);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 7, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarEncargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(652, 467);
            this.Controls.Add(this.tloPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarEncargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AgregarEncargo_Load);
            this.gpbCliente.ResumeLayout(false);
            this.tlpBuscarCliente.ResumeLayout(false);
            this.tlpBuscarCliente.PerformLayout();
            this.panelLabel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbEncargo.ResumeLayout(false);
            this.tlpDatosEncargo.ResumeLayout(false);
            this.tlpDatosEncargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaArticulos)).EndInit();
            this.grbArticulos.ResumeLayout(false);
            this.tloAgregarArticulos.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tloPrincipal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgwListaArticulos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grbArticulos;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboBuscarCliente;
        private System.Windows.Forms.TableLayoutPanel tloPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBuscarCliente;
        private System.Windows.Forms.TableLayoutPanel tloAgregarArticulos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tlpDatosEncargo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarNuevoCliente;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblVendedorACargo;
    }
}