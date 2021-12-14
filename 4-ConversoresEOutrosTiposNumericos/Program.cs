using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoresEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4.");
            Console.WriteLine("\nEste é um exemplo de type casting: ");
            double exemplo = 123.45;          
            int trocaExemplo = (int) exemplo;
            Console.WriteLine("\nNúmero inicial: " + exemplo + " .");
            Console.WriteLine("Valor após o casting: " + trocaExemplo);

            // O int suporta até 32 bits.

            long codigo = 1500000000000000;
            Console.WriteLine("Esse é um exemplo de código long: " + codigo);
            short codigoInverso = 16000;
            Console.WriteLine("Esse é um exemplo de código short: " + codigoInverso);
            // O Long é um tipo de variável de 64 bits. Todavia o short, possui apenas 16 bits.

            float altura = 1.80f;
            Console.WriteLine("Esse é um exemplo de código float: " + altura);

            // O tipo float possui uma precisão menor de casas após a vírgula em relação ao tipo double.
            // Por não ser usual, o numero do tipo float deve ser declarado com o "f" após sua numeração.
            Console.WriteLine("Projeto executado. Pressione ENTER para sair.");
            Console.ReadLine();
        }
    }
}
