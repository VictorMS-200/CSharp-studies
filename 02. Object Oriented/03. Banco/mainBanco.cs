using System;
using TItular;
using bancoSistema;


public class MainBanco {
    public static void Main(string[] args)
    {   

        //Criação do objeto (ContaDoVictor)
        Banco ContaDoVictor = new Banco(40, "1010-x");

        // Atribuindo valores aos atributos
        ContaDoVictor.Titular = new Cliente();
        ContaDoVictor.Titular.Nome = "Victor";
        ContaDoVictor.Titular.Cpf = 123456789;
        ContaDoVictor.Titular.Profissão = "Dev";
        ContaDoVictor.Saldo = 100;


        // Criação do objeto (ContaDaMaria)
        Banco ContaDaMaria = new Banco(12, "1012-5");
        
        // Atribuindo valores aos atributos
        ContaDaMaria.Titular = new Cliente();
        ContaDaMaria.Titular.Nome = "Maria";
        ContaDaMaria.Titular.Cpf = 987654321;
        ContaDaMaria.Titular.Profissão = "Analista";
        ContaDaMaria.Saldo = 300;


        // Mostra quantos objetos foram criados com a classe Banco
        Console.WriteLine("Total de conta: {0}", Banco.TotalDeContasCriadas);
        
        /*
        Output:

        Total de conta: 2

        */

        Console.WriteLine("Setando saldo das contas do Victor e da Maria");
        Console.WriteLine("Saldo da conta {0}: {1}", ContaDoVictor.Titular.Nome, ContaDoVictor.Saldo);
        Console.WriteLine("Saldo da conta {0}: {1}", ContaDaMaria.Titular.Nome, ContaDaMaria.Saldo);
        
        /*
        Output:

        Setando saldo das contas do Victor e da Maria
        Saldo da conta Victor: 100
        Saldo da conta Maria: 300

        */

        // Trasfere 100 reais da conta da Maria para a conta do Victor
        ContaDaMaria.Transferir(50, ContaDoVictor);

        Console.WriteLine("Maria Transferiu 50 para conta do Victor");
        Console.WriteLine("Saldo da conta {0}: {1}", ContaDoVictor.Titular.Nome, ContaDoVictor.Saldo);
        Console.WriteLine("Saldo da conta {0}: {1}", ContaDaMaria.Titular.Nome, ContaDaMaria.Saldo);
        
        /*
        Output:

        Maria Transferiu 50 para conta do Victor
        Saldo da conta Victor: 150
        Saldo da conta Maria: 250

        */

        ContaDoVictor.Depositar(20);
        ContaDaMaria.Sacar(60);

        Console.WriteLine("Victor depositou 20 e Maria sacou 60");
        Console.WriteLine("Saldo da conta {0}: {1}", ContaDoVictor.Titular.Nome, ContaDoVictor.Saldo);
        Console.WriteLine("Saldo da conta {0}: {1}", ContaDaMaria.Titular.Nome, ContaDaMaria.Saldo);

        /*
        Output:

        Victor depositou 20 e Maria sacou 60
        Saldo da conta Victor: 150
        Saldo da conta Maria: 250
        
        */

    }
}