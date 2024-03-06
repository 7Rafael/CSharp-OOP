using ExercicioEscolar;
using System;

namespace ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno");
            aluno.nome =Console.ReadLine();
            Console.WriteLine("Digite a primeira nota");
            aluno.nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            aluno.nota2 = Convert.ToInt32(Console.ReadLine());
            aluno.mensagem();
        }
    }
}