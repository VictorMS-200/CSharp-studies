namespace ClassAutenticar
{
    public class ParceiroComercial
    {

        // Criação de atributo
        public string? Senha { get; set; }

        // Método de autenticar senha
        public bool Autenticar(string senha) // Retorna True se corresponder com a senha correta
        {
            return this.Senha == senha;
        }
    }
}