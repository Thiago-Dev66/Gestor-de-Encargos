using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Windows.Forms;
using Data.Repositories;
using Dominio;
using Dominio.Interfaces;
using Negocio;

namespace Gestor_de_Encargos
{
    public partial class GestorEncargos : Form
    {
        private readonly VendedorNegocio _vendedorNegocio;
        private readonly ClienteNegocio _clienteNegocio;
        private readonly ArticulosNegocio _articulosNegocio;
        private Form _openForm;

        public GestorEncargos(VendedorNegocio vendedorNegocio, ClienteNegocio clienteNegocio,
                              ArticulosNegocio articulosNegocio)
        {
            InitializeComponent();

            _vendedorNegocio = vendedorNegocio;
            _clienteNegocio = clienteNegocio;
            _articulosNegocio = articulosNegocio;
        }

        private void GestorEncargos_Load(object sender, EventArgs e)
        {
            var startForm = new EncargosForm(_vendedorNegocio);
            _openForm = startForm;
            OpenForm(startForm);
        }
        private bool IsFormOpen(Type type)
        {
            if ((_openForm.GetType() == type) && !_openForm.IsDisposed)
                return true;

            return false;
        }
        private void OpenForm(Form form)
        {
            if (this.formsPanel.Controls.Count > 0)
                formsPanel.Controls.RemoveAt(0);

            _openForm = form;
            form.TopLevel = false;
            this.formsPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void btnEncargos_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(EncargosForm)))
                return;

            var form = new EncargosForm(_vendedorNegocio);
            OpenForm(form);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ClientesForm)))
                return;
            
            var form = new ClientesForm(_clienteNegocio);
            OpenForm(form);
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(VendedoresForm)))
                return;

            var form = new VendedoresForm(_vendedorNegocio);
            OpenForm(form);
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(OpcionesForm)))
                return;

            var form = new OpcionesForm();
            OpenForm(form);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ArticulosForm)))
                return;

            var form = new ArticulosForm(_articulosNegocio);
            OpenForm(form);
        }
    }
}
