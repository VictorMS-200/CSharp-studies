namespace BankSystem;

public class Bank
{
    // Create attributes
    public int Number { get; }
    public int Account { get; }
    public double Balance { get; private set; }


    public Client? Holder { get; set; } // Attribute of type Client


    // Constructor with parameters
    public Bank(int account, int num)
    {
        Account = account;
        Number = num;
    }


    // Function to deposit a value
    public void Deposit(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("The value must be greater than zero.", nameof(value));
        }

        Balance += value;
    }


    // Function to withdraw a value
    public void Withdraw(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("The value must be greater than zero.", nameof(value));
        }

        if (value > Balance)
        {
            throw new InvalidOperationException("withdrawal amount greater than the balance.");
        }

        Balance += value;
    }
}