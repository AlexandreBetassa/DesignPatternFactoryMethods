using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Models.MovelCreate;
using Models.MovelFactory;

namespace DesignPatternFactoryMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do {
                Movel movel = new MovelFactory().FactoryMovel(Tipo());
                //IMPRIMINDO O TIPO DE MÓVEL ESCOLHIDO COM AS PEÇAS NECESSÁRIAS
                Console.WriteLine($"\n### LISTA DE PEÇAS - {movel.Tipo.ToUpper()} ###");
                movel.Pecas.ForEach(Item => Console.WriteLine($"Peça: {Item}"));
                Console.ReadKey();
                Console.WriteLine();
            } while (true);

        }

        public static int Tipo()
        {
            Console.Clear();
            Console.WriteLine("### FACTORY METHODS  - EXEMPLO FÁBRICA DE MÓVEIS ###");
            Console.Write("Informe qual o móvel será fabricado\n(1 - Cadeira)\n(2 - Mesa)\n(3 - Sofá)\nInforme: ");
            int.TryParse(Console.ReadLine(), out int tipo);
            return tipo;
        }

    }
}
