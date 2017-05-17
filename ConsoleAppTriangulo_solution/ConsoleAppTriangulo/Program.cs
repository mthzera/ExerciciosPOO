using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTriangulo
{
    public class Triangulo
    {
        public double l1, l2, l3;  
        public string Igualdade;
        
        public Triangulo(double l1, double l2, double l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public void ehTriangulo()
        {
            if(l1<l2+l3 && l2<l1+l3 && l3 < l1 + l2)
            {
               Console.WriteLine("é um triangulo");
            }else
            {
               Console.WriteLine("Não é um triangulo");
            }

          
        }

        public bool ehIgual(Triangulo other)
        {

            bool igual1 = this.l1 == other.l1 && this.l2 == other.l2 && this.l3 == other.l3;
            bool igual2 = this.l1 == other.l2 && this.l2 == other.l3 && this.l3 == other.l1;
            bool igual3 = this.l1 == other.l3 && this.l2 == other.l1 && this.l3 == other.l2; 

            return igual1 || igual2 || igual3;
           
        }



    }

    class Program
    {
        static void Main(string[] args)

            // ENTRADA
        {
            Console.WriteLine("Digite os lados de um triângulo:");
            Console.WriteLine("Lado1:");
            double l1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Lado2:");
            double l2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Lado3:");
            double l3 = Double.Parse(Console.ReadLine());

            Triangulo T1 = new Triangulo (l1, l2, l3);

            Console.WriteLine("Digite os lados de um triângulo:");
            Console.WriteLine("Lado1:");
             l1= Double.Parse(Console.ReadLine());

            Console.WriteLine("Lado2:");
             l2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Lado3:");
             l3 = Double.Parse(Console.ReadLine());

            Triangulo T2 = new Triangulo(l1, l2, l3);


            //PROCESSAMENTO
            T1.ehTriangulo();
            T2.ehTriangulo();

            bool saoIguais = T1.ehIgual(T2);


            // SAIDA 
            Console.WriteLine(saoIguais ? "São iguais" : "Não são iguais");
                
        }
    }
}
