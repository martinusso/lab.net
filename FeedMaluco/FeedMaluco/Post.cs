using System;

namespace FeedMaluco
{
    struct Post
    {
        public string Titulo { get; private set; }
        public string Conteudo { get; private set; }

        public Post(string titulo, string conteudo)
            : this()
        {
            Titulo = titulo;
            Conteudo = conteudo;
        }
    }
}
