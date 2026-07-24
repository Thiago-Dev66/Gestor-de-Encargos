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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.rdbWhatsapp = new System.Windows.Forms.RadioButton();
            this.rdbEmail = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this.grbOpciones.Size = new System.Drawing.Size(1042, 590);
            this.grbOpciones.TabIndex = 1;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // grpMensajeClientes
            // 
            this.grpMensajeClientes.Controls.Add(this.label1);
            this.grpMensajeClientes.Controls.Add(this.rdbEmail);
            this.grpMensajeClientes.Controls.Add(this.rdbWhatsapp);
            this.grpMensajeClientes.Controls.Add(this.lblEnviar);
            this.grpMensajeClientes.Controls.Add(this.textBox1);
            this.grpMensajeClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMensajeClientes.Location = new System.Drawing.Point(20, 41);
            this.grpMensajeClientes.Margin = new System.Windows.Forms.Padding(15);
            this.grpMensajeClientes.Name = "grpMensajeClientes";
            this.grpMensajeClientes.Size = new System.Drawing.Size(1002, 529);
            this.grpMensajeClientes.TabIndex = 0;
            this.grpMensajeClientes.TabStop = false;
            this.grpMensajeClientes.Text = "Mensaje a Clientes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 290);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(660, 216);
            this.textBox1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensaje:";
            // 
            // OpcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 668);
            this.Controls.Add(this.grbOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionesForm";
            this.Text = "Opciones";
            this.grbOpciones.ResumeLayout(false);
            this.grpMensajeClientes.ResumeLayout(false);
            this.grpMensajeClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.GroupBox grpMensajeClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbEmail;
        private System.Windows.Forms.RadioButton rdbWhatsapp;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.Label label1;
    }
}