using bancoSistema;

public class MainBanco {
    public static void Main(string[] args)
    {   

        Console.WriteLine(Banco.TaxaDeOperacao);
        Console.ReadLine();

        /*
        Output:

        0  

        */

        try
        {
            //Criação do objeto (Conta1)
            Banco Conta1 = new Banco(0, "1010-x"); // Atributo (numero_agencia) igual 0
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
            Console.WriteLine("Impossivel criar uma conta com o número de agência menor ou igual a zero.");
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine(ex.Message);

            /*
            Output:

            Parâmetro com erro: numero_agencia

            Impossivel criar uma conta com o número de agência menor ou igual a zero.
            
                at bancoSistema.Banco..ctor(Int32 numero_agencia, String numero_conta) in C:\Users\lusto\OneDrive\GitHub\Csharp_Studies\04. Exeções\01. Implementando Exeção\Sistema Banco\sistemaBanco.cs:line 99
                at MainBanco.Main(String[] args) in C:\Users\lusto\OneDrive\GitHub\Csharp_Studies\04. Exeções\01. Implementando Exeção\Program.cs:line 18
                
            Número de agência menor ou igual a zero! (Parameter 'numero_agencia')

            */
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}   