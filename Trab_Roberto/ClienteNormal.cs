using System;
using System.Collections.Generic;
using System.Text;

namespace Trab_Roberto
{
    class ClienteNormal
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
        public double saldo { get; set; }

        public ClienteNormal(string nome, string cpf, int idade, double saldo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.saldo = saldo;
        }

        public void MostraDados()
        {
            Console.WriteLine("Nome: " + nome + "\nCPF: " + cpf + "\nIdade: " + idade + "\nSaldo: " + saldo);
        }

        public void DefineDados(string Nome, string Cpf, int Idade, double Saldo)
        {
            this.nome = Nome;
            this.cpf = Cpf;
            this.idade = Idade;
            this.saldo = Saldo;
        }
    }
}
