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
using Data;
using Data.Repositories;

namespace Gestor_de_Encargos
{
    public partial class AgregarEncargo : Form
    {
        readonly private BindingList<ArticuloEncargo> articulos;
        private ClienteRepository repository;

        public AgregarEncargo()
        {
            InitializeComponent();

            articulos = new BindingList<ArticuloEncargo>();
            dgwListaArticulos.DataSource = articulos;
            
        }
        private void AgregarEncargo_Load(object sender, EventArgs e)
        {
            repository = new ClienteRepository();

            dgwListaArticulos.Columns["Articulo"].Visible = false;
            dgwListaArticulos.Columns["ArticuloID"].Visible = false;
            dgwListaArticulos.Columns["EncargoID"].Visible = false;

            cboEstado.DataSource = Enum.GetValues(typeof(EstadoEncargo));

            cboBuscarCliente.DataSource = repository.GetAll();
            cboBuscarCliente.ValueMember = "Id";
            cboBuscarCliente.DisplayMember = "NombreCompleto";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Encargo encargo = new Encargo()
            {
                Cliente = new Cliente()
            };
            EncargosNegocio encargosNegocio = new EncargosNegocio();
            Cliente seleccionado;

            try
            {
                seleccionado = cboBuscarCliente.SelectedItem as Cliente;

                if (seleccionado == null)
                {
                    MessageBox.Show("Debe haber un cliente seleccionado",
                                    "Cliente Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    cboBuscarCliente.Focus();
                    return;
                }
                encargo.Cliente = seleccionado;

                if (string.IsNullOrEmpty(txtSucursalOrigen.Text))
                {
                    MessageBox.Show("El campo 'Sucursal Origen' no puede estár vacío",
                                    "Campo Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    txtSucursalOrigen.Focus();
                    return;
                }
                encargo.SucursalOrigen = txtSucursalOrigen.Text;
                encargo.Fecha = dtpFecha.Value;
                encargo.Estado = (EstadoEncargo)cboEstado.SelectedItem;
                encargo.Descripcion = txtDetalles.Text;

                if (!articulos.Any())
                {
                    MessageBox.Show("Un encargo no puede no tener articulos!");
                    return;
                }
                encargo.ArticuloEncargo = articulos;
                //encargo.Vendedor.Numero = ?
                //articuloEncargo.PrecioUnitario = Convert.ToDouble(txtPrecioTotal);

                encargosNegocio.Save(encargo);

                MessageBox.Show("Se ha genereado el encargo con éxito!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            
            ArticuloEncargo articuloEncargo = new ArticuloEncargo()
            {
                Articulo = new Articulo()
            };

            try
            {
                if (string.IsNullOrEmpty(txtArticulo.Text))
                {
                    MessageBox.Show("Un articulo debe tener nombre y código",
                                    "Articulo Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtArticulo.Focus();
                    return;
                }
                articuloEncargo.Articulo.Nombre = txtArticulo.Text;

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("Un articulo debe tener nombre y código",
                                    "Articulo Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtCodigo.Focus();
                    return;
                }
                articuloEncargo.Articulo.Codigo = txtCodigo.Text;
                articuloEncargo.Cantidad = (int)nudCantidad.Value;

                articulos.Add(articuloEncargo);

                //dgwListaArticulos.Columns["Articulo"].DisplayIndex = 0;
                //dgwListaArticulos.Columns["Código"].DisplayIndex = 1;
                //dgwListaArticulos.Columns["Cantidad"].DisplayIndex = 2;

            }
            catch (Exception)
            {

                throw;
            }
                       
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (dgwListaArticulos.CurrentRow != null)
            {
                ArticuloEncargo Current
                    = (ArticuloEncargo)dgwListaArticulos.CurrentRow.DataBoundItem;

                articulos.Remove(Current);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("¿Seguro que desea cancelar el encargo?\nSe perderan los datos", 
                                "Cancelar", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) 
                Close();
        }

        private void btnAgregarNuevoCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.ShowDialog();
        }

    }
}
