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
            string feedUri = "http://martinfowler.com/feed.atom";

            var buscador = new BuscadorPosts(feedUri);

            var post = buscador.ObterPostAleatorio();
            Console.WriteLine(post.Titulo);
            Console.Read();
        }
    }
}
