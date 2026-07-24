namespace Gestor_de_Encargos
{
    partial class EncargosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpEncargos = new System.Windows.Forms.TableLayoutPanel();
            this.tlpArticulos = new System.Windows.Forms.TableLayoutPanel();
            this.gpbArticulos = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.gpbEncargos = new System.Windows.Forms.GroupBox();
            this.tloDentroPanelEncargos = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNotificar = new System.Windows.Forms.Button();
            this.dgvEncargos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.txtNumeroVendedor = new System.Windows.Forms.TextBox();
            this.lblNumeroVendedor = new System.Windows.Forms.Label();
            this.tlpEncargos.SuspendLayout();
            this.tlpArticulos.SuspendLayout();
            this.gpbArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gpbEncargos.SuspendLayout();
            this.tloDentroPanelEncargos.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEncargos
            // 
            this.tlpEncargos.ColumnCount = 1;
            this.tlpEncargos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncargos.Controls.Add(this.tlpArticulos, 0, 1);
            this.tlpEncargos.Controls.Add(this.gpbEncargos, 0, 0);
            this.tlpEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncargos.Location = new System.Drawing.Point(0, 0);
            this.tlpEncargos.Name = "tlpEncargos";
            this.tlpEncargos.RowCount = 1;
            this.tlpEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpEncargos.Size = new System.Drawing.Size(1204, 686);
            this.tlpEncargos.TabIndex = 2;
            // 
            // tlpArticulos
            // 
            this.tlpArticulos.ColumnCount = 2;
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpArticulos.Controls.Add(this.gpbArticulos, 0, 0);
            this.tlpArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArticulos.Location = new System.Drawing.Point(3, 414);
            this.tlpArticulos.Name = "tlpArticulos";
            this.tlpArticulos.RowCount = 2;
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpArticulos.Size = new System.Drawing.Size(1198, 269);
            this.tlpArticulos.TabIndex = 1;
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
            this.gpbArticulos.Size = new System.Drawing.Size(818, 195);
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 29);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(798, 156);
            this.dgvArticulos.TabIndex = 0;
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
            this.gpbEncargos.Size = new System.Drawing.Size(1184, 391);
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
            this.tloDentroPanelEncargos.Size = new System.Drawing.Size(1164, 352);
            this.tloDentroPanelEncargos.TabIndex = 6;
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.tlpButtons);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotones.Location = new System.Drawing.Point(3, 309);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(1158, 40);
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
            this.tlpButtons.Location = new System.Drawing.Point(0, -18);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(1346, 70);
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
            this.btnDelete.Location = new System.Drawing.Point(408, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(130, 50);
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
            this.BtnAgregar.Location = new System.Drawing.Point(0, 10);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(270, 50);
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
            this.btnModificar.Location = new System.Drawing.Point(274, 10);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificar.Size = new System.Drawing.Size(130, 50);
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
            this.btnNotificar.Location = new System.Drawing.Point(542, 10);
            this.btnNotificar.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNotificar.Size = new System.Drawing.Size(130, 50);
            this.btnNotificar.TabIndex = 3;
            this.btnNotificar.Text = "&Notificar";
            this.btnNotificar.UseVisualStyleBackColor = false;
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click);
            // 
            // dgvEncargos
            // 
            this.dgvEncargos.AllowUserToAddRows = false;
            this.dgvEncargos.AllowUserToDeleteRows = false;
            this.dgvEncargos.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEncargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvEncargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncargos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEncargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncargos.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEncargos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEncargos.Location = new System.Drawing.Point(4, 54);
            this.dgvEncargos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEncargos.MultiSelect = false;
            this.dgvEncargos.Name = "dgvEncargos";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEncargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvEncargos.RowHeadersVisible = false;
            this.dgvEncargos.RowHeadersWidth = 62;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEncargos.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvEncargos.RowTemplate.Height = 28;
            this.dgvEncargos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargos.Size = new System.Drawing.Size(1156, 243);
            this.dgvEncargos.TabIndex = 0;
            this.dgvEncargos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEncargos_CellFormatting);
            this.dgvEncargos.SelectionChanged += new System.EventHandler(this.dgvEncargos_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 44);
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
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1158, 44);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(3, 9);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(67, 26);
            this.lblFiltrar.TabIndex = 0;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFiltrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Location = new System.Drawing.Point(76, 9);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(218, 26);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // txtNumeroVendedor
            // 
            this.txtNumeroVendedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNumeroVendedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNumeroVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroVendedor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNumeroVendedor.Location = new System.Drawing.Point(937, 9);
            this.txtNumeroVendedor.Name = "txtNumeroVendedor";
            this.txtNumeroVendedor.Size = new System.Drawing.Size(218, 26);
            this.txtNumeroVendedor.TabIndex = 0;
            this.txtNumeroVendedor.TextChanged += new System.EventHandler(this.txtNumeroVendedor_TextChanged);
            this.txtNumeroVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroVendedor_KeyDown);
            // 
            // lblNumeroVendedor
            // 
            this.lblNumeroVendedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroVendedor.AutoSize = true;
            this.lblNumeroVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVendedor.Location = new System.Drawing.Point(825, 9);
            this.lblNumeroVendedor.Name = "lblNumeroVendedor";
            this.lblNumeroVendedor.Size = new System.Drawing.Size(106, 26);
            this.lblNumeroVendedor.TabIndex = 3;
            this.lblNumeroVendedor.Text = "Vendedor";
            // 
            // EncargosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 686);
            this.ControlBox = false;
            this.Controls.Add(this.tlpEncargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "EncargosForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.EncargosForm_Load);
            this.tlpEncargos.ResumeLayout(false);
            this.tlpArticulos.ResumeLayout(false);
            this.gpbArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gpbEncargos.ResumeLayout(false);
            this.tloDentroPanelEncargos.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEncargos;
        private System.Windows.Forms.TableLayoutPanel tlpArticulos;
        private System.Windows.Forms.GroupBox gpbArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox gpbEncargos;
        private System.Windows.Forms.TableLayoutPanel tloDentroPanelEncargos;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNotificar;
        private System.Windows.Forms.DataGridView dgvEncargos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.TextBox txtNumeroVendedor;
        private System.Windows.Forms.Label lblNumeroVendedor;
    }
}