namespace Gestor_de_Encargos
{
    partial class GestorEncargos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorEncargos));
            this.dgvEncargos = new System.Windows.Forms.DataGridView();
            this.btnAgregarVendedor = new System.Windows.Forms.Button();
            this.btnVerVendedores = new System.Windows.Forms.Button();
            this.gpbPanelVendedores = new System.Windows.Forms.GroupBox();
            this.tlpVendedorButtons = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlpClienteButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.gpbEncargos = new System.Windows.Forms.GroupBox();
            this.tloDentroPanelEncargos = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNotificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.txtNumeroVendedor = new System.Windows.Forms.TextBox();
            this.lblNumeroVendedor = new System.Windows.Forms.Label();
            this.gpbArticulos = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpClienteVendedor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEncargos = new System.Windows.Forms.TableLayoutPanel();
            this.tlpArticulos = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).BeginInit();
            this.gpbPanelVendedores.SuspendLayout();
            this.tlpVendedorButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tlpClienteButtons.SuspendLayout();
            this.gpbEncargos.SuspendLayout();
            this.tloDentroPanelEncargos.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gpbArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.tlpPrincipal.SuspendLayout();
            this.tlpClienteVendedor.SuspendLayout();
            this.tlpEncargos.SuspendLayout();
            this.tlpArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEncargos
            // 
            this.dgvEncargos.AllowUserToAddRows = false;
            this.dgvEncargos.AllowUserToDeleteRows = false;
            this.dgvEncargos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEncargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEncargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncargos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEncargos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEncargos.Location = new System.Drawing.Point(3, 36);
            this.dgvEncargos.MultiSelect = false;
            this.dgvEncargos.Name = "dgvEncargos";
            this.dgvEncargos.RowHeadersVisible = false;
            this.dgvEncargos.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEncargos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEncargos.RowTemplate.Height = 28;
            this.dgvEncargos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargos.Size = new System.Drawing.Size(589, 153);
            this.dgvEncargos.TabIndex = 0;
            this.dgvEncargos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEncargos_CellFormatting);
            this.dgvEncargos.SelectionChanged += new System.EventHandler(this.dgvEncargos_SelectionChanged);
            // 
            // btnAgregarVendedor
            // 
            this.btnAgregarVendedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVendedor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVendedor.Location = new System.Drawing.Point(-6, 20);
            this.btnAgregarVendedor.Name = "btnAgregarVendedor";
            this.btnAgregarVendedor.Size = new System.Drawing.Size(138, 36);
            this.btnAgregarVendedor.TabIndex = 0;
            this.btnAgregarVendedor.Text = "Agregar Vendedor";
            this.btnAgregarVendedor.UseVisualStyleBackColor = false;
            this.btnAgregarVendedor.Click += new System.EventHandler(this.btnAgregarVendedor_Click);
            // 
            // btnVerVendedores
            // 
            this.btnVerVendedores.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerVendedores.Enabled = false;
            this.btnVerVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVendedores.ForeColor = System.Drawing.Color.White;
            this.btnVerVendedores.Location = new System.Drawing.Point(-6, 72);
            this.btnVerVendedores.Name = "btnVerVendedores";
            this.btnVerVendedores.Size = new System.Drawing.Size(138, 36);
            this.btnVerVendedores.TabIndex = 1;
            this.btnVerVendedores.Text = "Ver Vendedores";
            this.btnVerVendedores.UseVisualStyleBackColor = false;
            // 
            // gpbPanelVendedores
            // 
            this.gpbPanelVendedores.Controls.Add(this.tlpVendedorButtons);
            this.gpbPanelVendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbPanelVendedores.Location = new System.Drawing.Point(33, 254);
            this.gpbPanelVendedores.Margin = new System.Windows.Forms.Padding(33, 33, 33, 33);
            this.gpbPanelVendedores.Name = "gpbPanelVendedores";
            this.gpbPanelVendedores.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.gpbPanelVendedores.Size = new System.Drawing.Size(139, 156);
            this.gpbPanelVendedores.TabIndex = 7;
            this.gpbPanelVendedores.TabStop = false;
            this.gpbPanelVendedores.Text = "Panel Vendedores";
            // 
            // tlpVendedorButtons
            // 
            this.tlpVendedorButtons.ColumnCount = 3;
            this.tlpVendedorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendedorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVendedorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendedorButtons.Controls.Add(this.btnVerVendedores, 1, 3);
            this.tlpVendedorButtons.Controls.Add(this.btnAgregarVendedor, 1, 1);
            this.tlpVendedorButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVendedorButtons.Location = new System.Drawing.Point(7, 20);
            this.tlpVendedorButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpVendedorButtons.Name = "tlpVendedorButtons";
            this.tlpVendedorButtons.RowCount = 5;
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendedorButtons.Size = new System.Drawing.Size(125, 129);
            this.tlpVendedorButtons.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlpClienteButtons);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(33, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(33, 33, 33, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(139, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel Clientes";
            // 
            // tlpClienteButtons
            // 
            this.tlpClienteButtons.ColumnCount = 3;
            this.tlpClienteButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpClienteButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteButtons.Controls.Add(this.btnAgregarCliente, 1, 1);
            this.tlpClienteButtons.Controls.Add(this.btnVerClientes, 1, 3);
            this.tlpClienteButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClienteButtons.Location = new System.Drawing.Point(7, 20);
            this.tlpClienteButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpClienteButtons.Name = "tlpClienteButtons";
            this.tlpClienteButtons.RowCount = 5;
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteButtons.Size = new System.Drawing.Size(125, 128);
            this.tlpClienteButtons.TabIndex = 6;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(-6, 20);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(138, 36);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click_1);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerClientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerClientes.Enabled = false;
            this.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.ForeColor = System.Drawing.Color.White;
            this.btnVerClientes.Location = new System.Drawing.Point(-6, 72);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(138, 36);
            this.btnVerClientes.TabIndex = 1;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = false;
            // 
            // gpbEncargos
            // 
            this.gpbEncargos.Controls.Add(this.tloDentroPanelEncargos);
            this.gpbEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbEncargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEncargos.Location = new System.Drawing.Point(7, 7);
            this.gpbEncargos.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.gpbEncargos.Name = "gpbEncargos";
            this.gpbEncargos.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.gpbEncargos.Size = new System.Drawing.Size(609, 251);
            this.gpbEncargos.TabIndex = 9;
            this.gpbEncargos.TabStop = false;
            this.gpbEncargos.Text = "Panel Encargos";
            // 
            // tloDentroPanelEncargos
            // 
            this.tloDentroPanelEncargos.ColumnCount = 1;
            this.tloDentroPanelEncargos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tloDentroPanelEncargos.Controls.Add(this.PanelBotones, 0, 1);
            this.tloDentroPanelEncargos.Controls.Add(this.dgvEncargos, 0, 0);
            this.tloDentroPanelEncargos.Controls.Add(this.panel2, 0, 0);
            this.tloDentroPanelEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tloDentroPanelEncargos.Location = new System.Drawing.Point(7, 20);
            this.tloDentroPanelEncargos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tloDentroPanelEncargos.Name = "tloDentroPanelEncargos";
            this.tloDentroPanelEncargos.RowCount = 3;
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tloDentroPanelEncargos.Size = new System.Drawing.Size(595, 224);
            this.tloDentroPanelEncargos.TabIndex = 6;
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.tlpButtons);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotones.Location = new System.Drawing.Point(2, 195);
            this.PanelBotones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(591, 27);
            this.PanelBotones.TabIndex = 5;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.Controls.Add(this.btnDelete, 2, 0);
            this.tlpButtons.Controls.Add(this.BtnAgregar, 0, 0);
            this.tlpButtons.Controls.Add(this.btnModificar, 1, 0);
            this.tlpButtons.Controls.Add(this.btnNotificar, 3, 0);
            this.tlpButtons.Location = new System.Drawing.Point(0, -12);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(897, 47);
            this.tlpButtons.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(273, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(87, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAgregar.FlatAppearance.BorderSize = 2;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(0, 7);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(180, 33);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(183, 7);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificar.Size = new System.Drawing.Size(87, 33);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNotificar
            // 
            this.btnNotificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNotificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNotificar.FlatAppearance.BorderSize = 2;
            this.btnNotificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificar.ForeColor = System.Drawing.Color.White;
            this.btnNotificar.Location = new System.Drawing.Point(363, 7);
            this.btnNotificar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNotificar.Size = new System.Drawing.Size(87, 33);
            this.btnNotificar.TabIndex = 3;
            this.btnNotificar.Text = "&Notificar";
            this.btnNotificar.UseVisualStyleBackColor = false;
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 29);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblFiltrar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFiltrar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNumeroVendedor, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNumeroVendedor, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(2, 5);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(45, 18);
            this.lblFiltrar.TabIndex = 0;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFiltrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Location = new System.Drawing.Point(51, 4);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(146, 20);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // txtNumeroVendedor
            // 
            this.txtNumeroVendedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNumeroVendedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNumeroVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroVendedor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNumeroVendedor.Location = new System.Drawing.Point(443, 4);
            this.txtNumeroVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroVendedor.Name = "txtNumeroVendedor";
            this.txtNumeroVendedor.Size = new System.Drawing.Size(146, 20);
            this.txtNumeroVendedor.TabIndex = 0;
            this.txtNumeroVendedor.TextChanged += new System.EventHandler(this.txtNumeroVendedor_TextChanged);
            this.txtNumeroVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroVendedor_KeyDown);
            // 
            // lblNumeroVendedor
            // 
            this.lblNumeroVendedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroVendedor.AutoSize = true;
            this.lblNumeroVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVendedor.Location = new System.Drawing.Point(368, 5);
            this.lblNumeroVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroVendedor.Name = "lblNumeroVendedor";
            this.lblNumeroVendedor.Size = new System.Drawing.Size(71, 18);
            this.lblNumeroVendedor.TabIndex = 3;
            this.lblNumeroVendedor.Text = "Vendedor";
            // 
            // gpbArticulos
            // 
            this.gpbArticulos.Controls.Add(this.dgvArticulos);
            this.gpbArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbArticulos.Location = new System.Drawing.Point(7, 7);
            this.gpbArticulos.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.gpbArticulos.Name = "gpbArticulos";
            this.gpbArticulos.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.gpbArticulos.Size = new System.Drawing.Size(419, 125);
            this.gpbArticulos.TabIndex = 10;
            this.gpbArticulos.TabStop = false;
            this.gpbArticulos.Text = "Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(7, 20);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(405, 98);
            this.dgvArticulos.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1391, 1458);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2732, 1223);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpPrincipal.Controls.Add(this.tlpClienteVendedor, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpEncargos, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(856, 467);
            this.tlpPrincipal.TabIndex = 12;
            // 
            // tlpClienteVendedor
            // 
            this.tlpClienteVendedor.ColumnCount = 1;
            this.tlpClienteVendedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteVendedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteVendedor.Controls.Add(this.groupBox1, 0, 0);
            this.tlpClienteVendedor.Controls.Add(this.gpbPanelVendedores, 0, 1);
            this.tlpClienteVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClienteVendedor.Location = new System.Drawing.Point(12, 12);
            this.tlpClienteVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpClienteVendedor.Name = "tlpClienteVendedor";
            this.tlpClienteVendedor.RowCount = 2;
            this.tlpClienteVendedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteVendedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteVendedor.Size = new System.Drawing.Size(205, 443);
            this.tlpClienteVendedor.TabIndex = 0;
            // 
            // tlpEncargos
            // 
            this.tlpEncargos.ColumnCount = 1;
            this.tlpEncargos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncargos.Controls.Add(this.tlpArticulos, 0, 1);
            this.tlpEncargos.Controls.Add(this.gpbEncargos, 0, 0);
            this.tlpEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncargos.Location = new System.Drawing.Point(221, 12);
            this.tlpEncargos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpEncargos.Name = "tlpEncargos";
            this.tlpEncargos.RowCount = 1;
            this.tlpEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpEncargos.Size = new System.Drawing.Size(623, 443);
            this.tlpEncargos.TabIndex = 1;
            // 
            // tlpArticulos
            // 
            this.tlpArticulos.ColumnCount = 2;
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpArticulos.Controls.Add(this.gpbArticulos, 0, 0);
            this.tlpArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArticulos.Location = new System.Drawing.Point(2, 267);
            this.tlpArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpArticulos.Name = "tlpArticulos";
            this.tlpArticulos.RowCount = 2;
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpArticulos.Size = new System.Drawing.Size(619, 174);
            this.tlpArticulos.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GestorEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(853, 480);
            this.Name = "GestorEncargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Encargos";
            this.Load += new System.EventHandler(this.GestorEncargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).EndInit();
            this.gpbPanelVendedores.ResumeLayout(false);
            this.tlpVendedorButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tlpClienteButtons.ResumeLayout(false);
            this.gpbEncargos.ResumeLayout(false);
            this.tloDentroPanelEncargos.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gpbArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpClienteVendedor.ResumeLayout(false);
            this.tlpEncargos.ResumeLayout(false);
            this.tlpArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEncargos;
        private System.Windows.Forms.Button btnAgregarVendedor;
        private System.Windows.Forms.Button btnVerVendedores;
        private System.Windows.Forms.GroupBox gpbPanelVendedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbEncargos;
        private System.Windows.Forms.GroupBox gpbArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpClienteVendedor;
        private System.Windows.Forms.TableLayoutPanel tlpEncargos;
        private System.Windows.Forms.TableLayoutPanel tlpVendedorButtons;
        private System.Windows.Forms.TableLayoutPanel tlpClienteButtons;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TableLayoutPanel tloDentroPanelEncargos;
        private System.Windows.Forms.TableLayoutPanel tlpArticulos;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNotificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNumeroVendedor;
        private System.Windows.Forms.Label lblNumeroVendedor;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

