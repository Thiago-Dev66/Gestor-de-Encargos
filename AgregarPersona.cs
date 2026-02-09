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
using System.Reflection;

namespace Gestor_de_Encargos
{
    public partial class AgregarPersona : Form
    {
        public object PersonaAgregada { get; private set; }
        public DialogResult Result { get; set; }
        private TipoPersona _Tipo {  get; set; }


        public AgregarPersona()
        {
            InitializeComponent();
        }

        public AgregarPersona(TipoPersona tipo)
        {
            InitializeComponent();
            _Tipo = tipo;
        }

        private void AgregarPersona_Load(object sender, EventArgs e)
        {
            if (_Tipo == TipoPersona.Cliente)
            {
                Text = "Agregar Cliente";

                lblContacto.Text = "Contacto";
            }
            else
            {
                Text = "Agregar Vendedor";

                lblContacto.Text = "Número";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            Vendedor vendedor;
            ClienteNegocio clienteNegocio;
            VendedorNegocio vendedorNegocio;

            try
            {
                
               if (_Tipo == TipoPersona.Cliente)
                {
                    cliente = new Cliente();
                    clienteNegocio = new ClienteNegocio();

                    ValidarCliente(txtNombre, "El cliente debe tener un nombre");
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;

                    ValidarCliente(txtContacto, "El cliente debe tener un contacto");
                    cliente.Celular = txtContacto.Text;

                    clienteNegocio.AddCliente(cliente);
                    PersonaAgregada = cliente;


                    MessageBox.Show("Se agregó con éxito!",
                                            "Cliente Nuevo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                    Result = DialogResult.OK;
                    Close();
                }
                else
                {
                    vendedor = new Vendedor();
                    vendedorNegocio = new VendedorNegocio();

                    vendedor.Nombre = txtNombre.Text;
                    vendedor.Apellido = txtApellido.Text;

                    if (!(int.TryParse(txtContacto.Text, out int val)))
                    {
                        MessageBox.Show("El campo 'Número' debe ser solo números");
                        return;
                    }
                    vendedor.Numero = val;

                    vendedorNegocio.AddVendedor(vendedor);
                    PersonaAgregada = vendedor;

                    MessageBox.Show("Vendedor agregado con éxito!",
                                            "Cliente Nuevo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                    Result = DialogResult.OK;
                    Close();
                }
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

    public enum TipoPersona
    {
        Cliente,
        Vendedor
    }
}
