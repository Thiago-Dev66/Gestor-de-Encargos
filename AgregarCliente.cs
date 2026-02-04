using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El cliente debe tener un nombre",
                                    "Campo Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;

                if (string.IsNullOrEmpty(txtContacto.Text))
                {
                    MessageBox.Show("El cliente debe tener un contacto",
                                    "Campo Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtContacto.Focus();
                    return;
                }
                cliente.Celular = txtContacto.Text;

                clienteNegocio.AddCliente(cliente);

                MessageBox.Show("Se agregó con éxito!");
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
    }
}
