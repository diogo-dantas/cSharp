using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        private string _profissao;
        private Endereco _local;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public Endereco Local { get; set; }

    }



    public class Endereco
    {
        private string _logradouro;
        private string _bairro;
        private string _cidade;
        private string _cep;

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
    }

}
