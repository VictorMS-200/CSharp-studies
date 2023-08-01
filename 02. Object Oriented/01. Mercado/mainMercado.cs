using System;
using Mercado;


namespace mainMercado 
{
    public class Mercado
    {
        static void Main(string[] args)
        {
            // Criação do objeto (ProdutoFini)
            sistemaMercado ProdutoFini = new sistemaMercado();

            // Atribuindo valores aos atributos
            ProdutoFini.nome = "Fini";
            ProdutoFini.fabricante = "Fini Company";
            ProdutoFini.quantidadeEmEstoque = 16;
            ProdutoFini.valorDeCompra = 6;
            ProdutoFini.valorUnitario = 6;
            ProdutoFini.codigoDeBarras = 9451218651385;

            Console.WriteLine("O produto {0} custa {1} reais", ProdutoFini.nome, ProdutoFini.valorDeCompra);

            /*
            Output:

            "O produto Fini custa 6 reais"
            
            */
        }
    }
}