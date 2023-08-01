void TesteArrayInt() 
{
    int[] idades = new int[5];
    int acumulador = 0;

    idades[0] = 18;
    idades[1] = 95;
    idades[2] = 26;
    idades[3] = 30;
    idades[4] = 46;

    Console.WriteLine($"A quantidade de itens na array é {idades.Length}!");

    for (int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"Indice [{i}] = {idades[i]}");
        acumulador += idades[i];
    }

    int media = acumulador / idades.Length;

    Console.WriteLine($"A média das idade é {media}");
}

TesteArrayInt();

/*
Output:

A quantidade de itens na array é 5!
Indice [0] = 18
Indice [1] = 95
Indice [2] = 26
Indice [3] = 30
Indice [4] = 46
A média das idade é 43
*/