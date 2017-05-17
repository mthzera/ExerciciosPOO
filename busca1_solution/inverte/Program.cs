using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverte
{

    class palavras
    {
        public palavras()
        {
            string[] vetorPalavras = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite uma palavra");
                vetorPalavras[i] = Console.ReadLine();
            }

            for(int i = 9; i >= 0; i--)
            {
                Console.WriteLine(vetorPalavras[i]);
            }
            
            


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            palavras p = new palavras();
        }
    }
}