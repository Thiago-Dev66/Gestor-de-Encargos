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
        public int _NumeroVendedor { get; private set; }
        public GestorEncargos()
        {
            InitializeComponent();
        }

        private void GestorEncargos_Load(object sender, EventArgs e)
        {
            EncargosRepository encargos = new EncargosRepository();
            dgvEncargos.DataSource = encargos.GetAll();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEncargo agregarEncargo = new AgregarEncargo();
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

        public int ValidarNumero(string numero)
        {
            if (!(int.TryParse(numero, out int val)))
            {
                MessageBox.Show("El número de vendedor no es correcto");
                return 0;
            }
            return val;
        }
        public void ValidarVendedor(int val)
        {
            VendedorNegocio negocio;
            negocio = new VendedorNegocio();


            if (negocio.ValidarVendedor(val))
            {
                MessageBox.Show("!");
                _NumeroVendedor = val;
                BtnAgregar.Focus();
            }
            else
                MessageBox.Show("El número de vendedor no es correcto");
        }
        private void txtNumeroVendedor_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) 
            {
                int val = ValidarNumero(txtNumeroVendedor.Text);

                ValidarVendedor(val);
            }
        }
    }
}
