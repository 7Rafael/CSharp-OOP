using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class PessoaJuridica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo pasa Pessoa Juridica R$: {valor * 0.2}");
        }
    }
}
