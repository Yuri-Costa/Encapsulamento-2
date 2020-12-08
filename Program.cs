using System;

namespace calcularHora
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            f.Hora = 8;
            f.CalcularHoras();
            Console.WriteLine( f.CalcularHoras());
        }
    }
}
