namespace Exemplo04.BancoByteBank
{
    public class Cliente
    {
        private string? _nome;

        // Criação de get e set de Nome, Cpf e Profissão
        public string Nome
        {
        get
        {
            return _nome!;
        }
        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracteres.");
            }
                _nome = value;
        }
}
        public string? Cpf { get; set; }
        public string? Profissão { get; set; }

        public Cliente() 
        { 
               
        }
    }
}