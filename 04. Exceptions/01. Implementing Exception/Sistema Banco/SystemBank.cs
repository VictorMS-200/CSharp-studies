using ClientClass;

namespace BankSystem;

public class Bank
{
    
    // Create attributes
    public string? Account { get; set; }
    public static int TotalAccountCreated { get; private set; }
    public static float OperationFee { get; private set; }


    public Client? Holder { get; set; } // Attribute of type Client


    // Create attribute with encapsulation
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

        if (agencyNumber <= 0) // If the number is less than or equal to zero
        {
            throw new ArgumentException("Number of agency must be greater than zero.", nameof(agencyNumber));
        }
        
        TotalAccountCreated++;
    }


    // Function to deposit a value
    public void Deposit(int value)
    {
        this.balance += value;
    }


    // Function to withdraw a value
    public bool Withdraw(int value)
    {
        if (value <= this.balance) 
        {
            this.balance -= value;
            return true;

        } 
        else 
        {
            // throw new Exception
            throw new InsufficientBalanceException($"Withdraw error! The value {value} is not available to withdraw with the amount available in your account.");
        }
    }


    // Function to transfer a value
    public bool transfer(int value, Bank account)
    {
        if (this.balance < value)
        {
            return false;

        } else {
            Withdraw(value);
            account.Deposit(value);
            return true;
        }
    }
}