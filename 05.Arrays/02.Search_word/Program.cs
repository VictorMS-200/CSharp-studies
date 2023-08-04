void SearchWord()
{
    // Declare an array of strings
    string[] wordArray = new string[5];

    // Assign values to the array
    for (int i = 0; i < wordArray.Length; i++)
    {
        Console.Write($"Write word {i+1}:");
        wordArray[i] = Console.ReadLine()!;
    }

    Console.Write($"Write a word to search:");
    var search = Console.ReadLine();

    // Search for the word in the array
    foreach (var word in wordArray)
    {
        if (search == word)
        {
            Console.WriteLine($"Word searched: {search}");
            break;
        }
    }
}

SearchWord();
/*
Output: 

Write word 1: Hello
Write word 2: World
Write word 3: !
Write word 4: Good
Write word 5: Morning
Write a word to search: !
Word searched: !
*/