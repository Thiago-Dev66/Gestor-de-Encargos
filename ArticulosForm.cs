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
        }
        private void LoadArticulos()
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = _negocio.GetAll()
                                              .OrderByDescending(x => x.Id)
                                              .ToList();
            if (dgvArticulos.Columns.Count == 0)
                return;

            dgvArticulos.Columns["Id"].Visible = false;
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
            {
                MessageBox.Show("Seleccione un artículo para modificar.",
                                "Advertencia",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            var articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            var frm = new AgregarArticuloForm(_negocio, articulo);
            frm.ShowDialog();
            LoadArticulos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!(dgvArticulos.CurrentRow?.DataBoundItem is Articulo))
            {
                MessageBox.Show("Seleccione un artículo para eliminar.",
                                "Advertencia",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            var articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            DialogResult result = 
                MessageBox.Show($"¿Está seguro de que desea eliminar el artículo '{articulo.Nombre}'?",
                                  "Confirmar eliminación",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _negocio.Delete(articulo.Id);

                MessageBox.Show($"Artículo '{articulo.Nombre}' eliminado correctamente.",
                                 "Éxito",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                LoadArticulos();
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Error al eliminar el artículo: {exc.Message}",
                                 "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            }
        }
    }
}
