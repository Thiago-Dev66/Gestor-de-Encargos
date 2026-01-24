using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Encargo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public enum Estado
        {
            Pendiente,
            EnProceso,
            Remitido,
            Cancelado
        }
        public string Descripcion { get; set; }
        public string SucursalOrigen { get; set; }
        public int ClienteID { get; set; }
        public int VendedorID { get; set; }
        public List<ArticuloEncargo> ArticuloEncargo { get; set; }
    }
}
