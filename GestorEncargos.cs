using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
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
        private readonly ArticulosNegocio _articuloNegocio;
        private readonly ConfiguracionNegocio _configuracionNegocio;
        private Form _openForm;

        public GestorEncargos(VendedorNegocio vendedorNegocio, ClienteNegocio clienteNegocio,
                              ArticulosNegocio articulosNegocio, ConfiguracionNegocio configuracionNegocio)
        {
            InitializeComponent();

            _vendedorNegocio = vendedorNegocio;
            _clienteNegocio = clienteNegocio;
            _articuloNegocio = articulosNegocio;
            _configuracionNegocio = configuracionNegocio;
        }

        private void GestorEncargos_Load(object sender, EventArgs e)
        {
            var startForm = new EncargosForm(_vendedorNegocio, _configuracionNegocio);
            _openForm = startForm;
            OpenForm(startForm);
            ActiveButton(btnEncargos);
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
        private void ActiveButton(Button button)
        {
            foreach (Control ctr in flpButtons.Controls)
            {
                if (ctr is Button)
                {
                    ((Button)ctr).BackColor = Color.FromArgb(64, 64, 64);
                }
            }
            button.BackColor = Color.DodgerBlue;
        }

        private void btnEncargos_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(EncargosForm)))
                return;

            var form = new EncargosForm(_vendedorNegocio, _configuracionNegocio);
            OpenForm(form);
            ActiveButton(btnEncargos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ClientesForm)))
                return;

            var form = new ClientesForm(_clienteNegocio);
            ActiveButton(btnClientes);
            OpenForm(form);
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(VendedoresForm)))
                return;

            var form = new VendedoresForm(_vendedorNegocio);
            ActiveButton(btnVendedores);
            OpenForm(form);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ArticulosForm)))
                return;

            var form = new ArticulosForm(_articuloNegocio);
            ActiveButton(btnArticulos);
            OpenForm(form);
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(OpcionesForm)))
                return;

            var form = new OpcionesForm(_configuracionNegocio);
            ActiveButton(btnOpciones);
            OpenForm(form);
        }
    }
}