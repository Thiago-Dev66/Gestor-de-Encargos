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
using Data.Repositories;
using Dominio.Interfaces;

namespace Gestor_de_Encargos
{
    public partial class AgregarPersona : Form
    {
        public object Persona { get; private set; }
        private TipoPersona _Tipo { get; set; }
        private readonly VendedorNegocio _VendedorNegocio;
        private readonly ClienteNegocio _ClienteNegocio;

        public AgregarPersona(TipoPersona tipo, VendedorNegocio vendedorNegocio = null, 
                                ClienteNegocio clienteNegocio = null, object persona = null)
        {
            InitializeComponent();
            _Tipo = tipo;
            Persona = persona;
            if (tipo == TipoPersona.Cliente)
                _ClienteNegocio = clienteNegocio;
            else
                _VendedorNegocio = vendedorNegocio;
        }

        private void AgregarPersona_Load(object sender, EventArgs e)
        {
            if (Persona != null)
            {
                if (_Tipo == TipoPersona.Cliente)
                {
                    Text = "Modificar Cliente";
                    btnGuardar.Text = "Modificar";
                    lblContacto.Text = "Contacto";

                    txtNombre.Text = ((Cliente)Persona).Nombre;
                    txtApellido.Text = ((Cliente)Persona).Apellido;
                    txtContacto.Text = ((Cliente)Persona).Celular;
                }
                else
                {
                    Text = "Modificar Vendedor";
                    btnGuardar.Text = "Modificar";
                    lblContacto.Text = "Número";

                    txtNombre.Text = ((Vendedor)Persona).Nombre;
                    txtApellido.Text = ((Vendedor)Persona).Apellido;
                    txtContacto.Text = ((Vendedor)Persona).Numero.ToString();
                }
            }
            else
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Tipo == TipoPersona.Cliente)
                {
                    var cliente = new Cliente();
                    var clienteNegocio = new ClienteNegocio(new ClienteRepository());
                    Cliente existente;

                    if (!(ValidarPersona(txtNombre, "El cliente debe tener un nombre"))) return;
                    if (!(SoloLetras(txtNombre))) return;
                    if (!(SoloLetras(txtApellido))) return;
                    if (!ValidarPersona(txtContacto, "El cliente debe tener un contacto")) return;

                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Celular = txtContacto.Text;

                    if (Persona != null)
                    {
                        cliente.Id = ((Cliente)Persona).Id;
                        clienteNegocio.Modificar(cliente);

                        MessageBox.Show("Se modificó con éxito!",
                                        "Cliente Modificado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                        return;
                    }
                    existente = clienteNegocio.Add(cliente);

                    //Arreglar bug al querer agregar un cliente cuyo numero de contacto ya existe. 

                    if (existente == null)
                    {
                        Persona = cliente;

                        MessageBox.Show("Se agregó con éxito!",
                                            "Cliente Nuevo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                        Close();
                    }
                    else
                    {
                        Persona = existente;

                        MessageBox.Show("El cliente ya existe!",
                                            "Cliente Nuevo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    var vendedor = new Vendedor();

                    if (!(ValidarPersona(txtNombre, "Un vendedor debe tener un nombre"))) return;
                    if (!(SoloLetras(txtNombre))) return;
                    if (!(ValidarPersona(txtApellido, "Un vendedor debe tener un apellido"))) return;
                    if (!(SoloLetras(txtApellido))) return;
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

                    vendedor.Nombre = txtNombre.Text;
                    vendedor.Apellido = txtApellido.Text;
                    vendedor.Numero = val;

                    if (Persona != null)
                    {
                        vendedor.Id = ((Vendedor)Persona).Id;
                        _VendedorNegocio.Update(vendedor);

                        MessageBox.Show("Se modificó con éxito!",
                                        "Vendedor Modificado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                        return;
                    }

                    _VendedorNegocio.Add(vendedor);
                    Persona = vendedor;

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
