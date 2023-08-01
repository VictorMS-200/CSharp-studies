using ByteBankIO;


// Converte separa uma string e transforma em uma conta corrente
ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // Separando os dados da linha
    var campos = linha.Split(',');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2].Replace('.', ',');
    var nometitular = campos[3];

    // Convertendo os dados para os tipos corretos
    var agenciaComInt = int.Parse(agencia);
    var numeroComInt = int.Parse(numero);
    var saldoComDouble = double.Parse(saldo);

    // Criando o titular
    var titular = new Cliente();
    titular.Nome = nometitular;

    // Criando a conta corrente
    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    // Retornando a conta corrente
    return resultado;
}


using (var fluxoDeArquivo = new FileStream("contas.txt", FileMode.Open))
{
    // Criando um leitor de arquivos
    var leitor = new StreamReader(fluxoDeArquivo);

    // Lendo o arquivo até o final
    while(!leitor.EndOfStream)
    {
        // Lendo uma linha do arquivo
        var linha = leitor.ReadLine();
        var contaCorrente = ConverterStringParaContaCorrente(linha!);

        // Escrevendo no console o resultado
        Console.WriteLine($"{contaCorrente.Titular!.Nome} : Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, saldo {contaCorrente.Saldo}");
    }   
}
Console.ReadLine();

/*
Output:

Guilherme Silva : Conta número 123, ag 456, saldo 100
Márcia Silva : Conta número 789, ag 654, saldo 100
Rafael Silva : Conta número 1011, ag 123, saldo 100
...
*/