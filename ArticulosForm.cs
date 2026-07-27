using System;
using Negocio;
using System.Windows.Forms;
using Dominio;
using System.Linq;

namespace Gestor_de_Encargos
{
    public partial class ArticulosForm : Form
    {
        private readonly ArticulosNegocio _negocio;

        public ArticulosForm(ArticulosNegocio negocio)
        {
            InitializeComponent();
            _negocio = negocio;
        }
        private void ArticulosForm_Load(object sender, EventArgs e)
        {
            LoadArticulos();
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void LoadArticulos()
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = _negocio.GetAll()
                                              .OrderByDescending(x => x.Id)
                                              .ToList();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new AgregarArticuloForm(_negocio);
            frm.ShowDialog();
            LoadArticulos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!(dgvArticulos.CurrentRow?.DataBoundItem is Articulo))
                return;

            var articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            var frm = new AgregarArticuloForm(_negocio, articulo);
            frm.ShowDialog();
            LoadArticulos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!(dgvArticulos.CurrentRow?.DataBoundItem is Articulo))
                return;

            var articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            _negocio.Delete(articulo.Id);
            LoadArticulos();
        }
    }
}
