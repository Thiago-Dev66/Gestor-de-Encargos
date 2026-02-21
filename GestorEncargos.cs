using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Repositories;
using Dominio;
using Negocio;

namespace Gestor_de_Encargos
{
    public partial class GestorEncargos : Form
    {
        private Vendedor _Vendedor { get; set; }
        private EncargosRepository encargos = new EncargosRepository();
        private ArticuloRepository articulos = new ArticuloRepository();

        public GestorEncargos()
        {
            InitializeComponent();
            BtnAgregar.Enabled = false;
        }

        private void GestorEncargos_Load(object sender, EventArgs e)
        {
            dgvEncargos.DataSource = encargos.GetAll();
            txtNumeroVendedor.Focus();

            OcultarColumnas();

        }

        private void OcultarColumnas()
        {
            dgvEncargos.Columns["Id"].Visible = false;
            dgvEncargos.Columns["Vendedor"].Visible = false;
            dgvEncargos.Columns["Cliente"].Visible = false;

            dgvEncargos.Columns["ClienteNombre"].DisplayIndex = 0;
            dgvEncargos.Columns["ClienteCelular"].DisplayIndex = 1;
            dgvEncargos.Columns["SucursalOrigen"].DisplayIndex = 3;

            dgvArticulos.Columns["ArticuloID"].Visible = false;
            dgvArticulos.Columns["Articulo"].Visible = false;
            dgvArticulos.Columns["EncargoID"].Visible = false;

            dgvArticulos.Columns["ArticuloNombre"].DisplayIndex = 0;
            dgvArticulos.Columns["ArticuloCodigo"].DisplayIndex = 1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEncargo agregarEncargo = new AgregarEncargo(_Vendedor);
            DialogResult result = agregarEncargo.ShowDialog();

            if (result == DialogResult.OK)
            {
                dgvEncargos.DataSource = null;
                dgvEncargos.DataSource = encargos.GetAll();
                OcultarColumnas();
            }
        }

        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {
            AgregarPersona agregarPersona = new AgregarPersona(TipoPersona.Cliente);
            agregarPersona.ShowDialog();
        }

        private void btnAgregarVendedor_Click(object sender, EventArgs e)
        {
            AgregarPersona agregarCliente = new AgregarPersona(TipoPersona.Vendedor);
            agregarCliente.ShowDialog();
        }

        public void ValidarVendedor(int numeroVendedor)
        {
            VendedorNegocio negocio;
            negocio = new VendedorNegocio();
            object obj;

            obj = negocio.ValidarVendedor(numeroVendedor);

            if (obj != null)
            {
                _Vendedor = (Vendedor)obj;
                BtnAgregar.Enabled = true;
                BtnAgregar.Focus();
            }
            else
                MessageBox.Show("El número de vendedor no es correcto");
        }
        private void txtNumeroVendedor_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) 
            {
                if ((int.TryParse(txtNumeroVendedor.Text, out int val)))
                    ValidarVendedor(val);
                else
                    MessageBox.Show("Debe ser un número");
            }
        }
        private void dgvEncargos_SelectionChanged(object sender, EventArgs e)
        {
            Encargo encargo = (Encargo)dgvEncargos.CurrentRow.DataBoundItem;
            dgvArticulos.DataSource = articulos.GetArticulosByEncargoId(encargo.Id);

            OcultarColumnas();
        }


    }
}
