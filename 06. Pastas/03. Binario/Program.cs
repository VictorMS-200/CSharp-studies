void EscritaBinaria()
{
    using (var fluxoDeArquivo = new FileStream("BinarioEscrever.csv", FileMode.Create))

    // Cria um escritor binario
    using (var escritor = new BinaryWriter(fluxoDeArquivo))
    {
        // Escreve o valor no arquivo BinarioEscrever.csv
        escritor.Write("Victor Martins");
        escritor.Write(515);
        escritor.Write(21543.21);
    }
}

void LerBinaria()
{
    using (var fluxoDeArquivo = new FileStream("BinarioEscrever.csv", FileMode.Open))

    // Cria um leitor binario
    using (var leitor = new BinaryReader(fluxoDeArquivo))
    {
        var titular = leitor.ReadString(); // Converte o valor para string
        var Numero = leitor.ReadInt32(); // Converte o valor para int
        var Saldo = leitor.ReadInt32(); // Converte o valor para double

        Console.WriteLine($"Titular: {titular}\nNumero da conta: {Numero}\nSaldo: {Saldo}");
    }
}

EscritaBinaria();

LerBinaria();

/*
Output:

Titular: Victor Martins
Numero da conta: 515
Saldo: 21543.21
*/