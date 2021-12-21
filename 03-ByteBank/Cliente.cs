using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;
        public Endereco endereco;
    }

    public class Endereco
    {
        public string logradouro;
        public string bairro;
        public string cidade;
        public string cep;
    }

}
