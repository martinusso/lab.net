using System;
using System.Net.Mail;

namespace FeedMaluco
{
    class CriadorMensagem
    {
        private Remetente Remetente;
        private string EmailDestinatario;
        private string Titulo;
        private string Conteudo;

        public CriadorMensagem(Remetente remetente, string emailDestinatario, string titulo, string conteudo)
        {
            Remetente = remetente;
            EmailDestinatario = emailDestinatario;
            Titulo = titulo;
            Conteudo = conteudo;
        }

        public MailMessage GetMensagem()
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

            return mail;
        }
    }
}
