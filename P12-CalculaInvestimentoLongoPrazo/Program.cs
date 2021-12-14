using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12.");

            double fatorRendimento = 1.0016;
            double valorInvestido = 1000.0;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {

                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;

                    if (contadorAno == 1)
                    {
                        switch (contadorMes)
                        {
                            case 1:
                                Console.WriteLine(@"
No mês de janeiro, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 2:
                                Console.WriteLine(@"
No mês de fevereiro, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 3:
                                Console.WriteLine(@"
No mês de março, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 4:
                                Console.WriteLine(@"
No mês de abril, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 5:
                                Console.WriteLine(@"
No mês de maio, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 6:
                                Console.WriteLine(@"
No mês de junho, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 7:
                                Console.WriteLine(@"
No mês de julho, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 8:
                                Console.WriteLine(@"
No mês de agosto, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 9:
                                Console.WriteLine(@"
No mês de setembro, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 10:
                                Console.WriteLine(@"
No mês de outubro, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 11:
                                Console.WriteLine(@"
No mês de novembro, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 12:
                                Console.WriteLine(@"
No mês de dezembro, com " + contadorAno + " ano de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                        }
                    }
                    else
                    {
                        switch (contadorMes)
                        {
                            case 1:
                                Console.WriteLine(@"
No mês de janeiro, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 2:
                                Console.WriteLine(@"
No mês de fevereiro, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 3:
                                Console.WriteLine(@"
No mês de março, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 4:
                                Console.WriteLine(@"
No mês de abril, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 5:
                                Console.WriteLine(@"
No mês de maio, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 6:
                                Console.WriteLine(@"
No mês de junho, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 7:
                                Console.WriteLine(@"
No mês de julho, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 8:
                                Console.WriteLine(@"
No mês de agosto, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 9:
                                Console.WriteLine(@"
No mês de setembro, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 10:
                                Console.WriteLine(@"
No mês de outubro, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 11:
                                Console.WriteLine(@"
No mês de novembro, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                            case 12:
                                Console.WriteLine(@"
No mês de dezembro, com " + contadorAno + " anos de valor investido, meu valor investido foi de " +
    valorInvestido + " reais.");
                                break;
                        }
                    }
                }

                fatorRendimento += 0.001;
            }
            Console.WriteLine("\nAo término de 5 anos, o valor será de R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}


