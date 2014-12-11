using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    class SpecificationMulherDisponivel
    {
        public Expression<Func<Pessoa, bool>> EstaDisponivel()
        {
            return pessoa => pessoa.Sexo == Sexo.Feminino;
        }
    }
}
