using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 12345);
            Cliente cliente = new Cliente();

            cliente.Nome = "Gerson Antunes";
            cliente.CPF = "353.894.681-30";
            cliente.Profissao = "Bombeiro";
           

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContas);


            Console.ReadLine();

            

        }
    }
}
