using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Gestor_de_Encargos
{
    public partial class AgregarCliente : Form
    {
        public Cliente clienteAgregado { get; private set; }
        public DialogResult Result { get; set; }


        public AgregarCliente()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            try
            {
                
                ValidarCliente(txtNombre, "El cliente debe tener un nombre");
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;

                ValidarCliente(txtContacto, "El cliente debe tener un contacto");
                cliente.Celular = txtContacto.Text;

                clienteNegocio.AddCliente(cliente);
                clienteAgregado = cliente;

                
                DialogResult = MessageBox.Show("Se agregó con éxito!",
                                        "Cliente Nuevo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                Result = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                MessageBox.Show("¿Seguro que desea cancelar?\nSe perderan los datos",
                                "Cancelar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
        public void ValidarCliente(TextBox txtCampo, string mensaje)
        {

            if (string.IsNullOrEmpty(txtCampo.Text))
            {
                MessageBox.Show(mensaje,
                                "Campo Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCampo.Focus();
                return;
            }
        }
    }
}
