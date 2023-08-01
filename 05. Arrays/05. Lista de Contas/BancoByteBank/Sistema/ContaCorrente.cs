using Exemplo04.BancoByteBank;

namespace bancoSistema
{
    public class ContaCorrente : IComparable<ContaCorrente>
    {

        public static float TaxaDeOperacao { get; private set; }
        
        // Criando um get e set para Conta e TotalDeContasCriadas (propriedade)
        public string? Conta { get; set; }
        public static int TotalDeContasCriadas { get; private set; }


        public Cliente Titular { get; set; }


        // Criando um get e set para numero_agencia (propriedade implementadas)
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }

            private set {
                if (value > 0)
                    this.numero_agencia = value;
            }
        }


        // Criando um get e set para saldo (propriedade implementadas)
        private double saldo = 100;
        public double Saldo
        {
            get { return this.saldo; }
            set {  
                    if (value < 0) 
                        return;
                    else 
                        saldo = value;
                }
        }


        // Função de Depositar um valor na conta
        public void Depositar(int valor)
        {
            this.saldo += valor;
        }


        // Função de Sacar um valor, exeto valores acima do contido na conta
        public bool Sacar(int valor)
        {
            if (valor <= this.saldo) 
            {
                this.saldo -= valor;
                return true;

            } 
            else 
                throw new SaldoInsuficienteException($"Saldo indisponível! O Valor {valor} não está disponivel para sacar com a quantidade disponivel na sua conta.");
        }


        // Função de Transferir valor para outra conta
        public bool Transferir(int valor, ContaCorrente contaRecorente)
        {
            if (this.saldo < valor) 
                return false;
            else 
            {
                Sacar(valor);
                contaRecorente.Depositar(valor);
                return true;
            }
        }


        public int CompareTo(ContaCorrente? outro)
        {
            if (outro == null) 
                return 1;
            else 
                return this.Numero_agencia.CompareTo(outro.Numero_agencia);
        }


        // Membro estático da classe, requerendo determinar o 
        // numero da conta e da agencia na criação de uma conta
        public ContaCorrente(int numero_agencia, string numero_conta) {
            this.numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            Titular = new Cliente();

            if (numero_agencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(numero_agencia));
            }

            TotalDeContasCriadas++;
        }

        public ContaCorrente(int numero_agencia)
        {
            Numero_agencia = numero_agencia;
            Conta = Guid.NewGuid().ToString().Substring(0, 8);
            Titular = new Cliente();
            TotalDeContasCriadas += 1;
        }

        public override string ToString()
        {

        return  $" === DADOS DA CONTA === \n" +
                    $"Número da Conta : {this.Conta} \n" +
                    $"Número da Agência : {this.Numero_agencia} \n" +
                    $"Saldo da Conta: {this.Saldo} \n" +
                    $"Titular da Conta: {this.Titular.Nome} \n" +
                    $"CPF do Titular  : {this.Titular.Cpf} \n" +
                    $"Profissão do Titular: { this.Titular.Profissão}\n\n";
        }
    } 
}