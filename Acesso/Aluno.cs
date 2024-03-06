using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso
{
    internal class Aluno
    {
        private double nota1;
        private double nota2;

        private double media()
        {
            return (nota1 + nota2) / 2;
        }
        public void mensagem()
        {
            Console.WriteLine("Digite a primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A média é {media()}");
        }
    }
}
