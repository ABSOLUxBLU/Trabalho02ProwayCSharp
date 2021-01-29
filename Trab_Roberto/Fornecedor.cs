using System;
using System.Collections.Generic;
using System.Text;

namespace Trab_Roberto
{
    class Fornecedor
    {
        public string nome { get; set; }
        public string cnpj { get; set; }
        public int tipoDeProduto { get; set; }
        public int qtdFornecidaAoMes { get; set; }

        public Fornecedor(string nome, string cnpj, int tipoDeProduto, int qtdFornecidaAoMes)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.tipoDeProduto = tipoDeProduto;
            this.qtdFornecidaAoMes = qtdFornecidaAoMes;
        }
        public void DefineDados(string Nome, string Cpf, int tipoDeProduto)
        {
            this.nome = Nome;
            this.cnpj = Cpf;
            this.tipoDeProduto = tipoDeProduto;
        }
        public void MostraDados()
        {
            Console.WriteLine("Nome: " + nome + "\nCNPJ: " + cnpj + "\nTipo De Produto: " + tipoDeProduto);
        }
        public void MostraQuantidadeFornecida()
        {
            Console.WriteLine("Quantidade Fornecida: " + qtdFornecidaAoMes);
        }
        public void DefineQuantidadeFornecida(int qtdFornecidaAoMes)
        {
            this.qtdFornecidaAoMes = qtdFornecidaAoMes;
        }
    }
}
