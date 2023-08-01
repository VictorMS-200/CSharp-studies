using System.Text;


var rootFile = "Contas.txt"; // Contas.txt is in the root folder of the project (06. Files\01. File to class)


// Escreve o buffer na tela
void WriteBuffer(byte[] buffer, int BytesRead)
{
    var utf8 = new UTF8Encoding(); // Cria um objeto UTF8

    var text = utf8.GetString(buffer, 0, BytesRead); // Converte os bytes para string
    Console.Write(text);
}


void FileClass()
{
    // Imprime a quantidade de linhas do arquivo
    var lines = File.ReadAllLines(rootFile);
    Console.WriteLine($"O arquivo tem {lines.Length} linhas."); 

    // Imprime todas as linhas do arquivo
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }

    // Le os bytes do arquivo e imprime a quantidade de bytes
    var bytesRead = File.ReadAllBytes(rootFile);
    Console.WriteLine($"O arquivo tem {bytesRead.Length} bytes.");

    // Escreve no arquivo o nome "Victor Martins de Sousa"
    File.WriteAllText("Nome.txt", "Victor Martins de Sousa");
}


void LidandoComFileStream()
{   
    // FileStream é uma classe que permite ler e escrever bytes em um arquivo
    using (var fileStream = new FileStream(rootFile, FileMode.Open))
    {
        var NumbersOfBytsRead = -1;

        var buffer = new byte[1024]; // Cria um buffer de 1024 bytes

        // Enquanto o numero de bytes lidos for diferente de 0, continua lendo
        while(NumbersOfBytsRead != 0)
        {
            NumbersOfBytsRead = fileStream.Read(buffer, 0, 1024); // Lê 1024 bytes do arquivo
            WriteBuffer(buffer, NumbersOfBytsRead);
        }

        fileStream.Close();
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

