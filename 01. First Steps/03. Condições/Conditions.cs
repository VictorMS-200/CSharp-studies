// Conditional structures

namespace Csharp_Studies;

class Conditions
{
    static void Main(string[] args) {
        
        int age = 17;
        bool accompanied = false;
        string textAccompanied;

        if (accompanied) {
            textAccompanied = "You are accompanied.";
        }
        else 
        {
            textAccompanied = "You are not accompanied.";
        }

        if (age >= 18 || accompanied) 
        {
            Console.WriteLine(textAccompanied);
            Console.WriteLine("You can enter!");
        }
        else 
        {
            Console.WriteLine(textAccompanied);
            Console.WriteLine("You can't enter!");
        }

    }
}

/*
Output:

You are not accompanied.
You can't enter!
*/
