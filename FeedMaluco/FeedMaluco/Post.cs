using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMaluco
{
    public class Post
    {
        public string Titulo { get; private set; }
        public string Conteudo { get; private set; }

        public Post(string titulo, string conteudo)
        {
            this.Titulo = titulo;
            this.Conteudo = conteudo;
        }
    }
}
