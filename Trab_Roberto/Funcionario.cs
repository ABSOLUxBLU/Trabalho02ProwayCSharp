using System;
using System.Collections.Generic;
using System.Text;

namespace Trab_Roberto
{
    class Funcionario : ClienteNormal
    {
        public double salarioPorHora { get; set; }
        public string cargo { get; set; }

        public Funcionario(string nome, string cpf, int idade, double saldo, double salarioPorHora, string cargo) : base(nome,cpf,idade,saldo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.saldo = saldo;
            this.salarioPorHora = salarioPorHora;
            this.cargo = cargo;
        }

        public void MostraCargoSalario()
        {
            Console.WriteLine("Salário Por Hora: " + salarioPorHora + "\nCargo: " + cargo);
        }
        public void DefineCargoSalario(double salarioPorHora, string cargo)
        {
            this.salarioPorHora = salarioPorHora;
            this.cargo = cargo;
        }
        public double BatePonto(int hrEntrada, int hrSaida)
        {
            int horaFinal = hrSaida - hrEntrada;
            double saldoFinal = horaFinal * salarioPorHora;
            saldoFinal = saldo + saldoFinal;
            return saldoFinal;
        }
    }
}
