using System;
using System.Collections.Generic;
using System.Text;

namespace Trab_Roberto
{
    class ClienteSocio : ClienteNormal
    {
        public double qtdAcoes { get; set; }

        public ClienteSocio(string nome, string cpf, int idade, double saldo, double qtdAcoes) : base(nome,cpf,idade,saldo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.saldo = saldo;
            this.qtdAcoes = qtdAcoes;
        }

        public void MostraAcoes()
        {
            Console.WriteLine("Ações: " + qtdAcoes);
        }
        public void DefineAcoes(double qtdAcoes)
        {
            this.qtdAcoes = qtdAcoes;
        }
    }
}
