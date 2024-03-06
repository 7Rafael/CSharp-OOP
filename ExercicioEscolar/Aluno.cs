using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscolar
{
    internal class Aluno
    {
        public string nome { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }

        public double media()
        {
            return (nota1 + nota2) / 2;

        }
        public string situacao (double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }
        public void mensagem()
        {
            double obterMedia = media();
            string obterSituacao = situacao(obterMedia);
            Console.WriteLine($"O aluno {nome} está {obterSituacao} com a média de {obterMedia}");
        }
    }
}
