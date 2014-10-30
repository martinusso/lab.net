using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMaluco
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = ObterPostAleatorio();
            EnviarEmail(post);
        }

        static private Post ObterPostAleatorio()
        {
            string feedUri = "http://martinfowler.com/feed.atom";
            var buscador = new BuscadorPosts(feedUri);
            return buscador.ObterPostAleatorio();
        }

        static private void EnviarEmail(Post post)
        {
            var remetente = new Remetente("EMAIL@gmail.com", "SENHA", "Breno Martinusso", "smtp.gmail.com", 25, true);
            string destinatario = "martinusso@gmail.com";

            Console.WriteLine(String.Format("Enviando o e-mail '{0}' para '{1}'", post.Titulo, destinatario));

            var mensagem = new CriadorMensagem(remetente, destinatario, post.Titulo, post.Conteudo).GetMensagem();

            var carteiro = new Carteiro(mensagem, remetente);
            string retorno = carteiro.EnviarEmail();

            Console.WriteLine(retorno);
            Console.Read();
        }
    }
}
