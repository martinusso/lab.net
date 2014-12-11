using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extesions
{
    class Program
    {
        static void Main(string[] args)
        {
            var cor = new Cor
            {
                Vermelho = 0,
                Verde = 0,
                Azul = 255
            };

            var json = cor.ToJson();

            Console.WriteLine(json);
            Console.Read();
        }
    }
}
