using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Repositories;
using Dominio.Interfaces;
using Negocio;

namespace Gestor_de_Encargos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBInitializer.Initialization();

            string path = DataPathManager.GetConfiguracionPath();
            var configNegocio = new ConfiguracionNegocio(new ConfiguracionRepository(path));

            IVendedorRepository repository = new VendedorRepository();
            VendedorNegocio vendedorNegocio = new VendedorNegocio(repository);

            IClienteRepository clienteRepository = new ClienteRepository();
            ClienteNegocio clienteNegocio = new ClienteNegocio(clienteRepository);

            IArticuloRepository articuloRepository = new ArticuloRepository();
            ArticulosNegocio articulosNegocio = new ArticulosNegocio(articuloRepository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GestorEncargos(vendedorNegocio, clienteNegocio, articulosNegocio, configNegocio));
        }
    }
}
