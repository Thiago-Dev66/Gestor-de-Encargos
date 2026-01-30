using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Encargo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public EstadoEncargo Estado { get; set; }
        public string SucursalOrigen { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ArticuloEncargo> ArticuloEncargo { get; set; }
    }
    public enum EstadoEncargo
    {
        Pendiente = 0,
        Remitido = 1,
        Notificado = 2,
        Cancelado = 3
    }
}
