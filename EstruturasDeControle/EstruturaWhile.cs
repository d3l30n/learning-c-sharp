using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numSecreto = random.Next(1,16);
            
            bool numEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while(tentativasRestantes > 0 && !numEncontrado)
            {
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if(numSecreto == palpite)
                {
                    numEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número encontrado em {0} tentativas!", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numSecreto) {
                    Console.WriteLine("Menor...Tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                } else
                {
                    Console.WriteLine("Maior...Tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
            }
        }
    }
}
