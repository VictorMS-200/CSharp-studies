using BankSystem;


Console.WriteLine(Bank.OperationFee);
Console.ReadLine();

/*
Output:

0

*/

try
{
    // Create a new object 
    Bank Account01 = new Bank(0, "1010-x"); // Number Account is less than 0
}
catch (ArgumentException ex)
{
    Console.WriteLine("Parameter with error: " + ex.ParamName);
    Console.WriteLine("Impossible to create an account with the number of agency less than or equal to zero.");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);

    /*
    Output:

    Parameter with error: numero_agencia

    Impossible to create an account with the number of agency less than or equal to zero.

        (Show stack trace)
        at bancoSistema.Banco..ctor(Int32 numero_agencia, String numero_conta) in C:\Users\lusto\OneDrive\GitHub\Csharp_Studies\04. Exeções\01. Implementando Exeção\Sistema Banco\sistemaBanco.cs:line 99
        at MainBanco.Main(String[] args) in C:\Users\lusto\OneDrive\GitHub\Csharp_Studies\04. Exeções\01. Implementando Exeção\Program.cs:line 18
        
    Number of agency must be greater than zero. (Parameter 'numero_agencia')
    */
}
catch (InsufficientBalanceException ex)
{
    Console.WriteLine(ex.Message);
}
