using System.ComponentModel;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Precio U$D")]
        public double Precio { get; set; }
    }
}
