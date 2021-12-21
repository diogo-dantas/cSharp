using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente p = new ContaCorrente();
            p.titular = new Cliente();
            p.titular.nome = " Gilberto Nunes";
            p.titular.cpf = "353.543.632-80";
            p.titular.profissao = "Desenvolvedor";
            p.titular.endereco = new Endereco();
            p.titular.endereco.logradouro = "R. Clelia";
            p.titular.endereco.cidade = "Santo André";
            p.titular.endereco.cep = "09196-410";
            p.agencia = 0543210;

            Console.WriteLine(p.titular.nome);
            Console.WriteLine(p.titular.cpf);
            Console.WriteLine(p.titular.profissao);
            Console.WriteLine(p.titular.endereco.logradouro);
            Console.WriteLine(p.titular.endereco.cep);
            Console.WriteLine(p.agencia);

            Console.ReadLine();

        }
    }
}
