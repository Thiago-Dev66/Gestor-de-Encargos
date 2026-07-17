using Data.Repositories;
using Dominio;
using Dominio.Interfaces;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Encargos
{
    public partial class ClientesForm : Form
    {
        private readonly ClienteNegocio _negocio;

        public ClientesForm(ClienteNegocio negocio)
        {
            InitializeComponent();
            _negocio = negocio;
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = _negocio.GetClientes()
                                             .OrderByDescending(c => c.Id)
                                             .ToList();

            dgvClientes.Columns["Id"].Visible = false;
            dgvClientes.Columns["NombreCompleto"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new AgregarPersona(TipoPersona.Cliente);
            form.ShowDialog();
            LoadData();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            Form form;

            try
            {
                cliente = dgvClientes.CurrentRow?.DataBoundItem as Cliente;

                form = new AgregarPersona(TipoPersona.Cliente, cliente);
                form.ShowDialog();
                LoadData();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", exc.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            var negocio = new ClienteNegocio(new ClienteRepository());

            try
            {
                if (dgvClientes.CurrentRow?.DataBoundItem is Cliente)
                {
                    DialogResult result = MessageBox.Show("Seguro que desea eliminar?",
                                                            "Eliminar Cliente",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;

                    cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    negocio.Eliminar(cliente);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente para eliminar");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", exc.ToString());
            }
        }
    }
}
