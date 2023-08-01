using System;
using TItular;

namespace bancoSistema
{
    public class Banco
    {
        
        // Criando um get e set para Conta e TotalDeContasCriadas (propriedade)
        public string? Conta { get; set; }
        public static int TotalDeContasCriadas { get; private set; } // Membro estático 
        public static float TaxaDeOperacao { get; private set; } // Membro estático 


        public Cliente? Titular { get; set; } // Atributo da classe Cliente


        // Criação do atributo numero_agencia com encapsulamento
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }

            private set {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }


       // Criação do atributo saldo com encapsulamento
        private double saldo = 100;
        public double Saldo
        {
            get { return this.saldo; }
            set {  
                    if (value < 0)
                    {
                        return;
                    } 
                    else 
                    {
                        saldo = value;
                    }
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
            else // Valor do saque for maior do que há na conta
            {
                throw new SaldoInsuficienteException($"Saldo indisponível! O Valor {valor} não está disponivel para sacar com a quantidade disponivel na sua conta."); // Lança a exeção (SaldoInsuficienteException)
            }
        }


        // Função de Transferir valor para outra conta
        public bool Transferir(int valor, Banco contaRecorente)
        {
            if (this.saldo < valor)
            {
                return false;

            } 
            else 
            {
                Sacar(valor);
                contaRecorente.Depositar(valor);
                return true;
            }
        }


        // Membro estático da classe, requerendo determinar o 
        // numero da conta e da agencia na criação de uma conta
        public Banco(int numero_agencia, string numero_conta) {
            this.numero_agencia = numero_agencia;
            this.Conta = numero_conta;

            if (numero_agencia <= 0) // Atributo (numero_agencia) não pode ser menor ou igual a zero
            {
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(numero_agencia)); // Lança a exeção (ArgumentException)
            }
            
            TotalDeContasCriadas++;
        }
    }
}