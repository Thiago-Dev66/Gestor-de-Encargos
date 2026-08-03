namespace Gestor_de_Encargos
{
    partial class OpcionesForm
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
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.grpMensajeClientes = new System.Windows.Forms.GroupBox();
            this.lblVendedorNombre = new System.Windows.Forms.Label();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.rdbEmail = new System.Windows.Forms.RadioButton();
            this.rdbWhatsapp = new System.Windows.Forms.RadioButton();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.grbOpciones.SuspendLayout();
            this.grpMensajeClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOpciones
            // 
            this.grbOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbOpciones.Controls.Add(this.grpMensajeClientes);
            this.grbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOpciones.Location = new System.Drawing.Point(39, 39);
            this.grbOpciones.Margin = new System.Windows.Forms.Padding(30);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Padding = new System.Windows.Forms.Padding(20);
            this.grbOpciones.Size = new System.Drawing.Size(1160, 656);
            this.grbOpciones.TabIndex = 1;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // grpMensajeClientes
            // 
            this.grpMensajeClientes.Controls.Add(this.lblVendedorNombre);
            this.grpMensajeClientes.Controls.Add(this.lblArticulos);
            this.grpMensajeClientes.Controls.Add(this.lblClienteNombre);
            this.grpMensajeClientes.Controls.Add(this.label1);
            this.grpMensajeClientes.Controls.Add(this.btnRestablecer);
            this.grpMensajeClientes.Controls.Add(this.txtGuardar);
            this.grpMensajeClientes.Controls.Add(this.lblMensaje);
            this.grpMensajeClientes.Controls.Add(this.rdbEmail);
            this.grpMensajeClientes.Controls.Add(this.rdbWhatsapp);
            this.grpMensajeClientes.Controls.Add(this.lblEnviar);
            this.grpMensajeClientes.Controls.Add(this.txtMensaje);
            this.grpMensajeClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMensajeClientes.Location = new System.Drawing.Point(20, 41);
            this.grpMensajeClientes.Margin = new System.Windows.Forms.Padding(15);
            this.grpMensajeClientes.Name = "grpMensajeClientes";
            this.grpMensajeClientes.Size = new System.Drawing.Size(1120, 595);
            this.grpMensajeClientes.TabIndex = 0;
            this.grpMensajeClientes.TabStop = false;
            this.grpMensajeClientes.Text = "Mensaje a Clientes";
            // 
            // lblVendedorNombre
            // 
            this.lblVendedorNombre.AutoSize = true;
            this.lblVendedorNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVendedorNombre.Location = new System.Drawing.Point(739, 338);
            this.lblVendedorNombre.Name = "lblVendedorNombre";
            this.lblVendedorNombre.Size = new System.Drawing.Size(179, 22);
            this.lblVendedorNombre.TabIndex = 10;
            this.lblVendedorNombre.Text = "{VendedorNombre}";
            this.lblVendedorNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVendedorNombre_MouseDown);
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArticulos.Location = new System.Drawing.Point(739, 419);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(102, 22);
            this.lblArticulos.TabIndex = 9;
            this.lblArticulos.Text = "{Articulos}";
            this.lblArticulos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblArticulos_MouseDown);
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClienteNombre.Location = new System.Drawing.Point(739, 377);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(156, 22);
            this.lblClienteNombre.TabIndex = 8;
            this.lblClienteNombre.Text = "{ClienteNombre}";
            this.lblClienteNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblClienteNombre_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(739, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 200);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tags disponibles:\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nArrastra las etiquetas y sueltalas donde \r\nquier" +
    "as que los datos aparezcan";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestablecer.Location = new System.Drawing.Point(586, 512);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(130, 50);
            this.btnRestablecer.TabIndex = 6;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // txtGuardar
            // 
            this.txtGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGuardar.Location = new System.Drawing.Point(450, 512);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(130, 50);
            this.txtGuardar.TabIndex = 5;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.UseVisualStyleBackColor = false;
            this.txtGuardar.Click += new System.EventHandler(this.txtGuardar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(52, 244);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(82, 22);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // rdbEmail
            // 
            this.rdbEmail.AutoSize = true;
            this.rdbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmail.Location = new System.Drawing.Point(99, 177);
            this.rdbEmail.Name = "rdbEmail";
            this.rdbEmail.Size = new System.Drawing.Size(79, 26);
            this.rdbEmail.TabIndex = 3;
            this.rdbEmail.Text = "Email";
            this.rdbEmail.UseVisualStyleBackColor = true;
            // 
            // rdbWhatsapp
            // 
            this.rdbWhatsapp.AutoSize = true;
            this.rdbWhatsapp.Checked = true;
            this.rdbWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWhatsapp.Location = new System.Drawing.Point(99, 135);
            this.rdbWhatsapp.Name = "rdbWhatsapp";
            this.rdbWhatsapp.Size = new System.Drawing.Size(118, 26);
            this.rdbWhatsapp.TabIndex = 2;
            this.rdbWhatsapp.TabStop = true;
            this.rdbWhatsapp.Text = "WhatsApp";
            this.rdbWhatsapp.UseVisualStyleBackColor = true;
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.Location = new System.Drawing.Point(52, 79);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(112, 22);
            this.lblEnviar.TabIndex = 1;
            this.lblEnviar.Text = "Notificar por:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.AllowDrop = true;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(56, 290);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(660, 216);
            this.txtMensaje.TabIndex = 0;
            this.txtMensaje.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtMensaje_DragDrop);
            this.txtMensaje.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtMensaje_DragEnter);
            // 
            // OpcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 734);
            this.Controls.Add(this.grbOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionesForm";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.OpcionesForm_Load);
            this.grbOpciones.ResumeLayout(false);
            this.grpMensajeClientes.ResumeLayout(false);
            this.grpMensajeClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.GroupBox grpMensajeClientes;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.RadioButton rdbEmail;
        private System.Windows.Forms.RadioButton rdbWhatsapp;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button txtGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblVendedorNombre;
        private System.Windows.Forms.Label lblArticulos;
    }
}