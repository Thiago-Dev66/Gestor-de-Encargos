using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Encargo
    {
        public Encargo()
        {
            ArticuloEncargo = new BindingList<ArticuloEncargo>();
        }

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public EstadoEncargo Estado { get; set; }
        [DisplayName("Sucursal")]
        public string SucursalOrigen { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public BindingList<ArticuloEncargo> ArticuloEncargo { get; set; }

        [DisplayName("Cliente")]
        public string ClienteNombre => Cliente?.Nombre;
        [DisplayName("Celular")]
        public string ClienteCelular => Cliente?.Celular;
        [DisplayName("Vendedor")]
        public int VendedorNumero => Vendedor.Numero;
    }
    public enum EstadoEncargo
    {
        Pendiente = 0,
        Remitido = 1,
        Vendido = 2,
        Notificado = 3,
        Cancelado = 4,
        Urgente = 5
    }
}
