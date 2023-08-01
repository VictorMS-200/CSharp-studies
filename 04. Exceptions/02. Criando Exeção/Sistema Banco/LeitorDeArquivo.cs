namespace ClassLeitorDeArquivo
{
    public class LeitorDeArquivo
    {

        // Criação de atributos
        public string Arquivo { get; }


        // Criação do contrutor (arquivo)
        public LeitorDeArquivo(string arquivo)
        {
            this.Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        // Método de "ler proxima linha"
        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");
            return ("Linha do arquivo");
            throw new IOException(); // Lança a exeção (IOException)
        }

        // Método de "fechar arquivo"
        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}