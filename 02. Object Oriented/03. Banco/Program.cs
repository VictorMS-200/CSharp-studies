using BankSystem;
using ClientClass;



// Create object (VictorAccount)
Bank VictorAccount = new Bank(40, "1010-x");

// Assigning values to attributes
VictorAccount.Holder = new Client();
VictorAccount.Holder.Name = "Victor";
VictorAccount.Holder.Cpf = 123456789;
VictorAccount.Holder.Job = "Dev";
VictorAccount.Balance = 100;


// Create object (PaulAccount)
Bank PaulAccount = new Bank(12, "1012-5");

// Assigning values to attributes
PaulAccount.Holder = new Client();
PaulAccount.Holder.Name = "Paul";
PaulAccount.Holder.Cpf = 987654321;
PaulAccount.Holder.Job = "Dev";
PaulAccount.Balance = 300;


// Print values
Console.WriteLine("How many accounts were created: {0}", Bank.TotalAccountCreated);

/*
Output:

How many accounts were created: 2
*/

Console.WriteLine("Balance of Victor's account: {0}", VictorAccount.Balance);
Console.WriteLine("Balance of Paul's account: {0}", PaulAccount.Balance);

/*
Output:

Balance of Victor's account: 100
Balance of Paul's account: 300
*/

// Transfer 50 from Paul to Victor
PaulAccount.transfer(50, VictorAccount);

Console.WriteLine("Paul transferred 50 to Victor's account");
Console.WriteLine("Balance of Victor's account: {0}", VictorAccount.Balance);
Console.WriteLine("Balance of Paul's account: {0}", PaulAccount.Balance);

/*
Output:

Paul transferred 50 to Victor's account
Balance of Victor's account: 150
Balance of Paul's account: 250
*/

VictorAccount.Deposit(20);
PaulAccount.Withdraw(60);

Console.WriteLine("Victor deposited 20 and Maria withdrew 60");
Console.WriteLine("Balance of Victor's account: {0}", VictorAccount.Balance);
Console.WriteLine("Balance of Paul's account: {0}", PaulAccount.Balance);

/*
Output:

Victor deposited 20 and Maria withdrew 60
Balance of Victor's account: 170
Balance of Paul's account: 190
*/


