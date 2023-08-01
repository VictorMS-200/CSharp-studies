using ClientClass;

namespace BankSystem;

public class Bank
{
    
    // Create properties
    public string? Account { get; set; }
    public static int TotalAccountCreated { get; private set; } // static member


    public Client? Holder { get; set; } // Properties of type Client


    // Create properties with encapsulation
    private int numberAccount;
    public int NumberAccount
    {
        get { return this.numberAccount; }

        private set {
                if (value > 0)
                {
                    this.numberAccount = value;
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
    public Bank(int agencyNumber, string numberAccount) {
        this.numberAccount = agencyNumber;
        this.Account = numberAccount;
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