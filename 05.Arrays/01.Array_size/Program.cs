// Some code was omitted for the example
void TestArrayInt() 
{
    // Declare an array of integers
    int[] age = new int[5];

    // Declare a variable to store the sum of the array
    int accumulator = 0;

    // Assign values to the array
    age[0] = 18;
    age[1] = 95;
    age[2] = 26;
    age[3] = 30;
    age[4] = 46;

    Console.WriteLine($"The number of items in the array is {age.Length}!");

    // Print the values of the array
    for (int i = 0; i < age.Length; i++)
    {
        Console.WriteLine($"Index [{i}] = {age[i]}");
        accumulator += age[i];
    }

    // Calculate the average of the array
    int average = accumulator / age.Length;

    Console.WriteLine($"The average of the ages is {average}");
}

TestArrayInt();

/*
Output:

The number of items in the array is 5!
Index [0] = 18
Index [1] = 95
Index [2] = 26
Index [3] = 30
Index [4] = 46
The average of the ages is 43
*/