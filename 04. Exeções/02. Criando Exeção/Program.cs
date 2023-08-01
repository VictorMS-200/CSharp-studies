using System;
using TItular;
using bancoSistema;
using ClassLeitorDeArquivo;


public class MainBanco {
    public static void Main(string[] args)
    {   

        //Criação do objeto (reader)
        LeitorDeArquivo reader = new LeitorDeArquivo("contas.txt");

        try {
            reader.LerProximaLinha();
            reader.LerProximaLinha();
            reader.LerProximaLinha();
        }
        catch(IOException)
        {
            Console.WriteLine("Leitura interrompida");
        }
        finally
        {
            reader.Fechar();
        }

        /*
        Output:

        Abrindo arquivo: contas.txt
        Lendo linha. . .
        Lendo linha. . .
        Lendo linha. . .
        Fechando arquivo.
        
        */
    }
}