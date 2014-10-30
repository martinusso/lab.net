using System;
using System.Net.Mail;
using System.Net.Configuration;

namespace FeedMaluco
{
    class Carteiro
    {
        private MailMessage Mensagem;
        private Remetente Remetente;

        public Carteiro(MailMessage mensagem, Remetente remetente)
        {
            Mensagem = mensagem;
            Remetente = remetente;
        }

        public string EnviarEmail() 
        {
            SmtpClient client = new SmtpClient(Remetente.SmtpHost, Remetente.SmtpPort);
            client.EnableSsl = Remetente.SmtpUseSSL;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(Remetente.Email, Remetente.Senha);

            try
            {
                client.Send(Mensagem);
                return "E-mail enviado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Ocorreu um erro ao enviar:" + ex.Message;
            }
        }
    }
}
