using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Encargos
{
    public partial class AgregarArticuloForm : Form
    {
        private Articulo _articulo;
        private readonly ArticulosNegocio _negocio;

        public AgregarArticuloForm(ArticulosNegocio negocio, Articulo articulo = null)
        {
            InitializeComponent();
            _negocio = negocio;
            _articulo = articulo;
        }

        private void AgregarArticuloForm_Load(object sender, EventArgs e)
        {
            if (_articulo != null)
            {
                Text = "Modificar Artículo";

                txtNombre.Text = _articulo.Nombre;
                txtCodigo.Text = _articulo.Codigo;
                txtPrecio.Text = _articulo.Precio.ToString();
            }
            else
                Text = "Agregar Artículo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_articulo == null)
                    _articulo = new Articulo();

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del artículo no puede estar vacío.",
                                    "Error de Validación",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error
                                     );
                    return;
                }
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("El código del artículo no puede estar vacío.",
                                    "Error de Validación",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error
                                     );
                    return;
                }
                _articulo.Nombre = txtNombre.Text;
                _articulo.Codigo = txtCodigo.Text;

                if (double.TryParse(txtPrecio.Text, out double val))
                    _articulo.Precio = val;
                else
                {
                    MessageBox.Show("El precio ingresado no es válido. Por favor, ingrese un número válido.",
                                    "Error de Validación",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error
                                     );
                    return;
                }

                if (_articulo.Id == 0)
                {
                    _negocio.Add(_articulo);
                    MessageBox.Show("Se ha agregado exitosamente",
                                    "Agregar Articulo", 
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information
                                     );
                    Close();
                }
                else
                {
                    _negocio.Update(_articulo);
                    MessageBox.Show("Se ha modificado exitosamente",
                                    "Modificar Articulo",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information
                                     );
                    Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
