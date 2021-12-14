using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJoao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario <= 2800.0)
            {
                Console.WriteLine("Seu IR é de 7.5% e pode deduzir na declaração o valor de R$ 142.");
                Console.ReadLine();
            }
            if (salario >= 2800.1 && salario <= 3751.0)
            {
                Console.WriteLine("Seu IR é de 15% e pode deduzir na declaração o valor de R$ 350.");
                Console.ReadLine();
            }
            if (salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("Seu IR é de 22.5% e pode deduzir na declaração o valor de R$ 636.");
                Console.ReadLine();
            }
        }

    }
}

