using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaExemplo = new ContaCorrente();
            ContaExemplo.titular = "Gerson Inacio";
            ContaExemplo.agencia = 1234;
            ContaExemplo.numero = 56789;
            
            Console.WriteLine(ContaExemplo.titular + "\nAgência: " + ContaExemplo.agencia);
            
            ContaExemplo.Depositar(100);
            Console.WriteLine(ContaExemplo.saldo);

            ContaExemplo.Sacar(50);
            Console.WriteLine(ContaExemplo.saldo);

            ContaCorrente ContaDiferente = new ContaCorrente();
            ContaDiferente.titular = "Tadeu Araujo";
            ContaDiferente.saldo = 1200.00;
            ContaExemplo.agencia = 1234;
            ContaExemplo.numero = 64582;

            bool ResultadoTransferencia = ContaExemplo.Transferir(1300.00, ContaDiferente);

            Console.WriteLine("O saldo atual de Gerson é " + ContaExemplo.saldo);

            Console.WriteLine("A Transferência foi permitda? " + ResultadoTransferencia);

            ContaDiferente.Transferir(500.00, ContaExemplo);

            Console.WriteLine("O saldo novo de Gerson é " + ContaExemplo.saldo);

            Console.ReadLine();

        }


    }
}
