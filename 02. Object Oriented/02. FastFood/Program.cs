
using FastFood;
using Itens;

// Creating a object of SystemFastFood class
SystemFastFood Client = new SystemFastFood();


// Seting the values of the object
Client.client = "Victor";
Client.address = "Avenida São Paulo 123";
Client.totalValue = 20.3;
Client.itens = new ItensFastFood();
Client.itens.iten01 = "Burguer";
Client.itens.iten02 = "Fries";
Client.itens.iten03 = "Soda";

Console.WriteLine("The client {0}, lives in {1} and has the following itens: \n{2} \n{3} \n{4} \nTotal value: {5}", Client.client, Client.address, Client.itens.iten01, Client.itens.iten02, Client.itens.iten03, Client.totalValue);

/*
Output:

The client Victor, lives in Avenida São Paulo 123 and has the following itens:
Burguer
Fries
Soda

*/
