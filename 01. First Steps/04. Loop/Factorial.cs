namespace Csharp_Studies;

class Factorial 
{
    static void Main(string[] args) 
    {
        // Print the factorial of the numbers from 0 to 10
        for (int num = 0; num <= 10; num ++)
        {
            int Factorial = 1;

            Console.Write("Factorial of " + num + "! = ");

            for (int i = num; i>0; i--)
            {
                if (i == 1) // 1! = 1
                {
                    Console.Write(i);
                } 
                else if(i > 1) 
                {
                    Console.Write(i + " x ");
                }
                Factorial *= i;
            }
            if (num == 0)  // 0! = 1
            {
                Console.WriteLine(Factorial);
            } 
            else 
            {
                Console.WriteLine(" = "+Factorial);
            }
        }
    }
}

/*
Output:

Factorial of 0! = 1
Factorial of 1! = 1
Factorial of 2! = 2 = 2
...
Factorial of 10! = 10 x 9 x 8 x 7 x 6 x 5 x 4 x 3 x 2 x 1 = 3628800
*/