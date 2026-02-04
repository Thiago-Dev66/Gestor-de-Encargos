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
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gpbPanelClientes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gpbPanelClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEncargos
            // 
            this.dgvEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargos.Location = new System.Drawing.Point(385, 194);
            this.dgvEncargos.Name = "dgvEncargos";
            this.dgvEncargos.RowHeadersWidth = 62;
            this.dgvEncargos.RowTemplate.Height = 28;
            this.dgvEncargos.Size = new System.Drawing.Size(843, 267);
            this.dgvEncargos.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(385, 480);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 50);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtNumeroVendedor
            // 
            this.txtNumeroVendedor.Location = new System.Drawing.Point(1013, 125);
            this.txtNumeroVendedor.Name = "txtNumeroVendedor";
            this.txtNumeroVendedor.Size = new System.Drawing.Size(184, 26);
            this.txtNumeroVendedor.TabIndex = 2;
            // 
            // lblNumeroVendedor
            // 
            this.lblNumeroVendedor.AutoSize = true;
            this.lblNumeroVendedor.Location = new System.Drawing.Point(919, 131);
            this.lblNumeroVendedor.Name = "lblNumeroVendedor";
            this.lblNumeroVendedor.Size = new System.Drawing.Size(79, 20);
            this.lblNumeroVendedor.TabIndex = 3;
            this.lblNumeroVendedor.Text = "Vendedor";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(23, 50);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(197, 50);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ver Clientes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1359, 33);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // gpbPanelClientes
            // 
            this.gpbPanelClientes.Controls.Add(this.btnAgregarCliente);
            this.gpbPanelClientes.Controls.Add(this.button1);
            this.gpbPanelClientes.Location = new System.Drawing.Point(21, 165);
            this.gpbPanelClientes.Name = "gpbPanelClientes";
            this.gpbPanelClientes.Size = new System.Drawing.Size(257, 331);
            this.gpbPanelClientes.TabIndex = 7;
            this.gpbPanelClientes.TabStop = false;
            this.gpbPanelClientes.Text = "Panel Clientes";
            // 
            // GestorEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 681);
            this.Controls.Add(this.gpbPanelClientes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblNumeroVendedor);
            this.Controls.Add(this.txtNumeroVendedor);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvEncargos);
            this.Name = "GestorEncargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Encargos";
            this.Load += new System.EventHandler(this.GestorEncargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpbPanelClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEncargos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtNumeroVendedor;
        private System.Windows.Forms.Label lblNumeroVendedor;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox gpbPanelClientes;
    }
}

