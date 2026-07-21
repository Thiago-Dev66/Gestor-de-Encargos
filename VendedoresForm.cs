using Negocio;
using Dominio;
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
    public partial class VendedoresForm : Form
    {
        private readonly VendedorNegocio _negocio;

        public VendedoresForm(VendedorNegocio negocio)
        {
            InitializeComponent();
            _negocio = negocio;
        }

        private void VendedoresForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvVendedores.DataSource = null;
            dgvVendedores.DataSource = _negocio.GetAll();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new AgregarPersona(TipoPersona.Vendedor, _negocio);
            form.ShowDialog();
            LoadData();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var vendedor = new Vendedor();
            Form form;

            try
            {
                if (dgvVendedores.CurrentRow?.DataBoundItem is Vendedor)
                    vendedor = (Vendedor)dgvVendedores.CurrentRow.DataBoundItem;
                else
                {
                    MessageBox.Show("No se ha seleccionado un Vendedor para modificar");
                    return;
                }

                form = new AgregarPersona(TipoPersona.Vendedor, _negocio, null, vendedor);
                form.ShowDialog();
                LoadData();
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se ha podido modificar Vendedor", exc.ToString());
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var vendedor = new Vendedor();

            try
            {
                if (dgvVendedores.CurrentRow?.DataBoundItem is Vendedor)
                    vendedor = (Vendedor)dgvVendedores.CurrentRow.DataBoundItem;
                else
                {
                    MessageBox.Show("No se ha seleccionado un Vendedor para eliminar");
                    return;
                }

                DialogResult result = MessageBox.Show($@"Se eliminará el Vendedor: {vendedor.Nombre} {vendedor.Apellido} con número: {vendedor.Numero}",
                                                        "Eliminar Vendedor", 
                                                        MessageBoxButtons.OKCancel, 
                                                        MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    _negocio.Delete(vendedor.Id);
                    LoadData();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se ha podido eliminar Vendedor", exc.ToString());
            }
        }
    }
}