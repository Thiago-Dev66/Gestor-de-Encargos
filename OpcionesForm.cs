using Dominio;
using Negocio;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestor_de_Encargos
{
    public partial class OpcionesForm : Form
    {
        private readonly ConfiguracionNegocio _negocio;

        public OpcionesForm(ConfiguracionNegocio negocio)
        {
            InitializeComponent();
            _negocio = negocio;
        }

        private void OpcionesForm_Load(object sender, EventArgs e)
        {
            Configuracion config = _negocio.ObtenerConfiguracion();
            txtMensaje.Text = config.MensajeEncargo;
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            var configuracion = new Configuracion
            {
                MensajeEncargo = txtMensaje.Text
            };

            _negocio.GuardarConfiguracion(configuracion);

            MessageBox.Show("Configuración guardada correctamente.");
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = _negocio.ObtenerConfiguracion().MensajeEncargo;
        }

        private void txtMensaje_DragEnter(object sender, DragEventArgs e)
        {
            // Validamos si los datos que se están arrastrando son de tipo texto
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                // Cambia el cursor para indicar que se permite la copia
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Cambia el cursor para indicar que NO se puede soltar aquí
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtMensaje_DragDrop(object sender, DragEventArgs e)
        {
            // 1. Obtener el texto que viene desde el Label
            string textoArrastrado = e.Data.GetData(DataFormats.Text).ToString();

            // 2. Convertir las coordenadas de la pantalla a las coordenadas internas del TextBox
            Point puntoPantalla = new Point(e.X, e.Y);
            Point puntoTextBox = txtMensaje.PointToClient(puntoPantalla);

            // 3. Obtener la posición exacta del cursor de texto (Carets) según el punto del mouse
            int indiceInsercion = txtMensaje.GetCharIndexFromPosition(puntoTextBox);

            // 4. Insertar el texto en esa posición específica
            txtMensaje.Text = txtMensaje.Text.Insert(indiceInsercion, textoArrastrado);

            // 5. Opcional: Dejar el cursor parpadeando justo después del texto insertado
            txtMensaje.SelectionStart = indiceInsercion + textoArrastrado.Length;
            txtMensaje.Focus();
        }

        // 2. Iniciamos el arrastre pasando el texto del Label y el efecto deseado
        private void lblClienteNombre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(lblClienteNombre.Text, DragDropEffects.Copy);
            }
        }

        private void lblVendedorNombre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(lblVendedorNombre.Text, DragDropEffects.Copy);
            }
        }

        private void lblArticulos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(lblArticulos.Text, DragDropEffects.Copy);
            }
        }
    }
}