using System;

namespace FeedMaluco
{
    struct Remetente
    {
        public string Email { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public Smtp Smtp { get; private set; }

        public Remetente(string email, string senha, string nome, Smtp smtp)
            : this()
        {
            Email = email;
            Nome = nome;
            Senha = senha;
            Smtp = smtp;
        }
    }
}