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
            this.dgvEncargos = new System.Windows.Forms.DataGridView();
            this.btnAgregarVendedor = new System.Windows.Forms.Button();
            this.btnModificarVendedor = new System.Windows.Forms.Button();
            this.gpbPanelVendedores = new System.Windows.Forms.GroupBox();
            this.tlpVendedorButtons = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlpClienteButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEncargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEncargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEncargos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEncargos.Location = new System.Drawing.Point(5, 55);
            this.dgvEncargos.Margin = new System.Windows.Forms.Padding(5);
            this.dgvEncargos.MultiSelect = false;
            this.dgvEncargos.Name = "dgvEncargos";
            this.dgvEncargos.ReadOnly = true;
            this.dgvEncargos.RowHeadersVisible = false;
            this.dgvEncargos.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEncargos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEncargos.RowTemplate.Height = 28;
            this.dgvEncargos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargos.Size = new System.Drawing.Size(1345, 392);
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
            this.btnAgregarVendedor.Location = new System.Drawing.Point(67, 111);
            this.btnAgregarVendedor.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarVendedor.Name = "btnAgregarVendedor";
            this.btnAgregarVendedor.Size = new System.Drawing.Size(207, 54);
            this.btnAgregarVendedor.TabIndex = 0;
            this.btnAgregarVendedor.Text = "Agregar Vendedor";
            this.btnAgregarVendedor.UseVisualStyleBackColor = false;
            this.btnAgregarVendedor.Click += new System.EventHandler(this.btnAgregarVendedor_Click);
            // 
            // btnModificarVendedor
            // 
            this.btnModificarVendedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVendedor.ForeColor = System.Drawing.Color.White;
            this.btnModificarVendedor.Location = new System.Drawing.Point(67, 190);
            this.btnModificarVendedor.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarVendedor.Name = "btnModificarVendedor";
            this.btnModificarVendedor.Size = new System.Drawing.Size(207, 54);
            this.btnModificarVendedor.TabIndex = 1;
            this.btnModificarVendedor.Text = "Ver Vendedores";
            this.btnModificarVendedor.UseVisualStyleBackColor = false;
            // 
            // gpbPanelVendedores
            // 
            this.gpbPanelVendedores.Controls.Add(this.tlpVendedorButtons);
            this.gpbPanelVendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbPanelVendedores.Location = new System.Drawing.Point(50, 544);
            this.gpbPanelVendedores.Margin = new System.Windows.Forms.Padding(50);
            this.gpbPanelVendedores.Name = "gpbPanelVendedores";
            this.gpbPanelVendedores.Padding = new System.Windows.Forms.Padding(10);
            this.gpbPanelVendedores.Size = new System.Drawing.Size(361, 394);
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
            this.tlpVendedorButtons.Controls.Add(this.btnModificarVendedor, 1, 3);
            this.tlpVendedorButtons.Controls.Add(this.btnAgregarVendedor, 1, 1);
            this.tlpVendedorButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVendedorButtons.Location = new System.Drawing.Point(10, 29);
            this.tlpVendedorButtons.Name = "tlpVendedorButtons";
            this.tlpVendedorButtons.RowCount = 5;
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVendedorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendedorButtons.Size = new System.Drawing.Size(341, 355);
            this.tlpVendedorButtons.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlpClienteButtons);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(50, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(361, 394);
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
            this.tlpClienteButtons.Controls.Add(this.button4, 1, 3);
            this.tlpClienteButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClienteButtons.Location = new System.Drawing.Point(10, 29);
            this.tlpClienteButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpClienteButtons.Name = "tlpClienteButtons";
            this.tlpClienteButtons.RowCount = 5;
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpClienteButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteButtons.Size = new System.Drawing.Size(341, 355);
            this.tlpClienteButtons.TabIndex = 6;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(67, 111);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(207, 54);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(67, 190);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 54);
            this.button4.TabIndex = 1;
            this.button4.Text = "Ver Clientes";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // gpbEncargos
            // 
            this.gpbEncargos.Controls.Add(this.tloDentroPanelEncargos);
            this.gpbEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbEncargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEncargos.Location = new System.Drawing.Point(10, 10);
            this.gpbEncargos.Margin = new System.Windows.Forms.Padding(10);
            this.gpbEncargos.Name = "gpbEncargos";
            this.gpbEncargos.Padding = new System.Windows.Forms.Padding(10);
            this.gpbEncargos.Size = new System.Drawing.Size(1375, 572);
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
            this.tloDentroPanelEncargos.Location = new System.Drawing.Point(10, 29);
            this.tloDentroPanelEncargos.Name = "tloDentroPanelEncargos";
            this.tloDentroPanelEncargos.RowCount = 3;
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tloDentroPanelEncargos.Size = new System.Drawing.Size(1355, 533);
            this.tloDentroPanelEncargos.TabIndex = 6;
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.tlpButtons);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotones.Location = new System.Drawing.Point(3, 455);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(1349, 75);
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
            this.tlpButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(1345, 70);
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
            this.btnDelete.Location = new System.Drawing.Point(410, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(130, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Borrar";
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
            this.BtnAgregar.Location = new System.Drawing.Point(0, 10);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(270, 50);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
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
            this.btnModificar.Location = new System.Drawing.Point(275, 10);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificar.Size = new System.Drawing.Size(130, 50);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
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
            this.btnNotificar.Location = new System.Drawing.Point(545, 10);
            this.btnNotificar.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNotificar.Size = new System.Drawing.Size(130, 50);
            this.btnNotificar.TabIndex = 3;
            this.btnNotificar.Text = "Notificar";
            this.btnNotificar.UseVisualStyleBackColor = false;
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(900, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 44);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.49557F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.50443F));
            this.tableLayoutPanel2.Controls.Add(this.txtNumeroVendedor, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNumeroVendedor, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(452, 44);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtNumeroVendedor
            // 
            this.txtNumeroVendedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumeroVendedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNumeroVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroVendedor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNumeroVendedor.Location = new System.Drawing.Point(176, 9);
            this.txtNumeroVendedor.Name = "txtNumeroVendedor";
            this.txtNumeroVendedor.Size = new System.Drawing.Size(272, 26);
            this.txtNumeroVendedor.TabIndex = 0;
            this.txtNumeroVendedor.TextChanged += new System.EventHandler(this.txtNumeroVendedor_TextChanged);
            this.txtNumeroVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroVendedor_KeyDown);
            // 
            // lblNumeroVendedor
            // 
            this.lblNumeroVendedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroVendedor.AutoSize = true;
            this.lblNumeroVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVendedor.Location = new System.Drawing.Point(64, 9);
            this.lblNumeroVendedor.Name = "lblNumeroVendedor";
            this.lblNumeroVendedor.Size = new System.Drawing.Size(106, 26);
            this.lblNumeroVendedor.TabIndex = 3;
            this.lblNumeroVendedor.Text = "Vendedor";
            // 
            // gpbArticulos
            // 
            this.gpbArticulos.Controls.Add(this.dgvArticulos);
            this.gpbArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbArticulos.Location = new System.Drawing.Point(10, 10);
            this.gpbArticulos.Margin = new System.Windows.Forms.Padding(10);
            this.gpbArticulos.Name = "gpbArticulos";
            this.gpbArticulos.Padding = new System.Windows.Forms.Padding(10);
            this.gpbArticulos.Size = new System.Drawing.Size(952, 292);
            this.gpbArticulos.TabIndex = 10;
            this.gpbArticulos.TabStop = false;
            this.gpbArticulos.Text = "Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 29);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(932, 253);
            this.dgvArticulos.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2087, 2187);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(4098, 1835);
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
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(15);
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1898, 1024);
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
            this.tlpClienteVendedor.Location = new System.Drawing.Point(18, 18);
            this.tlpClienteVendedor.Name = "tlpClienteVendedor";
            this.tlpClienteVendedor.RowCount = 2;
            this.tlpClienteVendedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteVendedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClienteVendedor.Size = new System.Drawing.Size(461, 988);
            this.tlpClienteVendedor.TabIndex = 0;
            // 
            // tlpEncargos
            // 
            this.tlpEncargos.ColumnCount = 1;
            this.tlpEncargos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncargos.Controls.Add(this.tlpArticulos, 0, 1);
            this.tlpEncargos.Controls.Add(this.gpbEncargos, 0, 0);
            this.tlpEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncargos.Location = new System.Drawing.Point(485, 18);
            this.tlpEncargos.Name = "tlpEncargos";
            this.tlpEncargos.RowCount = 1;
            this.tlpEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpEncargos.Size = new System.Drawing.Size(1395, 988);
            this.tlpEncargos.TabIndex = 1;
            // 
            // tlpArticulos
            // 
            this.tlpArticulos.ColumnCount = 2;
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpArticulos.Controls.Add(this.gpbArticulos, 0, 0);
            this.tlpArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArticulos.Location = new System.Drawing.Point(3, 595);
            this.tlpArticulos.Name = "tlpArticulos";
            this.tlpArticulos.RowCount = 2;
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpArticulos.Size = new System.Drawing.Size(1389, 390);
            this.tlpArticulos.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GestorEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1918, 1078);
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
        private System.Windows.Forms.Button btnModificarVendedor;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TableLayoutPanel tloDentroPanelEncargos;
        private System.Windows.Forms.TableLayoutPanel tlpArticulos;
        private System.Windows.Forms.TextBox txtNumeroVendedor;
        private System.Windows.Forms.Label lblNumeroVendedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNotificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

