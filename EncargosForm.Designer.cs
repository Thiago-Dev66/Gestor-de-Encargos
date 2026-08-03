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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpEncargos = new System.Windows.Forms.TableLayoutPanel();
            this.tlpArticulos = new System.Windows.Forms.TableLayoutPanel();
            this.gpbArticulos = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.gpbEncargos = new System.Windows.Forms.GroupBox();
            this.tloDentroPanelEncargos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEncargos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.txtNumeroVendedor = new System.Windows.Forms.TextBox();
            this.lblNumeroVendedor = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNotificar = new System.Windows.Forms.Button();
            this.tlpEncargos.SuspendLayout();
            this.tlpArticulos.SuspendLayout();
            this.gpbArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gpbEncargos.SuspendLayout();
            this.tloDentroPanelEncargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlButtons.SuspendLayout();
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
            this.tlpEncargos.Size = new System.Drawing.Size(1135, 709);
            this.tlpEncargos.TabIndex = 2;
            // 
            // tlpArticulos
            // 
            this.tlpArticulos.ColumnCount = 2;
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpArticulos.Controls.Add(this.gpbArticulos, 0, 0);
            this.tlpArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArticulos.Location = new System.Drawing.Point(3, 428);
            this.tlpArticulos.Name = "tlpArticulos";
            this.tlpArticulos.RowCount = 2;
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpArticulos.Size = new System.Drawing.Size(1129, 278);
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
            this.gpbArticulos.Size = new System.Drawing.Size(770, 202);
            this.gpbArticulos.TabIndex = 10;
            this.gpbArticulos.TabStop = false;
            this.gpbArticulos.Text = "Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 29);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(750, 163);
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
            this.gpbEncargos.Size = new System.Drawing.Size(1115, 405);
            this.gpbEncargos.TabIndex = 9;
            this.gpbEncargos.TabStop = false;
            this.gpbEncargos.Text = "Panel Encargos";
            // 
            // tloDentroPanelEncargos
            // 
            this.tloDentroPanelEncargos.ColumnCount = 1;
            this.tloDentroPanelEncargos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tloDentroPanelEncargos.Controls.Add(this.dgvEncargos, 0, 0);
            this.tloDentroPanelEncargos.Controls.Add(this.panel2, 0, 0);
            this.tloDentroPanelEncargos.Controls.Add(this.pnlButtons, 0, 2);
            this.tloDentroPanelEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tloDentroPanelEncargos.Location = new System.Drawing.Point(10, 29);
            this.tloDentroPanelEncargos.Name = "tloDentroPanelEncargos";
            this.tloDentroPanelEncargos.RowCount = 3;
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.79747F));
            this.tloDentroPanelEncargos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.20253F));
            this.tloDentroPanelEncargos.Size = new System.Drawing.Size(1095, 366);
            this.tloDentroPanelEncargos.TabIndex = 6;
            // 
            // dgvEncargos
            // 
            this.dgvEncargos.AllowUserToAddRows = false;
            this.dgvEncargos.AllowUserToDeleteRows = false;
            this.dgvEncargos.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEncargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEncargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncargos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEncargos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEncargos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEncargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncargos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEncargos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEncargos.Location = new System.Drawing.Point(4, 54);
            this.dgvEncargos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEncargos.MultiSelect = false;
            this.dgvEncargos.Name = "dgvEncargos";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEncargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEncargos.RowHeadersVisible = false;
            this.dgvEncargos.RowHeadersWidth = 62;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEncargos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEncargos.RowTemplate.Height = 28;
            this.dgvEncargos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargos.Size = new System.Drawing.Size(1087, 241);
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
            this.panel2.Size = new System.Drawing.Size(1089, 44);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1089, 44);
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
            this.txtNumeroVendedor.Location = new System.Drawing.Point(868, 9);
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
            this.lblNumeroVendedor.Location = new System.Drawing.Point(756, 9);
            this.lblNumeroVendedor.Name = "lblNumeroVendedor";
            this.lblNumeroVendedor.Size = new System.Drawing.Size(106, 26);
            this.lblNumeroVendedor.TabIndex = 3;
            this.lblNumeroVendedor.Text = "Vendedor";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.BtnAgregar);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnModificar);
            this.pnlButtons.Controls.Add(this.btnNotificar);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(3, 302);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1089, 61);
            this.pnlButtons.TabIndex = 7;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar.Location = new System.Drawing.Point(7, 7);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(270, 50);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(415, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(130, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(281, 7);
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
            this.btnNotificar.BackColor = System.Drawing.Color.Green;
            this.btnNotificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotificar.Location = new System.Drawing.Point(549, 7);
            this.btnNotificar.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNotificar.Size = new System.Drawing.Size(130, 50);
            this.btnNotificar.TabIndex = 3;
            this.btnNotificar.Text = "&Notificar";
            this.btnNotificar.UseVisualStyleBackColor = false;
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click);
            // 
            // EncargosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 709);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEncargos;
        private System.Windows.Forms.TableLayoutPanel tlpArticulos;
        private System.Windows.Forms.GroupBox gpbArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox gpbEncargos;
        private System.Windows.Forms.TableLayoutPanel tloDentroPanelEncargos;
        private System.Windows.Forms.DataGridView dgvEncargos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.TextBox txtNumeroVendedor;
        private System.Windows.Forms.Label lblNumeroVendedor;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNotificar;
    }
}