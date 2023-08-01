void BuscarPalavra() {

    string[] arrayPalavras = new string[5];

    for (int i = 0; i < arrayPalavras.Length; i++)
    {
        Console.Write($"Digite {i+1}ª Palavra: ");
        arrayPalavras[i] = Console.ReadLine()!;
    }

    Console.Write($"Digite palavra a ser encontrada: ");
    
    var busca = Console.ReadLine();

    foreach (var Palavra in arrayPalavras)
    {
        if (busca == Palavra)
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }
}

BuscarPalavra();