using Itens;

namespace FastFood
{
    public class SistemaFastFood
    {
        // Criação de atributos
        public string? cliente;
        public double valorTotal;
        public string? endereço;
        public ItensFastFood? itens { get; set; } // Atributo da classe ItensFastFood

    }
}