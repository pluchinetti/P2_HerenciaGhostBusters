using System.Net.Mail;
using System; // Muy Importante!

// La siguiente clase esta configurada para funcionar con un servidor de correo de Gmail
namespace Herencia
{
    public class EmailSender
    {
        private String usrRemitente; // generalmente el e-mail del remitente
        private String pwdRemitente;
        public EmailSender(String usrRemitente, String pwdRemitente)
        {
            this.usrRemitente = usrRemitente;
            this.pwdRemitente = pwdRemitente;
        }
        public bool SendEmail(String mailRemitente, String nomRemitente, String mailDestinatario, String asunto, string contenido)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(mailDestinatario);
            msg.From = new MailAddress(mailRemitente, nomRemitente, System.Text.Encoding.UTF8);
            msg.Subject = asunto;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = contenido;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            //Si vas a enviar un correo con contenido html entonces cambia el valor a true
            msg.IsBodyHtml = false;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(usrRemitente, pwdRemitente);
            client.Port = 587;
            //Este es el smtp valido para Gmail
            client.Host = "smtp.gmail.com";
            //Esto es para que vaya a través de SSL que es obligatorio con Gmail
            client.EnableSsl = true;
            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}