using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exercicio_Salario1
{
    class Funcionario
    {
        public string nome;
        public decimal valorHora;
        public double hora;

        public Funcionario(string nome, decimal valorHora, double hora)
        {
            this.nome = nome;
            this.valorHora = valorHora;
            this.hora = hora;
        }


        public decimal getSalario()
        {
            return Convert.ToDecimal(hora) * valorHora; 
        }
    }
}
