using System;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace enviar_Correo
{
    class logic
    {
        public async Task<string> SendMailAsync(string to, string subject, string body, string attachmentPath)
        {
            string message = "Error al enviar este correo. Por favor verifique los datos o intente más tarde.";
            string from = "innovative_software@hotmail.com";
            string displayName = "Abarrotes Concha";
            string password = "InnovativeMinds2024"; // Store your password in an environment variable

            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mail.To.Add(to);

                if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
                {
                    mail.Attachments.Add(new Attachment(attachmentPath));
                }

                using (SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587))
                {
                    client.Credentials = new NetworkCredential(from, password);
                    client.EnableSsl = true;

                    await client.SendMailAsync(mail);
                    message = "¡Correo enviado exitosamente! Pronto te contactaremos.";
                }
            }
            catch (SmtpException smtpEx)
            {
                message = "SMTP Error: " + smtpEx.Message;
            }
            catch (Exception ex)
            {
                message = "General Error: " + ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return message;
        }
    }
}
