using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class PessoaFisica :Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo pasa Pessoa Física R$: {valor * 0.1}");
        }
    }
}
