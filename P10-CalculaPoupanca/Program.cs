using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10.");


            double valorInvestido = 1000.0;
            double rendimentoMensal = 0.0016;
            int contadorMes = 1;


            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * rendimentoMensal;

                if (contadorMes == 1)
                {
                    Console.WriteLine(@"
Após " + contadorMes + " mês investindo na poupança, meu saldo foi para " + valorInvestido + " reais.");
                    contadorMes++;
                }
                else
                {
                    Console.WriteLine(@"
Após " + contadorMes + " meses investindo na poupança, meu saldo foi para " + valorInvestido + " reais.");
                    contadorMes++;
                    //contador += 2; por exemplo para valores acima de 01
                }

            }

            Console.WriteLine("Projeto finalizado. Pressione ENTER para sair.");
            Console.ReadLine();




        }
    }
}
