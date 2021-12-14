using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis ponto flutuante.");

            double salario = 3456.65;

            Console.WriteLine("\nO salário de José é " + salario + " reais.");

            Console.WriteLine("\n Para apresentar uma resposta como double em uma divisão, é necessario informar o número um dos números no formato '.'. ");
            double exemplo = 15.0 / 2;
            Console.WriteLine("\t O resultado será o esperado: " + exemplo + " .");
            
            Console.WriteLine("Comando executado. Pressione ENTER para sair.");
            Console.ReadLine();

        }
    }
}
