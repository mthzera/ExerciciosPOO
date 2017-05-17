using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busca1
{

    class aleatorio
    {
        int[] numeros = new int[99];
        Random rand = new Random();
        int x = 0;
        public void listaNumeros(int escolha)
        {
            for (int i = 0; i < 99; i++)
            {
                numeros[i] = rand.Next(10) + 1;

            }
        }
        public void verifica(int escolha)
        {
            for (int i = 0; i < 99; i++)
            {
                if (numeros[i] == escolha) {
                    x = numeros[i];
                    i = 99;
                }

            }
            if (x > 0)
            {
                Console.WriteLine(numeros[x]);
            }
            else
            {
                Console.WriteLine("Não foi encontrado o numero");
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Numero:");
                int escolha = int.Parse(Console.ReadLine());
                aleatorio e = new aleatorio();
                e.listaNumeros(escolha);
                e.verifica(escolha);

            }



        }
    }
}