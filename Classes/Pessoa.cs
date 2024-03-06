using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public void mensagem()
        {
            Console.WriteLine($"Olá" );
        }
        public void mensagem(string nome)
        {
            Console.WriteLine($"Olá {nome}");
        }
        public void mensagem(string nome, int idade)
        {
            Console.WriteLine($"Olá {nome} você tem {idade} anos");
        }
    }
}
