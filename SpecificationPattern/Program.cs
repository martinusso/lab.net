using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mulher = new Pessoa()
            {
                Nome = "Leandra",
                Sexo = Sexo.Feminino
            };

            var specification = new SpecificationMulherDisponivel();

            var mulherDisponivel = specification.EstaDisponivel().Compile()(mulher);

            if (mulherDisponivel)
            {
                Console.WriteLine("mulher está disponível");
            }
            else
            {
                Console.WriteLine("mulher NÃO está disponível");
            }

            Console.Read();
        }
    }
}
