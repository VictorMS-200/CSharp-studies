void UsarStreamDeEntrada()
{
    using (var fluxoDeEntrada = Console.OpenStandardInput())

    // Cria um escritor de arquivo
    using (var fluxoDeArquivo = new FileStream("entradaConsole.txt", FileMode.Create))
    {
        // Cria um buffer de 1024 bytes
        var buffer = new byte[1024];

        while (true)
        {
            var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024); // Lê o buffer de 1024 bytes

            fluxoDeArquivo.Write(buffer, 0, byteslidos); // Escreve o buffer de 1024 bytes
            fluxoDeArquivo.Flush(); // Limpa o buffer
        }
    }
}

UsarStreamDeEntrada(); // Cria o arquivo entradaConsole.txt e escreve o que for digitado no console