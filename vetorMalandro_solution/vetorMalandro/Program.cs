using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorMalandro
{

    class mes
    {

        int[] meses = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        string[] nomeMeses = new string[] {"Janeiro", "Fevereiro", "Março" , "Abril", "Maio", "Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"};
       
        public mes(int m)
        {
            m--;
            Console.Write(nomeMeses[m]);
            Console.WriteLine(","+ meses[m] + " Dias");            
        }
       
    }

    class dia
    {
        int[] diaSemana = new int[] {1, 2, 3, 4, 5, 6,7};
        string[] nomeDia = new string[] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };

        public dia(int d)
        {
            d--;
            Console.WriteLine(nomeDia[d]);
           
        }
    }


    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do mês");
            mes m = new mes(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o número do dia da semana");
            dia d = new dia(int.Parse(Console.ReadLine()));
        }
    }
}
