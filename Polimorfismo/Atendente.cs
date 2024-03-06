using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Atendente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine($"Desonto gerente do vale alimentacao R$ {salario * 0.12}");
        }
    }
}
