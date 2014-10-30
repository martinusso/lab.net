using System;

namespace FeedMaluco
{
    struct Remetente
    {
        public string Email { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }

        public string SmtpHost { get; private set; }
        public int SmtpPort { get; private set; }
        public Boolean SmtpUseSSL { get; private set; }

        public Remetente(string email, string senha, string nome, string smtpHost, int smtpPort, Boolean smtpUseSSL)
            : this()
        {
            Email = email;
            Nome = nome;
            Senha = senha;

            SmtpHost = smtpHost;
            SmtpPort = smtpPort;
            SmtpUseSSL = smtpUseSSL;
        }
    }
}
