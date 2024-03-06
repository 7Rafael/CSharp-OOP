using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite seu nome");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());
            pessoa.mensagem();
            Console.WriteLine("--------");
            pessoa.mensagem("Antonio");
            Console.WriteLine("--------");
            pessoa.mensagem("Leticia" , 30);
        }
    }
}