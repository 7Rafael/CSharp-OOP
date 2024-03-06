namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imposto estagiario = new Estagiario();
            estagiario.valeAlimentacao(1000);
            estagiario.ValeTransporte(1000);
            Console.WriteLine("------------------");

            Imposto gerente = new Gerente();
            gerente.valeAlimentacao(5000);
            gerente.ValeTransporte(5000);
            Console.WriteLine("------------------");

            Imposto atendente = new Atendente();
            atendente.valeAlimentacao(2000);
            atendente.ValeTransporte(2000);
        }
    }
}
