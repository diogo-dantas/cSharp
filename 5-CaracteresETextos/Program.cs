using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos.");

            char letra = 'a';
            Console.WriteLine(letra);
            //typecasting letra adição de letras do alfabeto  - ASCII TABLE
            letra = (char)(letra + 2);
            Console.WriteLine(letra);

            string titulo = "Curso de C#";
            Console.WriteLine(titulo + 2010);

            string tabela =
@"-item1;
-item2;
-item3";
            Console.WriteLine(tabela);


            Console.WriteLine("Projeto executado. Pressione ENTER para sair.");
            Console.ReadLine();
        }
    }
}
