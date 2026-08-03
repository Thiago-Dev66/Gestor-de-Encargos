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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorEncargos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEncargos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.formsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2086, 2187);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(4098, 1834);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.btnEncargos);
            this.flowLayoutPanel1.Controls.Add(this.btnClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnVendedores);
            this.flowLayoutPanel1.Controls.Add(this.btnArticulos);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.errorProvider1.SetIconAlignment(this.flowLayoutPanel1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 150);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 323);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnEncargos
            // 
            this.btnEncargos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEncargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncargos.FlatAppearance.BorderSize = 0;
            this.btnEncargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncargos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncargos.Location = new System.Drawing.Point(3, 3);
            this.btnEncargos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnEncargos.Name = "btnEncargos";
            this.btnEncargos.Size = new System.Drawing.Size(340, 64);
            this.btnEncargos.TabIndex = 0;
            this.btnEncargos.Text = "Encargos";
            this.btnEncargos.UseVisualStyleBackColor = false;
            this.btnEncargos.Click += new System.EventHandler(this.btnEncargos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Location = new System.Drawing.Point(3, 85);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(336, 64);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendedores.FlatAppearance.BorderSize = 0;
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVendedores.Location = new System.Drawing.Point(3, 167);
            this.btnVendedores.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(336, 64);
            this.btnVendedores.TabIndex = 2;
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.UseVisualStyleBackColor = false;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArticulos.Location = new System.Drawing.Point(3, 249);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(336, 64);
            this.btnArticulos.TabIndex = 3;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.DodgerBlue;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tlpPrincipal.Controls.Add(this.panelOpciones, 0, 1);
            this.tlpPrincipal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpPrincipal.Size = new System.Drawing.Size(341, 700);
            this.tlpPrincipal.TabIndex = 12;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.btnOpciones);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOpciones.Location = new System.Drawing.Point(3, 631);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(335, 66);
            this.panelOpciones.TabIndex = 1;
            // 
            // btnOpciones
            // 
            this.btnOpciones.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpciones.Location = new System.Drawing.Point(0, 0);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(335, 64);
            this.btnOpciones.TabIndex = 4;
            this.btnOpciones.Text = "Opciones";
            this.btnOpciones.UseVisualStyleBackColor = false;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // formsPanel
            // 
            this.formsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPanel.Location = new System.Drawing.Point(341, 0);
            this.formsPanel.Name = "formsPanel";
            this.formsPanel.Size = new System.Drawing.Size(943, 700);
            this.formsPanel.TabIndex = 14;
            // 
            // GestorEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 700);
            this.Controls.Add(this.formsPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1268, 692);
            this.Name = "GestorEncargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Encargos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestorEncargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEncargos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Panel formsPanel;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnOpciones;
    }
}

