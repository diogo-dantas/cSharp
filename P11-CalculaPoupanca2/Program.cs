using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11.");

            double valorInvestido = 1000.0;
            double rendimentoMensal = 1.0016;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= rendimentoMensal;

                if (contadorMes == 1)
                {
                    Console.WriteLine(@"
Após " + contadorMes + " mês investindo na poupança, meu saldo foi para " + valorInvestido + " reais.");
                }
                else
                {
                    Console.WriteLine(@"
Após " + contadorMes + " meses investindo na poupança, meu saldo foi para " + valorInvestido + " reais.");
                    //contador += 2; por exemplo para valores acima de 01
                }

            }


            Console.ReadLine();
        }
    }
}
