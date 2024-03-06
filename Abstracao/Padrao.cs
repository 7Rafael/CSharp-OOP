using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    abstract class Padrao
    {
        public abstract void taxaEmprestimo(double valor);
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine($"Ganhos obtidos pela poupança R$ {valor * taxa}");
        }
    }
}
