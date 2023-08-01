using System;
using FastFood;
using Itens;

public class MainFastFood
{
    public static void Main(string[] args)
    {
        // Criação do objeto (cliente01)
        SistemaFastFood cliente01 = new SistemaFastFood();

        // Atribuindo valores aos atributos
        cliente01.cliente = "Victor";
        cliente01.endereço = "Avenida São Paulo 123";
        cliente01.valorTotal = 20.3;
        cliente01.itens = new ItensFastFood();
        cliente01.itens.iten01 = "Hamburguer";
        cliente01.itens.iten02 = "Batata";
        cliente01.itens.iten03 = "Refri";

        Console.WriteLine("O Cliente {0}, mora na {1} tem os seguintes itens: \n{2}\n{3}\n{4}\nValor total: {5}", cliente01.cliente, cliente01.endereço, cliente01.itens.iten01, cliente01.itens.iten02, cliente01.itens.iten03, cliente01.valorTotal);

        /*
        Output:

        "O Cliente Victor, mora na Avenida São Paulo 123 tem os seguintes itens: 
        Hamburger
        Batata
        Refri
        Valor total: 20,3"
        
        */
    }
}