using System.Text;


var localDoArquivo = "Contas.txt"; // Caminho do arquivo


// Escreve o buffer na tela
void EscreverBuffer(byte[] buffer, int BytesLidos)
{
    var utf8 = new UTF8Encoding(); // Cria um objeto UTF8

    var texto = utf8.GetString(buffer, 0, BytesLidos); // Converte os bytes para string
    Console.Write(texto);
}


void FileClass()
{
    // Imprime a quantidade de linhas do arquivo
    var linhas = File.ReadAllLines(localDoArquivo);
    Console.WriteLine($"O arquivo tem {linhas.Length} linhas."); 

    // Imprime todas as linhas do arquivo
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }

    // Le os bytes do arquivo e imprime a quantidade de bytes
    var bytesLidos = File.ReadAllBytes(localDoArquivo);
    Console.WriteLine($"O arquivo tem {bytesLidos.Length} bytes.");

    // Escreve no arquivo o nome "Victor Martins de Sousa"
    File.WriteAllText("Nome.txt", "Victor Martins de Sousa");
}


void LidandoComFileStream()
{   
    // FileStream é uma classe que permite ler e escrever bytes em um arquivo
    using (var fluxoDoArquivo = new FileStream(localDoArquivo, FileMode.Open))
    {
        var numeroDeBytesLidos = -1;

        var buffer = new byte[1024]; // Cria um buffer de 1024 bytes

        // Enquanto o numero de bytes lidos for diferente de 0, continua lendo
        while(numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); // Lê 1024 bytes do arquivo
            EscreverBuffer(buffer, numeroDeBytesLidos);
        }

        fluxoDoArquivo.Close();
    }
}


FileClass();

/*
Output:

O arquivo tem 1000 linhas
375,4644,2483.13,Jonatan Silva
234,4020,2822.52,Debora
316,3254,3350.37,Leonardo
...
...
O arquivo tem 25166 bytes.
*/


LidandoComFileStream();

/*
Output (Nome.txt):

Victor Martins de Sousa
*/

