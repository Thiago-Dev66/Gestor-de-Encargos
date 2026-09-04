using System;
using System.Net;
using System.Net.Mail;
using Negocio;
using Negocio.Servicios;

namespace Services
{
    public static class EmailService
    {
        private static MailMessage email;
        private static SmtpClient server = new SmtpClient("sandbox.smtp.mailtrap.io", 25)
        {
            Credentials = new NetworkCredential("2df9f0d1ada4cc", "7c5fa306dbd313"),
            EnableSsl = true
        };

        public static void SendEmail(string to, string subject, string body)
        {
            email = new MailMessage();
            email.To.Add(to);
            email.Subject = subject;
            email.Body = body;
            email.From = new MailAddress("noreply@theCDpot.com");

            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {
                throw new Exception("Error con el servicio SMTP", ex);
            }
        }
    }
}
