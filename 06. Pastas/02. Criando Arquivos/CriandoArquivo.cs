using System.Text;


// Criar arquivo com bytes
void CriarArquivo()
{
    // Cria o arquivo contasExportadas.csv
    using (var fluxoDeArquivo = new FileStream("contasExportadas.csv", FileMode.Create))
    {
        var contaComoString = "115, 7842, 4725.12, Victor Martins";
        var enconding = Encoding.UTF8;
        var bytes = enconding.GetBytes(contaComoString);

        fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        
    }
}


// Criar arquivo com StreamWriter
void CriarArquivoComWriter()
{
    // Cria o arquivo contasExportadas.csv
    using (FileStream fluxoDeArquivo = new FileStream("contasExportadas.csv", FileMode.Create))

    // Cria o escritor
    using (StreamWriter escritor = new StreamWriter(fluxoDeArquivo))
    {
        escritor.Write("154,5438,65.1,Luiz Souza"); // Escreve no arquivo
    }
}


// Criar arquivo com StreamWriter
void TestaEscrita()
{
    // Cria o arquivo teste.txt
    using (FileStream fluxoDeArquivo = new FileStream("teste.txt", FileMode.Create))

    // Cria o escritor
    using (StreamWriter escritor = new StreamWriter(fluxoDeArquivo))
    {
        // Escreve varias linhas no arquivo
        for (int i = 0; i < 100; i++)
        {
            escritor.WriteLine($"linha {i}");
            escritor.Flush();
            
            // Mostra que a linha foi escrita
            Console.WriteLine($"linha {i} foi escrita no arquivo. Tecle enter...");
            Console.ReadLine();
        }
    }
}

CriarArquivo();
/*
Output (contasExportadas.csv):

115, 7842, 4725.12, Victor Martins
*/


CriarArquivoComWriter();
/*
Output (contasExportadas.csv):

154,5438,65.1,Luiz Souza
*/


TestaEscrita();

/*
Output:

linha 0 foi escrita no arquivo. Tecle enter...
linha 1 foi escrita no arquivo. Tecle enter...
linha 2 foi escrita no arquivo. Tecle enter...
...
*/

