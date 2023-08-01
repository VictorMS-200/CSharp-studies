using bancoSistema;

namespace interfaceSistema
{
    public class interfaceSistemaBanco
    {
        // Criação de uma lista do tipo ContaCorrente e criação de contas padrões.
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>() 
        {
            new ContaCorrente(21,"1213232") {Saldo=100},
            new ContaCorrente(49,"1455422") {Saldo=230},
            new ContaCorrente(52,"1286541") {Saldo=150},
        };

        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("===       Atendimento       ===");
                    Console.WriteLine("===1 - Cadastrar Conta      ===");
                    Console.WriteLine("===2 - Listar Contas        ===");
                    Console.WriteLine("===3 - Remover Conta        ===");
                    Console.WriteLine("===4 - Ordenar Contas       ===");
                    Console.WriteLine("===5 - Pesquisar Conta      ===");
                    Console.WriteLine("===6 - Sair do Sistema      ===");
                    Console.WriteLine("===============================");
                    Console.WriteLine("\n\n");
                    Console.Write("Digite a opção desejada: ");

                    try
                    {
                        opcao = Console.ReadLine()![0];
                    }
                    catch (Exception execao)
                    {
                        
                        throw new BancoException(execao.Message);
                    }

                    switch (opcao)
                    {
                        case '1': CadastrarConta();
                            break;

                        case '2': ListarContas();
                            break;

                        case '3': RemoverContas();
                            break;

                        case '4': OrdenarContas();
                            break;

                        case '5': PesquisarContas();
                            break;

                        case '6':                    
                            EncerrarAplicacao();
                            break;

                        default:
                            Console.WriteLine("Opcao não implementada.");
                            break;
                    }
                }
            }
            catch (BancoException execao)
            {
                Console.WriteLine(execao.Message);
            }
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();
        }


        ContaCorrente ConsultaPorCPFTitular(string? cpf)
        {
            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault()!;
        }

        ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
        {
            return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault()!;
        }

        private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            var consulta = (
            from ContaCorrente in _listaDeContas
            where ContaCorrente.Numero_agencia == numeroAgencia
            select ContaCorrente).ToList();
            return consulta;

        }


        private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine(" ... A consulta não retornou dados ...");
            }
            else
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===    PESQUISAR CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Deseja pesquisar por (1) NÚMERO DA CONTA ou (2)CPF TITULAR ou (3) Nº AGÊNCIA: ");

            switch (int.Parse(Console.ReadLine()!))
            {
                
                //
                case 1:
                {
                    Console.Write("Informe o número da Conta: ");
                    string _numeroConta = Console.ReadLine()!;
                    ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);

                    Console.WriteLine(consultaConta.ToString());
                    Console.ReadKey();
                    break;
                }

                //
                case 2:
                {
                    Console.Write("Informe o CPF do Titular: ");
                    string _cpf = Console.ReadLine()!;
                    ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);

                    Console.WriteLine(consultaCpf.ToString());
                    Console.ReadKey();
                    break;
                }

                //
                case 3:
                {
                    Console.Write("Informe o Nº da Agência: ");
                    int _numeroAgencia = int.Parse(Console.ReadLine()!);
                    var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);

                    ExibirListaDeContas(contasPorAgencia);
                    Console.ReadKey();
                    break;
                }

                default:
                    Console.WriteLine("Opção não implementada.");
                    break;
            }
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("... Lista de Contas ordenadas ...");
            Console.ReadKey();
        }

        private void RemoverContas()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===      REMOVER CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Informe o número da Conta: ");


            string numeroConta = Console.ReadLine()!;
            ContaCorrente conta = null!;

            foreach (var item in _listaDeContas)
            {
                if (item.Conta!.Equals(numeroConta))
                {
                    conta = item;
                }
            }
            if (conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine("... Conta removida da lista! ...");
            }
            else
            {
                Console.WriteLine(" ... Conta para remoção não encontrada ...");
            }
            Console.ReadKey();
        }

        private void ListarContas()
        {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("=====   Lista de Contas   =====");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");


        if (_listaDeContas.Count <= 0)
        {
            Console.WriteLine("... Não há contas cadastradas! ...");
            Console.ReadKey();
            return;
        }

        foreach (ContaCorrente item in _listaDeContas)
        {
            Console.WriteLine(item.ToString());
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.ReadKey();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===   CADASTRO DE CONTAS    ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.WriteLine("=== Informe dados da conta ===");


            Console.Write("Número da Agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine()!);


            ContaCorrente conta = new ContaCorrente(numeroAgencia);
            Console.WriteLine($"Número da conta [NOVA] : {conta.Conta}");


            Console.Write("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine()!);

            Console.Write("Infome nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine()!;

            Console.Write("Infome CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Infome Profissão do Titular: ");
            conta.Titular.Profissão = Console.ReadLine();

            _listaDeContas.Add(conta);
            
            Console.WriteLine("... Conta cadastrada com sucesso! ...");
            Console.ReadKey();
        }

    }
}