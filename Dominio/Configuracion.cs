namespace Dominio
{
    public class Configuracion
    {
        public string MensajeEncargo { get; set; }

        public int NotificationType { get; set; }
    }

    public enum NotificationType
    {
        Whatsapp = 0,
        Email = 1
    }
}