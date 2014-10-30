using System;
using System.Net.Mail;
using System.Net.Configuration;

namespace FeedMaluco
{
    class Carteiro
    {
        private Remetente Remetente;
        private string EmailDestinatario;
        private string Titulo;
        private string Conteudo;

        public Carteiro(Remetente remetente, string emailDestinatario, string titulo, string conteudo)
        {
            Remetente = remetente;
            EmailDestinatario = emailDestinatario;
            Titulo = titulo;
            Conteudo = conteudo;
        }

        public string EnviarEmail() 
        {
            var mail = new MailMessage();
            mail.To.Add(EmailDestinatario);
            mail.From = new MailAddress(Remetente.Email, Remetente.Nome, System.Text.Encoding.UTF8);
            mail.Subject = "FeedMaluco: " + Titulo;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = Conteudo;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;


            SmtpClient client = new SmtpClient(Remetente.SmtpHost, Remetente.SmtpPort);
            client.EnableSsl = Remetente.SmtpUseSSL;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(Remetente.Email, Remetente.Senha);

            try
            {
                client.Send(mail);
                return "E-mail enviado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Ocorreu um erro ao enviar:" + ex.Message;
            }
        }
    }
}
