using MarketSystem;

// Criação do objeto (ProdutoFini)
Market FiniProduct = new Market();

// Atribuindo valores aos atributos
FiniProduct.Name = "Fini";
FiniProduct.Manufacturer = "Fini Company";
FiniProduct.StockQuantity = 16;
FiniProduct.UnitValue = 6;
FiniProduct.PurchaseValue = 6;
FiniProduct.Barcode = 9451218651385;


Console.WriteLine("The product {0} costs {1}", FiniProduct.Name, FiniProduct.UnitValue);

/*
Output:

The product Fini costs 6

*/
