using System;

namespace Csharp_Studies
{
    class Fatorial 
    {
        static void Main(string[] args) 
        {
            for (int num = 0; num <= 10; num ++)
            {
                int fatorial = 1;
                Console.Write("Fatorial de " + num + "! = ");

                for (int i = num; i>0; i--)
                {
                    if (i == 1) {
                        Console.Write(i);
                    } else if(i > 1) {
                        Console.Write(i + " x ");
                    }
                    fatorial *= i;
                }
                if (num == 0)
                {
                    Console.WriteLine(fatorial);
                } else {
                    Console.WriteLine(" = "+fatorial);
                }
            }
        }
    }
}