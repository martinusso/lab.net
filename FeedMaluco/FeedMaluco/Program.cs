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
            /*
             * Para enviar o e-mail, sugiro criar uma conta de teste no GMail. 
             * Vocês podem ver como proceder nesse artigo do DevMedia (http://www.devmedia.com.br/enviando-e-mail-no-asp-net-usando-o-provedor-gmail/12520)
             */

            var remetente = new Remetente("EMAIL@gmail.com", "SENHA", "Breno Martinusso", "smtp.gmail.com", 25, true);
            string destinatario = "martinusso@gmail.com";

            Console.WriteLine(String.Format("Enviando o e-mail '{0}' para '{1}'", post.Titulo, destinatario));

            var carteiro = new Carteiro(remetente, destinatario, post.Titulo, post.Conteudo);
            string retorno = carteiro.EnviarEmail();

            Console.WriteLine(retorno);
            Console.Read();
        }
    }
}
