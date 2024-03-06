using System;

namespace CalculaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite seu peso");
            pessoa.peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura");
            pessoa.altura = Convert.ToDouble(Console.ReadLine());
            pessoa.mensagem();
        }
    }
}