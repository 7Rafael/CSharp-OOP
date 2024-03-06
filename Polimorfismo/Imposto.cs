using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Imposto
    {
        public virtual void valeAlimentacao(double salario)
        {
            Console.WriteLine($"Desonto padrão do vale alimentacao R$ {salario * 0.1}");
        }
        public void ValeTransporte(double salario)
        {
            Console.WriteLine($"Desonto padrão do vale transporte R$ {salario * 0.06}");
        }
    }
}
