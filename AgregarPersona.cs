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
        private TipoPersona _Tipo { get; set; }


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
            try
            {
                if (_Tipo == TipoPersona.Cliente)
                {
                    var cliente = new Cliente();
                    var clienteNegocio = new ClienteNegocio();
                    Cliente existente;

                    if (!(ValidarPersona(txtNombre, "El cliente debe tener un nombre"))) return;
                    if (!(SoloLetras(txtNombre))) return;

                    cliente.Nombre = txtNombre.Text;

                    if (!(SoloLetras(txtApellido))) return;

                    cliente.Apellido = txtApellido.Text;

                    if (!(ValidarPersona(txtContacto, "El cliente debe tener un contacto")))
                        return;

                    cliente.Celular = txtContacto.Text;

                    existente = clienteNegocio.Add(cliente);

                    if (existente == null)
                    {
                        PersonaAgregada = cliente;

                        MessageBox.Show("Se agregó con éxito!",
                                            "Cliente Nuevo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                        Close();
                    }
                    else
                    {
                        PersonaAgregada = existente;

                        MessageBox.Show("El cliente ya existe!",
                                            "Cliente Nuevo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    var vendedor = new Vendedor();
                    var vendedorNegocio = new VendedorNegocio();

                    if (!(ValidarPersona(txtNombre, "Un vendedor debe tener un nombre"))) return;
                    if (!(SoloLetras(txtNombre))) return;

                    vendedor.Nombre = txtNombre.Text;

                    if (!(ValidarPersona(txtApellido, "Un vendedor debe tener un apellido"))) return;
                    if (!(SoloLetras(txtApellido))) return;

                    vendedor.Apellido = txtApellido.Text;

                    if (!(int.TryParse(txtContacto.Text, out int val)))
                    {
                        MessageBox.Show("El campo 'Número' debe ser solo números");
                        return;
                    }
                    if (val <= 0)
                    {
                        MessageBox.Show("El número de vendedor no puede ser menor o igual a cero");
                        return;
                    }
                    vendedor.Numero = val;

                    vendedorNegocio.Add(vendedor);
                    PersonaAgregada = vendedor;

                    MessageBox.Show("Vendedor agregado con éxito!",
                                            "Cliente Nuevo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                    Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "El vendedor ya existe")
                {
                    MessageBox.Show("Ya existe un vendedor con ese número");
                    return;
                }

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
                this.Close();
        }
        public bool ValidarPersona(TextBox txtCampo, string mensaje)
        {
            if (string.IsNullOrEmpty(txtCampo.Text))
            {
                MessageBox.Show(mensaje,
                                "Campo Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCampo.Focus();
                return false;
            }
            if (txtCampo.Text.Length < 3)
            {
                MessageBox.Show("El campo debe tener más de tres caracteres",
                                "Campo Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCampo.Focus();
                return false;
            }
            return true;
        }
        public bool SoloLetras(TextBox campo)
        {
            if (!(campo.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))))
            {
                MessageBox.Show("El campo no puede contener números ni espacios",
                                "Campo Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                campo.Focus();
                return false;
            }
            return true;
        }
    }

    public enum TipoPersona
    {
        Cliente,
        Vendedor
    }
}
