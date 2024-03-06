using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Colaborador : Pessoa
    {
        private double salario;

        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            mensagemPessoa();
            mensagemColaborador();
        }
        private void mensagemColaborador()
        {
            Console.WriteLine($"Salario: {salario}");
        }
    }
}
