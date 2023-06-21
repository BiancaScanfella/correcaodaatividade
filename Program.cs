using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreçãoDasAtividades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string resposta;

            Console.WriteLine("Bem-vindo ao DETRAN!");
            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            


            Console.WriteLine($"Você tem {idade} anos!");
            if ( idade >= 18)
            {
                Console.WriteLine("Você já pode tirar a CNH");
            }
            else
            {
                Console.WriteLine("Você ainda não tem idade...");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Você ja tem uma carteira CNH? Digite sim ou não:");
            resposta = Console.ReadLine();
            
            Console.WriteLine("\n");
            if (resposta == "sim")
            {
                Console.WriteLine(" Você ja conquistou sua primeira carteira de trabalho! Ficamos felizes!");
            }
            else
            {
                Console.WriteLine("Você vai tirar sua primeira carteira de motorista");
            }


            Console.ReadKey();
            Main(null);
        }
    }
}
