using System;
using TItular;

namespace bancoSistema
{
    public class Banco
    {
        
        // Criação do atributo Conta
        public string? Conta { get; set; }
        public static int TotalDeContasCriadas { get; private set; } // Membro estático 


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
            else 
            {
                return false;
            }
        }


        // Função de Transferir valor para outra conta
        public bool Transferir(int valor, Banco contaRecorente)
        {
            if (this.saldo < valor)
            {
                return false;

            } else {
                Sacar(valor);
                contaRecorente.Depositar(valor);
                return true;
            }
        }


        // Membro construtor da classe (numero_agencia e numero_conta)
        public Banco(int numero_agencia, string numero_conta) {
            this.numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }
    }
}