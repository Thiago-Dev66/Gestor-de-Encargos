using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Services
{
    public static class EmailService
    {
        private static SmtpClient server = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential(
                ConfigurationManager.AppSettings["EmailAddress"],
                ConfigurationManager.AppSettings["EmailPassword"]),

            EnableSsl = true
        };

        public static void SendEmail(string to, string subject, string body)
        {
            using (var email = new MailMessage())
            {
                email.To.Add(to);
                email.Subject = subject;
                email.Body = body;
                email.From = new MailAddress(ConfigurationManager.AppSettings["EmailAddress"]);

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
        //public static Configuration Config()
        //{
        //    var configMap = new ExeConfigurationFileMap
        //    {
        //        ExeConfigFilename = "SecretApp.config"
        //    };

        //    Configuration config =
        //        ConfigurationManager.OpenMappedExeConfiguration(
        //            configMap,
        //            ConfigurationUserLevel.None);

        //    return config;
        //}
    }
}