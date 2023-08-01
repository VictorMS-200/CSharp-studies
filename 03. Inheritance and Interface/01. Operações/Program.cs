using ClassOperacoes;
using System;

public class Program
{
    private static void Main(string[] args)
    {
        // Criação do objeto (op)
        Operacoes op = new Operacoes();

        Console.WriteLine($"O valor de 50 + 20 = {op.soma.Calcular(50, 20)}");
        Console.WriteLine($"O valor de 61 - 11 = {op.subtracao.Calcular(61, 11)}");
        Console.WriteLine($"O valor de 16 * 8 = {op.multiplicacao.Calcular(16, 8)}");
        Console.WriteLine($"O valor de 95 / 5 = {op.divisao.Calcular(95, 5)}");

        /*
        Output:

        O valor de 50 + 20 = 70
        O valor de 61 - 11 = 50
        O valor de 16 * 8 = 128
        O valor de 95 / 5 = 19
        
        */
    }
}