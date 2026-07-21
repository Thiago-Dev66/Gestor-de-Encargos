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

            IVendedorRepository repository = new VendedorRepository();
            VendedorNegocio negocio = new VendedorNegocio(repository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GestorEncargos(negocio));
        }
    }
}
