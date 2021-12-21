using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaExemplo = new ContaCorrente();
            // instancia da classe ContaCorrente - objeto contaExemplo

            contaExemplo.agencia = 6311;
            contaExemplo.numero = 37438;
            contaExemplo.titular = "José Alfredo Silva";
            contaExemplo.saldo = 1000.0;

            Console.WriteLine("Saldo: " + contaExemplo.saldo);

            Console.ReadLine();
        }
    }
}
