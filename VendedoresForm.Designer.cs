namespace Gestor_de_Encargos
{
    partial class VendedoresForm
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
            this.grbVendedores = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grbVendedores.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbVendedores
            // 
            this.grbVendedores.Controls.Add(this.tableLayoutPanel1);
            this.grbVendedores.Location = new System.Drawing.Point(40, 13);
            this.grbVendedores.Name = "grbVendedores";
            this.grbVendedores.Size = new System.Drawing.Size(1004, 603);
            this.grbVendedores.TabIndex = 2;
            this.grbVendedores.TabStop = false;
            this.grbVendedores.Text = "Vendedores";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvVendedores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpButtons, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.39101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.609F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(988, 581);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVendedores.Location = new System.Drawing.Point(3, 3);
            this.dgvVendedores.MultiSelect = false;
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.RowHeadersVisible = false;
            this.dgvVendedores.RowHeadersWidth = 62;
            this.dgvVendedores.RowTemplate.Height = 28;
            this.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedores.Size = new System.Drawing.Size(982, 475);
            this.dgvVendedores.TabIndex = 0;
            // 
            // flpButtons
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flpButtons, 3);
            this.flpButtons.Controls.Add(this.btnAgregar);
            this.flpButtons.Controls.Add(this.btnModificar);
            this.flpButtons.Controls.Add(this.btnEliminar);
            this.flpButtons.Location = new System.Drawing.Point(3, 487);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(414, 90);
            this.flpButtons.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(139, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 50);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(275, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 50);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // VendedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 632);
            this.ControlBox = false;
            this.Controls.Add(this.grbVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "VendedoresForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Vendedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendedoresForm_Load);
            this.grbVendedores.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVendedores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}