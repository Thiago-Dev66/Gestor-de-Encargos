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
        public GestorEncargos()
        {
            InitializeComponent();
            BtnAgregar.Enabled = false;
            txtNumeroVendedor.Focus();
        }

        private void GestorEncargos_Load(object sender, EventArgs e)
        {
            EncargosRepository encargos = new EncargosRepository();
            dgvEncargos.DataSource = encargos.GetAll();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEncargo agregarEncargo = new AgregarEncargo(_Vendedor);
            agregarEncargo.ShowDialog();    
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
    }
}
