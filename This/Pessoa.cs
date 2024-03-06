using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    internal class Pessoa
    {
        private string nome = "Leticia";
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }
    }
}
