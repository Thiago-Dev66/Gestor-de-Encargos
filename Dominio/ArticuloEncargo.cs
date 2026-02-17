using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ArticuloEncargo
    {
        public int ArticuloID { get; set; }
        public Articulo Articulo { get; set; }
        public int EncargoID { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }

        [DisplayName("Código")]
        public string ArticuloCodigo => Articulo?.Codigo;
        [DisplayName("Articulo")]
        public string ArticuloNombre => Articulo?.Nombre;
    }
}
