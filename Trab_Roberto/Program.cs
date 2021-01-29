using System;
using System.Collections.Generic;
using System.Threading;

namespace Trab_Roberto
{
    class Program
    {
        //¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨//
        //                                                                                 //
        //                                                                                 //
        //                                C# - TRABALHO Nº2                                //
        //                                                                                 //
        //                                                                                 //
        //                                                                                 //
        //                  > FEITO POR: Roberto Pamplona Soares Júnior.                   //
        //                                                                                 //
        //                                                                                 //
        //_________________________________________________________________________________//

        //Gera quantia de ação aleatória
        public static double GeraAcao()
        {
            Random Ran = new Random();
            double acao = Math.Round(Ran.NextDouble() * 4.95, 2);
            return acao;
        }
        //Gera Salário aleatório
        public static int GeraSalarioPorHora()
        {
            Random Ran = new Random();
            int salarioPorHora = Ran.Next(10, 25);
            return salarioPorHora;
        }
        //Bate Cartão por 30 dias
        public static void BateCartaoMensal(Funcionario funcionario)
        {
            for (int i = 0; i < 30; i++)
            {
                Random Ran = new Random();
                int entrada = Ran.Next(8, 11);
                int saida = Ran.Next(7, 9) + entrada;
                funcionario.saldo = funcionario.BatePonto(entrada, saida);
            }
        }
        //Verificador de CPF
        public static bool VerificadorCPF(string cpf)
        {
            bool permitir = true;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (cpf == clientes[i].cpf)
                {
                    permitir = false;
                    break;
                }
            }
            if (permitir != false)
            {
                for (int i = 0; i < socios.Count; i++)
                {
                    if (cpf == socios[i].cpf)
                    {
                        permitir = false;
                        break;
                    }
                }
            }
            if (permitir != false)
            {
                for (int i = 0; i < funcionarios.Count; i++)
                {
                    if (cpf == funcionarios[i].cpf)
                    {
                        permitir = false;
                        break;
                    }
                }
            }
            if (permitir == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Verificador de CNPJ
        public static bool VerificadorCNPJ(string cnpj)
        {
            bool permitir = true;
            for (int i = 0; i < fornecedores.Count; i++)
            {
                if (cnpj == fornecedores[i].cnpj)
                {
                    permitir = false;
                    break;
                }
            }
            if (permitir == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //RAINBOW
        public static string Colorido(int cor)
        {
            if (cor == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Obrigado por usufruir do Programa!";
            }
            else if (cor == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return "Obrigado por usufruir do Programa!";
            }
            else if (cor == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Obrigado por usufruir do Programa!";
            }
            else if (cor == 3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                return "Obrigado por usufruir do Programa!";
            }
            else if (cor == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                return "Obrigado por usufruir do Programa!";
            }
            else if (cor == 5)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                return "Obrigado por usufruir do Programa!";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                return "Obrigado por usufruir do Programa!";
            }
        }

        //Acessa em todos os Lugares.
        static List<ClienteNormal> clientes = new List<ClienteNormal>();
        static List<ClienteSocio> socios = new List<ClienteSocio>();
        static List<Fornecedor> fornecedores = new List<Fornecedor>();
        static List<Funcionario> funcionarios = new List<Funcionario>();

        static void Main(string[] args)
        {
            Program pro = new Program();
            string nome;
            string cpf;
            int idade;
            double saldo;
            double caixa = 0;
            string escolha = "";

            //Primeiros Clientes, Sócios e Funcionários.
            for (int i = 0; i < 5; i++)
            {
                nome = Gerador.NomePessoa();
                cpf = Gerador.Cpf();
                bool permite = VerificadorCPF(cpf);
                for (int j = 0; 3 > 0; j++)
                {
                    if (permite == false)
                    {
                        cpf = Gerador.Cpf();
                    }
                    if (permite == true)
                    {
                        break;
                    }
                }
                idade = Gerador.Idade();
                saldo = Gerador.Saldo();
                ClienteNormal clienteBase = new ClienteNormal(nome, cpf, idade, saldo);
                clientes.Add(clienteBase);
                //Console.WriteLine("{0} || {1} || {2} || {3:C2}", clienteBase.nome, clienteBase.cpf, clienteBase.idade, clienteBase.saldo);
            }
            //Console.WriteLine("- - - - -");
            for (int i = 0; i < 2; i++)
            {
                nome = Gerador.NomePessoa();
                cpf = Gerador.Cpf();
                bool permite = VerificadorCPF(cpf);
                for (int j = 0; 3 > 0; j++)
                {
                    if (permite == false)
                    {
                        cpf = Gerador.Cpf();
                    }
                    if (permite == true)
                    {
                        break;
                    }
                }
                idade = Gerador.Idade();
                saldo = Gerador.Saldo();
                double qtdAcoes = GeraAcao();
                ClienteSocio clienteSocioBase = new ClienteSocio(nome, cpf, idade, saldo, qtdAcoes);
                socios.Add(clienteSocioBase);
                //Console.WriteLine("{0} || {1} || {2} || {3:C2} || {4}", clienteSocioBase.nome, clienteSocioBase.cpf, clienteSocioBase.idade, clienteSocioBase.saldo,clienteSocioBase.qtdAcoes);
            }
            //Console.WriteLine("- - - - -");
            for (int i = 0; i < 5; i++)
            {
                nome = Gerador.NomePessoa();
                cpf = Gerador.Cpf();
                bool permite = VerificadorCPF(cpf);
                for (int j = 0; 3 > 0; j++)
                {
                    if (permite == false)
                    {
                        cpf = Gerador.Cpf();
                    }
                    if (permite == true)
                    {
                        break;
                    }
                }
                idade = Gerador.Idade();
                saldo = Gerador.Saldo();
                double salarioPorHora = GeraSalarioPorHora();
                string cargo = "Repositor";
                Funcionario funcionarioBase = new Funcionario(nome, cpf, idade, saldo, salarioPorHora, cargo);
                funcionarios.Add(funcionarioBase);
                //Console.WriteLine("{0} || {1} || {2} || {3:C2} || {4:C2} || {5}",nome, cpf, idade, saldo, salarioPorHora, cargo);
            }

            //--- MENU --- MENU --- MENU --- MENU --- MENU --- MENU --- MENU --- MENU --- MENU --- MENU --- MENU --- MENU ---
            for (int i = 0; 3 > 0; i++)
            {
                //Mostra Infos no Menu!!!
                //for (int q = 0; q < clientes.Count; q++)
                //{
                //    clientes[q].MostraDados();
                //}
                //Console.WriteLine();
                //for (int q = 0; q < socios.Count; q++)
                //{
                //    socios[q].MostraDados();
                //    socios[q].MostraAcoes();
                //}
                //Console.WriteLine();
                //for (int q = 0; q < funcionarios.Count; q++)
                //{
                //    funcionarios[q].MostraDados();
                //    funcionarios[q].MostraCargoSalario();
                //}

                Console.WriteLine("| _ . - + = ¨ MENU ¨ = + - . _ |");
                Console.WriteLine();
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Comprar");
                Console.WriteLine("4. Bater Cartão");
                Console.WriteLine("5. Alterar");
                Console.WriteLine("6. Calcular Lucro");
                Console.WriteLine("7. Sair");
                escolha = Console.ReadLine();

                //--- ADICIONAR --- ADICIONAR --- ADICIONAR --- ADICIONAR --- ADICIONAR --- ADICIONAR --- ADICIONAR --- ADICIONAR ---
                if (escolha == "1")
                {
                    for (int j = 0; 3 > 0; j++)
                    {
                        Console.Clear();
                        Console.WriteLine("| _ . - + = ¨ ADICIONAR ¨ = + - . _ |");
                        Console.WriteLine();
                        Console.WriteLine("1. Cliente.");
                        Console.WriteLine("2. Sócio.");
                        Console.WriteLine("3. Funcionário.");
                        Console.WriteLine("4. Fornecedor.");
                        Console.WriteLine();
                        Console.WriteLine("5. Voltar.");
                        escolha = Console.ReadLine();
                        if (escolha == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ CLIENTE ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("Nome: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("CPF: | Ex: 000.000.000-00");
                            cpf = Console.ReadLine();
                            bool permite = VerificadorCPF(cpf);
                            if (permite == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Impossivel Executar a Instrução.");
                                Console.WriteLine("CPF Repetido!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Idade: ");
                                idade = int.Parse(Console.ReadLine());
                                Console.WriteLine("Saldo: ");
                                saldo = double.Parse(Console.ReadLine());
                                ClienteNormal clienteBase = new ClienteNormal(nome, cpf, idade, saldo);
                                clientes.Add(clienteBase);
                                Console.WriteLine("Cliente Adicionado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "2")
                        {
                            if (socios.Count > 10)
                            {
                                Console.Clear();
                                Console.WriteLine("Limite máximo de Sócios atingido!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ SÓCIO ¨ = + - . _ |");
                            Console.WriteLine();

                            Console.WriteLine("Nome: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("CPF: | Ex: 000.000.000-00");
                            cpf = Console.ReadLine();
                            bool permite = VerificadorCPF(cpf);
                            if (permite == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Impossivel Executar a Instrução.");
                                Console.WriteLine("CPF Repetido!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Idade: ");
                                idade = int.Parse(Console.ReadLine());
                                Console.WriteLine("Saldo: ");
                                saldo = double.Parse(Console.ReadLine());
                                Console.WriteLine("Quantidade de Ações:  |   Máximo de 4.95%");
                                Console.WriteLine("OBS: Caso de maior que o Máximo, Ação redefinida para 4.95%");
                                double qtdAcoes = double.Parse(Console.ReadLine());
                                if (qtdAcoes > 4.95)
                                {
                                    qtdAcoes = 4.95;
                                }
                                ClienteSocio clienteSocioBase = new ClienteSocio(nome, cpf, idade, saldo, qtdAcoes);
                                socios.Add(clienteSocioBase);
                                Console.WriteLine("Sócio Adicionado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ FUNCIONÁRIO ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("Nome: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("CPF: | Ex: 000.000.000-00");
                            cpf = Console.ReadLine();
                            bool permite = VerificadorCPF(cpf);
                            if (permite == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Impossivel Executar a Instrução.");
                                Console.WriteLine("CPF Repetido!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Idade: ");
                                idade = int.Parse(Console.ReadLine());
                                Console.WriteLine("Saldo: ");
                                saldo = double.Parse(Console.ReadLine());
                                Console.WriteLine("Salário Por Hora: ");
                                double salarioPorHora = double.Parse(Console.ReadLine());
                                Console.WriteLine("Cargo: ");
                                string cargo = Console.ReadLine();
                                Funcionario funcionarioBase = new Funcionario(nome, cpf, idade, saldo, salarioPorHora, cargo);
                                funcionarios.Add(funcionarioBase);
                                Console.WriteLine("Funcionário Adicionado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "4")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ FORNECEDOR ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("Nome: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("CNPJ: | Ex: 00.000-0");
                            string cnpj = Console.ReadLine();
                            bool permite = VerificadorCNPJ(cnpj);
                            if (permite == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Impossivel Executar a Instrução.");
                                Console.WriteLine("CNPJ Repetido!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tipo de Produto: | 1 ao 6");
                                int tipoDeProduto = int.Parse(Console.ReadLine());
                                if (tipoDeProduto > 6)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Impossivel Executar a Instrução.");
                                    Console.WriteLine("Tipo de Produto Inválido!");
                                    Console.WriteLine("Voltando ao Menu!");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                }
                                Console.WriteLine("Quantidade Fornecida no Mês: ");
                                int qtdFornecidaAoMes = int.Parse(Console.ReadLine());
                                Fornecedor FornecedorBase = new Fornecedor(nome, cnpj, tipoDeProduto, qtdFornecidaAoMes);
                                fornecedores.Add(FornecedorBase);
                                Console.WriteLine("Fornecedor Adicionado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "5")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Impossível executar a instrução!");
                            Console.WriteLine("Voltando ao Menu!");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    }
                }
                //--- REMOVER --- REMOVER --- REMOVER --- REMOVER --- REMOVER --- REMOVER --- REMOVER --- REMOVER --- REMOVER --- REMOVER ---
                else if (escolha == "2")
                {
                    for (int j = 0; 3 > 0; j++)
                    {
                        Console.Clear();
                        Console.WriteLine("| _ . - + = ¨ REMOVER ¨ = + - . _ |");
                        Console.WriteLine();
                        Console.WriteLine("1. Cliente.");
                        Console.WriteLine("2. Sócio.");
                        Console.WriteLine("3. Funcionário.");
                        Console.WriteLine("4. Fornecedor.");
                        Console.WriteLine();
                        Console.WriteLine("5. Voltar.");
                        escolha = Console.ReadLine();
                        if (escolha == "1")
                        {
                            bool removeu = false;
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ CLIENTE ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("Insira o CPF de quem deseja REMOVER: ");
                            cpf = Console.ReadLine();
                            for (int k = 0; k < clientes.Count; k++)
                            {
                                if (clientes[k].cpf == cpf)
                                {
                                    removeu = true;
                                    clientes.RemoveAt(k);
                                }
                            }
                            if (!removeu)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "2")
                        {
                            bool removeu = false;
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ SÓCIO ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("Insira o CPF de quem deseja REMOVER: ");
                            cpf = Console.ReadLine();
                            for (int k = 0; k < socios.Count; k++)
                            {
                                if (socios[k].cpf == cpf)
                                {
                                    removeu = true;
                                    socios.RemoveAt(k);
                                }
                            }
                            if (!removeu)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "3")
                        {
                            bool removeu = false;
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ FUNCIONÁRIO ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("Insira o CPF de quem deseja REMOVER: ");
                            cpf = Console.ReadLine();
                            for (int k = 0; k < funcionarios.Count; k++)
                            {
                                if (funcionarios[k].cpf == cpf)
                                {
                                    removeu = true;
                                    funcionarios.RemoveAt(k);
                                }
                            }
                            if (!removeu)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "4")
                        {
                            bool removeu = false;
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ FORNECEDOR ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("Insira o CNPJ de quem deseja REMOVER: ");
                            string cnpj = Console.ReadLine();
                            for (int k = 0; k < fornecedores.Count; k++)
                            {
                                if (fornecedores[k].cnpj == cnpj)
                                {
                                    removeu = true;
                                    fornecedores.RemoveAt(k);
                                }
                            }
                            if (!removeu)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "5")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Impossível executar a instrução!");
                            Console.WriteLine("Voltando ao Menu!");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    }
                }
                //--- COMPRAR --- COMPRAR --- COMPRAR --- COMPRAR --- COMPRAR --- COMPRAR --- COMPRAR --- COMPRAR --- COMPRAR --- COMPRAR ---
                else if (escolha == "3")
                {
                    for (int j = 0; 3 > 0; j++)
                    {
                        Console.Clear();
                        Console.WriteLine("| _ . - + = ¨ COMPRAR ¨ = + - . _ |");
                        Console.WriteLine();
                        Console.WriteLine("1. Cliente.");
                        Console.WriteLine("2. Sócio.");
                        Console.WriteLine();
                        Console.WriteLine("5. Voltar.");
                        escolha = Console.ReadLine();
                        if (escolha == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ CLIENTE ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("- Lista:");
                            for (int k = 0; k < clientes.Count; k++)
                            {
                                Console.WriteLine("Nome: {0} | CPF: {1}", clientes[k].nome, clientes[k].cpf);
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Insira o CPF de quem está comprando: ");
                            cpf = Console.ReadLine();
                            bool achou = false;
                            for (int k = 0; k < clientes.Count; k++)
                            {
                                if (clientes[k].cpf == cpf)
                                {
                                    Console.WriteLine("Insira o Total da Compra: ");
                                    double total = double.Parse(Console.ReadLine());
                                    clientes[k].saldo += total;
                                    achou = true;
                                    break;
                                }
                            }
                            if (!achou)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ SÓCIO ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("- Lista:");
                            for (int k = 0; k < socios.Count; k++)
                            {
                                Console.WriteLine("Nome: {0} | CPF: {1}", socios[k].nome, socios[k].cpf);
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Insira o CPF de quem está comprando: ");
                            cpf = Console.ReadLine();
                            bool achou = false;
                            for (int k = 0; k < socios.Count; k++)
                            {
                                if (socios[k].cpf == cpf)
                                {
                                    Console.WriteLine("Insira o Total da Compra: ");
                                    double total = double.Parse(Console.ReadLine());
                                    total = total - (0.20 * total);
                                    socios[k].saldo += total;
                                    achou = true;
                                    break;
                                }
                            }
                            if (!achou)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "5")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Impossível executar a instrução!");
                            Console.WriteLine("Voltando ao Menu!");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    }
                }
                //--- BATE CARTÃO --- BATE CARTÃO --- BATE CARTÃO --- BATE CARTÃO --- BATE CARTÃO --- BATE CARTÃO --- BATE CARTÃO --- BATE CARTÃO ---
                else if (escolha == "4")
                {
                    Console.Clear();
                    Console.WriteLine("| _ . - + = ¨ FUNCIONARIOS ¨ = + - . _ |");
                    Console.WriteLine();
                    Console.WriteLine("- Lista:");
                    for (int j = 0; j < funcionarios.Count; j++)
                    {
                        Console.WriteLine("Nome: {0} | CPF: {1}", funcionarios[j].nome, funcionarios[j].cpf);
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Insira o CPF de quem está Batendo Cartão: ");
                    cpf = Console.ReadLine();
                    bool achou = false;
                    for (int k = 0; k < funcionarios.Count; k++)
                    {
                        if (funcionarios[k].cpf == cpf)
                        {
                            achou = true;
                            Console.WriteLine();
                            Console.WriteLine("1. Bater Cartão 1 Dia.");
                            Console.WriteLine("2. Bater Cartão 30 Dias.");
                            escolha = Console.ReadLine();
                            if (escolha == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("Informe o Horário de Entrada: ");
                                int entrada = int.Parse(Console.ReadLine());
                                Console.WriteLine("Informe o Horário de Saída: ");
                                int saida = int.Parse(Console.ReadLine());
                                funcionarios[k].saldo = funcionarios[k].BatePonto(entrada, saida);
                                Console.WriteLine();
                                Console.WriteLine("Cartão Batido!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                            else if (escolha == "2")
                            {
                                BateCartaoMensal(funcionarios[k]);
                                Console.WriteLine("Cartão Batido por 30 Dias!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                    }
                    if (!achou)
                    {
                        Console.Clear();
                        Console.WriteLine("CPF não localizado!");
                        Console.WriteLine("Voltando ao Menu!");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                //--- ALTERAR --- ALTERAR --- ALTERAR --- ALTERAR --- ALTERAR --- ALTERAR --- ALTERAR --- ALTERAR --- ALTERAR --- ALTERAR ---
                else if (escolha == "5")
                {
                    for (int j = 0; 3 > 0; j++)
                    {
                        Console.Clear();
                        Console.WriteLine("| _ . - + = ¨ ALTERAR ¨ = + - . _ |");
                        Console.WriteLine();
                        Console.WriteLine("1. Cliente.");
                        Console.WriteLine("2. Sócio.");
                        Console.WriteLine("3. Funcionário.");
                        Console.WriteLine("4. Fornecedor.");
                        Console.WriteLine();
                        Console.WriteLine("5. Voltar.");
                        escolha = Console.ReadLine();
                        if (escolha == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ CLIENTE ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("- Lista:");
                            for (int k = 0; k < clientes.Count; k++)
                            {
                                Console.WriteLine("Nome: {0} | CPF: {1}", clientes[k].nome, clientes[k].cpf);
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Insira o CPF de quem deseja ALTERAR: ");
                            cpf = Console.ReadLine();
                            bool achou = false;
                            for (int k = 0; k < clientes.Count; k++)
                            {
                                if (clientes[k].cpf == cpf)
                                {
                                    achou = true;
                                    Console.WriteLine();
                                    Console.WriteLine("Nome: ");
                                    nome = Console.ReadLine();
                                    Console.WriteLine("CPF: | Ex: 000.000.000-00");
                                    cpf = Console.ReadLine();
                                    bool permite = VerificadorCPF(cpf);
                                    if (permite == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Impossivel Executar a Instrução.");
                                        Console.WriteLine("CPF Repetido!");
                                        Console.WriteLine("Voltando ao Menu!");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Idade: ");
                                        idade = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Saldo: ");
                                        saldo = double.Parse(Console.ReadLine());
                                        clientes[k].DefineDados(nome, cpf, idade, saldo);
                                        Console.WriteLine("Cliente Atualizado!");
                                        Console.WriteLine("Voltando ao Menu!");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                    }
                                }
                            }
                            if (!achou)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ SÓCIO ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("- Lista:");
                            for (int k = 0; k < socios.Count; k++)
                            {
                                Console.WriteLine("Nome: {0} | CPF: {1}", socios[k].nome, socios[k].cpf);
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Insira o CPF de quem deseja ALTERAR: ");
                            cpf = Console.ReadLine();
                            bool achou = false;
                            for (int k = 0; k < socios.Count; k++)
                            {
                                if (socios[k].cpf == cpf)
                                {
                                    achou = true;
                                    Console.WriteLine();
                                    Console.WriteLine("Nome: ");
                                    nome = Console.ReadLine();
                                    Console.WriteLine("CPF: | Ex: 000.000.000-00");
                                    cpf = Console.ReadLine();
                                    bool permite = VerificadorCPF(cpf);
                                    if (permite == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Impossivel Executar a Instrução.");
                                        Console.WriteLine("CPF Repetido!");
                                        Console.WriteLine("Voltando ao Menu!");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Idade: ");
                                        idade = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Saldo: ");
                                        saldo = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Quantidade de Ações:  |   Máximo de 4.95%");
                                        Console.WriteLine("OBS: Caso de maior que o Máximo, Ação redefinida para 4.95%");
                                        double qtdAcoes = double.Parse(Console.ReadLine());
                                        if (qtdAcoes > 4.95)
                                        {
                                            qtdAcoes = 4.95;
                                        }
                                        socios[k].DefineDados(nome, cpf, idade, saldo);
                                        socios[k].DefineAcoes(qtdAcoes);
                                        Console.WriteLine("Sócio Atualizado!");
                                        Console.WriteLine("Voltando ao Menu!");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                    }
                                }
                            }
                            if (!achou)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ FUNCIONÁRIO ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("- Lista:");
                            for (int k = 0; k < funcionarios.Count; k++)
                            {
                                Console.WriteLine("Nome: {0} | CPF: {1}", funcionarios[k].nome, funcionarios[k].cpf);
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Insira o CPF de quem deseja ALTERAR: ");
                            cpf = Console.ReadLine();
                            bool achou = false;
                            for (int k = 0; k < funcionarios.Count; k++)
                            {
                                if (funcionarios[k].cpf == cpf)
                                {
                                    achou = true;
                                    Console.WriteLine();
                                    Console.WriteLine("Nome: ");
                                    nome = Console.ReadLine();
                                    Console.WriteLine("CPF: | Ex: 000.000.000-00");
                                    cpf = Console.ReadLine();
                                    bool permite = VerificadorCPF(cpf);
                                    if (permite == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Impossivel Executar a Instrução.");
                                        Console.WriteLine("CPF Repetido!");
                                        Console.WriteLine("Voltando ao Menu!");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Idade: ");
                                        idade = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Saldo: ");
                                        saldo = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Salário Por Hora: ");
                                        double salarioPorHora = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Cargo: ");
                                        string cargo = Console.ReadLine();
                                        funcionarios[k].DefineDados(nome, cpf, idade, saldo);
                                        funcionarios[k].DefineCargoSalario(salarioPorHora, cargo);
                                        Console.WriteLine("Funcionário Atualizado!");
                                        Console.WriteLine("Voltando ao Menu!");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                    }
                                }
                            }
                            if (!achou)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "4")
                        {
                            Console.Clear();
                            Console.WriteLine("| _ . - + = ¨ FORNECEDOR ¨ = + - . _ |");
                            Console.WriteLine();
                            Console.WriteLine("- Lista:");
                            for (int k = 0; k < fornecedores.Count; k++)
                            {
                                Console.WriteLine("Nome: {0} | CPF: {1}", fornecedores[k].nome, fornecedores[k].cnpj);
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Insira o CNPJ de quem deseja ALTERAR: ");
                            string cnpj = Console.ReadLine();
                            bool achou = false;
                            for (int k = 0; k < fornecedores.Count; k++)
                            {
                                if (fornecedores[k].cnpj == cnpj)
                                {
                                    achou = true;
                                    Console.WriteLine();
                                    Console.WriteLine("Nome: ");
                                    nome = Console.ReadLine();
                                    Console.WriteLine("CNPJ: | Ex: 00.000-0");
                                    cnpj = Console.ReadLine();
                                    bool permite = VerificadorCNPJ(cnpj);
                                    if (permite == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Impossivel Executar a Instrução.");
                                        Console.WriteLine("CNPJ Repetido!");
                                        Console.WriteLine("Voltando ao Menu!");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Tipo de Produto: ");
                                        int tipoDeProduto = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Quantidade Fornecida no Mês: ");
                                        int qtdFornecidaAoMes = int.Parse(Console.ReadLine());
                                        fornecedores[k].DefineDados(nome, cnpj, tipoDeProduto);
                                        fornecedores[k].DefineQuantidadeFornecida(qtdFornecidaAoMes);
                                        Console.WriteLine("Fornecedor Atualizado!");
                                        Console.WriteLine("Voltando ao Menu!");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                    }
                                }
                            }
                            if (!achou)
                            {
                                Console.Clear();
                                Console.WriteLine("CNPJ não localizado!");
                                Console.WriteLine("Voltando ao Menu!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        else if (escolha == "5")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Impossível executar a instrução!");
                            Console.WriteLine("Voltando ao Menu!");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    }
                }
                //--- CALCULA LUCRO --- CALCULA LUCRO --- CALCULA LUCRO --- CALCULA LUCRO --- CALCULA LUCRO --- CALCULA LUCRO --- CALCULA LUCRO ---
                else if (escolha == "6")
                {
                    double saldoTotal = 0;
                    double prejuTotal = 0;
                    double acoesTotal = 0;
                    double parcelaSocio = 0;
                    double totalTemp = 0;
                    //Console.WriteLine("{0} {1} {2} {3} {4}", saldoTotal, prejuTotal, acoesTotal, parcelaSocio, totalTemp);
                    //Console.ReadLine();
                    for (int j = 0; j < clientes.Count; j++)
                    {
                        saldoTotal += clientes[j].saldo;
                    }
                    for (int j = 0; j < socios.Count; j++)
                    {
                        saldoTotal += socios[j].saldo;
                        acoesTotal += socios[j].qtdAcoes;
                    }
                    for (int j = 0; j < fornecedores.Count; j++)
                    {
                        if (fornecedores[j].tipoDeProduto == 1)
                        {
                            prejuTotal += fornecedores[j].qtdFornecidaAoMes * 5.45;
                        }
                        else if (fornecedores[j].tipoDeProduto == 2)
                        {
                            prejuTotal += fornecedores[j].qtdFornecidaAoMes * 6.78;
                        }
                        else if (fornecedores[j].tipoDeProduto == 3)
                        {
                            prejuTotal += fornecedores[j].qtdFornecidaAoMes * 1.43;
                        }
                        else if (fornecedores[j].tipoDeProduto == 4)
                        {
                            prejuTotal += fornecedores[j].qtdFornecidaAoMes * 2.68;
                        }
                        else if (fornecedores[j].tipoDeProduto == 5)
                        {
                            prejuTotal += fornecedores[j].qtdFornecidaAoMes * 3.78;
                        }
                        else
                        {
                            prejuTotal += fornecedores[j].qtdFornecidaAoMes * 2.96;
                        }
                    }
                    for (int j = 0; j < funcionarios.Count; j++)
                    {
                        prejuTotal += funcionarios[j].saldo;
                    }
                    totalTemp = saldoTotal - prejuTotal;
                    //Console.WriteLine("{0} {1} {2} {3} {4} {5}", saldoTotal, prejuTotal, acoesTotal, parcelaSocio, totalTemp, fornecedores[0].qtdFornecidaAoMes);
                    //Console.ReadLine();
                    if (totalTemp > 0)
                    {
                        parcelaSocio = (acoesTotal / 100) * prejuTotal;
                        totalTemp = prejuTotal - (prejuTotal * (acoesTotal / 100));
                        caixa = totalTemp;
                    }
                    for (int j = 0; j < clientes.Count; j++)
                    {
                        clientes[j].saldo = 0;
                    }
                    for (int j = 0; j < socios.Count; j++)
                    {
                        socios[j].saldo = 0;
                    }
                    for (int j = 0; j < funcionarios.Count; j++)
                    {
                        funcionarios[j].saldo = 0;
                    }
                    for (int j = 0; j < fornecedores.Count; j++)
                    {
                        if (fornecedores[j].qtdFornecidaAoMes % 2 == 0)
                        {
                            fornecedores[j].qtdFornecidaAoMes = fornecedores[j].qtdFornecidaAoMes / 2;
                        }
                        else
                        {
                            fornecedores[j].qtdFornecidaAoMes += 1;
                            fornecedores[j].qtdFornecidaAoMes = fornecedores[j].qtdFornecidaAoMes / 2;
                        }
                    }
                    //Console.WriteLine("{0} {1} {2} {3} {4} {5}", saldoTotal, prejuTotal, acoesTotal, parcelaSocio, totalTemp, fornecedores[0].qtdFornecidaAoMes);
                    //Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Lucro Calculado Com Sucesso!!!");
                    Console.WriteLine("Voltando ao Menu!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                //--- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR --- SAIR ---
                else if (escolha == "7")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Impossível executar a instrução!");
                    Console.WriteLine("Voltando ao Menu!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }

            //Bagui mt loko!!!
            int cor1, cor2, cor3, cor4, cor5, cor6;
            cor1 = 0;
            cor2 = 1;
            cor3 = 2;
            cor4 = 3;
            cor5 = 4;
            cor6 = 5;
            for (int i = 0; i < 35; i++)
            {
                Console.WriteLine(Colorido(cor1));
                Console.WriteLine();
                cor1++;
                if (cor1 == 6)
                {
                    cor1 = 0;
                }
                Console.WriteLine(Colorido(cor2));
                Console.WriteLine();
                cor2++;
                if (cor2 == 6)
                {
                    cor2 = 0;
                }
                Console.WriteLine(Colorido(cor3));
                Console.WriteLine();
                cor3++;
                if (cor3 == 6)
                {
                    cor3 = 0;
                }
                Console.WriteLine(Colorido(cor4));
                Console.WriteLine();
                cor4++;
                if (cor4 == 6)
                {
                    cor4 = 0;
                }
                Console.WriteLine(Colorido(cor5));
                Console.WriteLine();
                cor5++;
                if (cor5 == 6)
                {
                    cor5 = 0;
                }
                Console.WriteLine(Colorido(cor6));
                Console.WriteLine();
                cor6++;
                if (cor6 == 6)
                {
                    cor6 = 0;
                }
                Thread.Sleep(50);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
