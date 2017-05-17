using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bhaskara
{
    class Program
    {
        class Bhaskara
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite o valor de A"); double a; a = double.Parse(Console.ReadLine()); Console.WriteLine("Digite o valor de B"); double b; b = double.Parse(Console.ReadLine()); Console.WriteLine("Digite o valor de C"); double c; c = double.Parse(Console.ReadLine());
                double delta = (Math.Pow(b, 2) + (-4 * a * c));

                Console.WriteLine(delta); if (delta > 0)
                {
                    Console.WriteLine("Delta é " + Math.Sqrt(delta)); double x1 = ((-b) + Math.Sqrt(delta) / 2); double x2 = ((-b) - Math.Sqrt(delta) / 2); Console.WriteLine("A Primeira raiz é " + x1); Console.WriteLine("A segunda raiz é " + x2);
                }
                if (delta < 0) { Console.WriteLine("Não existe Raiz real."); }
            }
        }
    }


}