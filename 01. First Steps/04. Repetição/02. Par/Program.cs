internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digitar numero A:");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digitar numero B:");
        int B = Convert.ToInt32(Console.ReadLine());

        int minV = 0;
        int maxV = 0;
        int valorTotal = 0;

        if (A < B)
        {
            minV = A + 1;
            maxV = B;
        }
        else
        {
            minV = B;
            maxV = A + 1;
        }

        while (minV < maxV)
        {
            if (minV % 2 == 0)
            {
                valorTotal += minV;
            }
            minV++;
        }

        Console.WriteLine(valorTotal + A + B);
    }
}