using ClientClass;

namespace BankSystem;

public class Bank
{
    
    // Create attributes
    public string? Account { get; set; }
    public static int TotalAccountCreated { get; private set; } // static member


    public Client? Holder { get; set; } // Attribute of type Client


    // Create attribute with encapsulation
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

    private double balance = 100;
    public double Balance
    {
        get { return this.balance; }
        set {  
                if (value < 0)
                {
                    return;
                } 
                else 
                {
                    balance = value;
                }
            }
    }


    // Constructor with parameters
    public Bank(int numero_agencia, string numero_conta) {
        this.numero_agencia = numero_agencia;
        this.Account = numero_conta;
        TotalAccountCreated++;
    }


    // Function to deposit a value
    public void Deposit(int valor)
    {
        this.balance += valor;
    }


    // Function to withdraw a value
    public bool Withdraw(int valor)
    {
        if (valor <= this.balance) 
        {
            this.balance -= valor;
            return true;

        } 
        else 
        {
            return false;
        }
    }


    // Function to transfer a value
    public bool transfer(int valor, Bank contaRecorente)
    {
        if (this.balance < valor)
        {
            return false;

        } else {
            Withdraw(valor);
            contaRecorente.Deposit(valor);
            return true;
        }
    }
}