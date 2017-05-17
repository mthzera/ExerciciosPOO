using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exercicio_Salario1
{
    class Program
    {
        static void Main(string[] args)
        {   
            // ENTRADAS
            Console.WriteLine("Digite o nome do funcionario");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o valor da Hora: ");
            decimal valorHora = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total da Horas: ");
            double hora = double.Parse(Console.ReadLine());

            // PROCESSAMENTO

            //Criado o objeto 
            Funcionario f = new Funcionario(nome, valorHora, hora);
            decimal salario = f.getSalario();


            //SAIDA


            Console.WriteLine("“O funcionário {0} trabalhou {1} horas por R$ {2} e deve receber R${3}.", nome, hora, valorHora, salario );
            





        }
    }
}
