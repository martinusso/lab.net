using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    class Pessoa
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
    }

    public enum Sexo
    {
        Masculino,
        Feminino
    }
}
