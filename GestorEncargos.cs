using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private EncargosRepository _encargosRepository = new EncargosRepository();
        private ArticuloRepository articulos = new ArticuloRepository();
        private EncargosNegocio _encargoNegocio;

        public GestorEncargos()
        {
            InitializeComponent();
        }
        private void GestorEncargos_Load(object sender, EventArgs e)
        {
            CargarDGV();
            OcultarColumnas();
            EnableButtons();

            BeginInvoke(new Action(() =>
            {
                txtNumeroVendedor.Focus();
            }));
        }
        private void EnableButtons(bool isEnabled = false)
        {
            if (isEnabled == false)
            {
                BtnAgregar.Enabled = false;
                BtnAgregar.BackColor = Color.LightGray;

                btnModificar.Enabled = false;
                btnModificar.BackColor = Color.LightGray;

                btnDelete.Enabled = false;
                btnDelete.BackColor = Color.LightGray;

                btnNotificar.Enabled = false;
                btnNotificar.BackColor = Color.LightGray;
            }
            else if (isEnabled == true)
            {
                BtnAgregar.Enabled = true;
                BtnAgregar.BackColor = SystemColors.Highlight;

                btnModificar.Enabled = true;
                btnModificar.BackColor = SystemColors.Highlight;

                btnDelete.Enabled = true;
                btnDelete.BackColor = SystemColors.Highlight;

                btnNotificar.Enabled = true;
                btnNotificar.BackColor = SystemColors.Highlight;
            }
        } 
        private void CargarDGV()
        {
            dgvEncargos.DataSource = null;
            dgvEncargos.DataSource = _encargosRepository.GetAll()
                                                        .OrderByDescending(en => en.Fecha)
                                                        .ToList();
        }
        private void OcultarColumnas()
        {
            if (dgvEncargos.Columns.Count == 0) return;

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
            dgvArticulos.Columns["Cantidad"].DisplayIndex = 2;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEncargo agregarEncargo = new AgregarEncargo(_Vendedor);
            DialogResult result = agregarEncargo.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                CargarDGV();
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

                EnableButtons(true);
                BtnAgregar.Focus();
            }
            else
            {
                MessageBox.Show("El número de vendedor no es correcto");
                EnableButtons();
            }
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
            try
            {
                if (!(dgvEncargos.CurrentRow?.DataBoundItem is Encargo encargo))
                    return;
                else
                    encargo = (Encargo)dgvEncargos.CurrentRow.DataBoundItem;

                dgvArticulos.DataSource = articulos.GetArticulosByEncargoId(encargo.Id);

                if (encargo.Estado == EstadoEncargo.Notificado)
                {
                    btnNotificar.Enabled = false;
                    btnNotificar.BackColor = Color.LightGray;
                }
                else if (_Vendedor != null)
                {
                    btnNotificar.Enabled = true;
                    btnNotificar.BackColor = SystemColors.Highlight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Encargo ObtenerEncargoSeleccionado()
        {
            if (!(dgvEncargos.CurrentRow?.DataBoundItem is Encargo encargo))
                return null;
            else
            {
                encargo.ArticuloEncargo = articulos.GetArticulosByEncargoId(encargo.Id);
                return encargo;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AgregarEncargo agregarEncargo;
            BindingList<ArticuloEncargo> articulosModificados;
            var encargo = new Encargo()
            {
                Cliente = new Cliente()
            };

            if (ObtenerEncargoSeleccionado() != null)
                encargo = ObtenerEncargoSeleccionado();
            else
            {
                MessageBox.Show("Debe haber un encargo seleccionado");
                return;
            }

            articulosModificados = (BindingList<ArticuloEncargo>)dgvArticulos?.DataSource;
            agregarEncargo = new AgregarEncargo(_Vendedor, encargo, articulosModificados);
            agregarEncargo.ShowDialog();

            CargarDGV();
            OcultarColumnas();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _encargoNegocio = new EncargosNegocio(_encargosRepository);
                var encargo = new Encargo();

                if (ObtenerEncargoSeleccionado() != null)
                    encargo = ObtenerEncargoSeleccionado();
                else
                {
                    MessageBox.Show("Debe haber un encargo seleccionado");
                    return;
                }

                DialogResult result = MessageBox.Show(
                                        "¿Seguro que deseas borrar el encargo?\nNo se podrán recuperar los datos",
                                        "Borrar encargo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _encargoNegocio.Delete(encargo.Id);
                    CargarDGV();
                    OcultarColumnas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            _encargoNegocio = new EncargosNegocio(_encargosRepository);
            var encargo = new Encargo();
            bool isNotified = false;

            if (ObtenerEncargoSeleccionado() != null)
                encargo = ObtenerEncargoSeleccionado();
            else
            {
                MessageBox.Show("Debe haber un encargo seleccionado para poder notificar");
                return;
            }

            _encargoNegocio.NotificarCliente(encargo);

            DialogResult result = MessageBox.Show(
                                        "¿El cliente fue notificado?",
                                        "Notificar Cliente",
                                        MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                isNotified = true;
                _encargoNegocio.IsNotified(isNotified, encargo);
                CargarDGV();
                OcultarColumnas();
            }
        }

        private void dgvEncargos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;

                if (dgv.Name != dgvEncargos.Name) 
                    return;

                if (dgvEncargos.Columns[e.ColumnIndex].Name == "Estado")
                {

                    EstadoEncargo estado = (EstadoEncargo)e.Value;

                    switch (estado)
                    {
                        case EstadoEncargo.Pendiente:
                            e.CellStyle.BackColor = Color.LightSalmon;
                            e.CellStyle.SelectionBackColor = Color.LightSalmon;
                            e.CellStyle.SelectionForeColor = Color.Black;
                            break;

                        case EstadoEncargo.Remitido:
                            e.CellStyle.BackColor = Color.LightGreen;
                            e.CellStyle.SelectionBackColor = Color.LightGreen;
                            e.CellStyle.SelectionForeColor = Color.Black;
                            break;

                        case EstadoEncargo.Vendido:
                            dgvEncargos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                            dgvEncargos.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                            dgvEncargos.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
                            break;

                        case EstadoEncargo.Notificado:
                            e.CellStyle.BackColor = Color.LightSkyBlue;
                            e.CellStyle.SelectionBackColor = Color.LightSkyBlue;
                            e.CellStyle.SelectionForeColor = Color.Black;
                            break;

                        case EstadoEncargo.Cancelado:
                            e.CellStyle.BackColor = Color.LightGray;
                            e.CellStyle.SelectionBackColor = Color.LightGray;
                            e.CellStyle.SelectionForeColor = Color.Black;
                            break;

                        case EstadoEncargo.Urgente:
                            e.CellStyle.BackColor = Color.Red;
                            e.CellStyle.SelectionBackColor = Color.Red;
                            e.CellStyle.ForeColor = Color.Black;
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
