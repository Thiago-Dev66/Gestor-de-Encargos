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

namespace Gestor_de_Encargos
{
    public partial class GestorEncargos : Form
    {
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
    }
}
