using System;
using System.Runtime.CompilerServices;
using Models.MovelFactory;

namespace DesignPatternFactoryMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### FACTORY METHODS  - EXEMPLO FÁBRICA DE MÓVEIS ###");
            Console.Write("Informe qual o móvel será fabricado\n(1 - Cadeira)\n(2 - Mesa)\n(3 - Sofá)\nInforme: ");
            int.TryParse(Console.ReadLine(), out int tipo);
            Console.WriteLine();
            var movel = new MovelFactory().FactoryMovel(tipo);
            Console.WriteLine("Tipo do móvel: " + movel.Tipo);
            movel.Pecas.ForEach(Item => Console.WriteLine($"Peça: {Item}"));
        }
    }
}
