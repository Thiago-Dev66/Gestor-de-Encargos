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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorEncargos));
            this.dgvEncargos = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtNumeroVendedor = new System.Windows.Forms.TextBox();
            this.lblNumeroVendedor = new System.Windows.Forms.Label();
            this.btnAgregarVendedor = new System.Windows.Forms.Button();
            this.btnModificarVendedor = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gpbPanelVendedores = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gpbEncargos = new System.Windows.Forms.GroupBox();
            this.gpbArticulos = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gpbPanelVendedores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbEncargos.SuspendLayout();
            this.gpbArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEncargos
            // 
            this.dgvEncargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEncargos.Location = new System.Drawing.Point(26, 67);
            this.dgvEncargos.MultiSelect = false;
            this.dgvEncargos.Name = "dgvEncargos";
            this.dgvEncargos.RowHeadersVisible = false;
            this.dgvEncargos.RowHeadersWidth = 62;
            this.dgvEncargos.RowTemplate.Height = 28;
            this.dgvEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargos.Size = new System.Drawing.Size(1053, 267);
            this.dgvEncargos.TabIndex = 0;
            this.dgvEncargos.SelectionChanged += new System.EventHandler(this.dgvEncargos_SelectionChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(26, 356);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 50);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtNumeroVendedor
            // 
            this.txtNumeroVendedor.Location = new System.Drawing.Point(1246, 57);
            this.txtNumeroVendedor.Name = "txtNumeroVendedor";
            this.txtNumeroVendedor.Size = new System.Drawing.Size(184, 26);
            this.txtNumeroVendedor.TabIndex = 2;
            this.txtNumeroVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroVendedor_KeyDown);
            // 
            // lblNumeroVendedor
            // 
            this.lblNumeroVendedor.AutoSize = true;
            this.lblNumeroVendedor.Location = new System.Drawing.Point(1152, 62);
            this.lblNumeroVendedor.Name = "lblNumeroVendedor";
            this.lblNumeroVendedor.Size = new System.Drawing.Size(79, 20);
            this.lblNumeroVendedor.TabIndex = 3;
            this.lblNumeroVendedor.Text = "Vendedor";
            // 
            // btnAgregarVendedor
            // 
            this.btnAgregarVendedor.Location = new System.Drawing.Point(23, 50);
            this.btnAgregarVendedor.Name = "btnAgregarVendedor";
            this.btnAgregarVendedor.Size = new System.Drawing.Size(197, 50);
            this.btnAgregarVendedor.TabIndex = 4;
            this.btnAgregarVendedor.Text = "Agregar Vendedor";
            this.btnAgregarVendedor.UseVisualStyleBackColor = true;
            this.btnAgregarVendedor.Click += new System.EventHandler(this.btnAgregarVendedor_Click);
            // 
            // btnModificarVendedor
            // 
            this.btnModificarVendedor.Location = new System.Drawing.Point(23, 117);
            this.btnModificarVendedor.Name = "btnModificarVendedor";
            this.btnModificarVendedor.Size = new System.Drawing.Size(195, 50);
            this.btnModificarVendedor.TabIndex = 5;
            this.btnModificarVendedor.Text = "Modificar ";
            this.btnModificarVendedor.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1541, 38);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // gpbPanelVendedores
            // 
            this.gpbPanelVendedores.Controls.Add(this.btnAgregarVendedor);
            this.gpbPanelVendedores.Controls.Add(this.btnModificarVendedor);
            this.gpbPanelVendedores.Location = new System.Drawing.Point(21, 300);
            this.gpbPanelVendedores.Name = "gpbPanelVendedores";
            this.gpbPanelVendedores.Size = new System.Drawing.Size(257, 221);
            this.gpbPanelVendedores.TabIndex = 7;
            this.gpbPanelVendedores.TabStop = false;
            this.gpbPanelVendedores.Text = "Panel Vendedores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarCliente);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 208);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel Clientes";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(23, 50);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(197, 50);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ver Clientes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // gpbEncargos
            // 
            this.gpbEncargos.Controls.Add(this.BtnAgregar);
            this.gpbEncargos.Controls.Add(this.dgvEncargos);
            this.gpbEncargos.Location = new System.Drawing.Point(319, 115);
            this.gpbEncargos.Name = "gpbEncargos";
            this.gpbEncargos.Size = new System.Drawing.Size(1123, 441);
            this.gpbEncargos.TabIndex = 9;
            this.gpbEncargos.TabStop = false;
            this.gpbEncargos.Text = "Panel Encargos";
            // 
            // gpbArticulos
            // 
            this.gpbArticulos.Controls.Add(this.dgvArticulos);
            this.gpbArticulos.Location = new System.Drawing.Point(319, 591);
            this.gpbArticulos.Name = "gpbArticulos";
            this.gpbArticulos.Size = new System.Drawing.Size(766, 279);
            this.gpbArticulos.TabIndex = 10;
            this.gpbArticulos.TabStop = false;
            this.gpbArticulos.Text = "Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(30, 39);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(706, 218);
            this.dgvArticulos.TabIndex = 0;
            // 
            // GestorEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 911);
            this.Controls.Add(this.gpbArticulos);
            this.Controls.Add(this.gpbEncargos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbPanelVendedores);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblNumeroVendedor);
            this.Controls.Add(this.txtNumeroVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GestorEncargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Encargos";
            this.Load += new System.EventHandler(this.GestorEncargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpbPanelVendedores.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbEncargos.ResumeLayout(false);
            this.gpbArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEncargos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtNumeroVendedor;
        private System.Windows.Forms.Label lblNumeroVendedor;
        private System.Windows.Forms.Button btnAgregarVendedor;
        private System.Windows.Forms.Button btnModificarVendedor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox gpbPanelVendedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gpbEncargos;
        private System.Windows.Forms.GroupBox gpbArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}

