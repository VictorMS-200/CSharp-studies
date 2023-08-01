using Funcionarios;

namespace classAutenticavel
{
    public interface IAutenticavel // Interface (classes herdadas: ParceiroComercial, FuncionarioAutenticavel)
    {

        // Criação de atributo    
        public string? Senha { get; set; }

        // Método de autenticar senha
        public abstract bool Autenticar(string senha); // Método (classes herdadas: ParceiroComercial, FuncionarioAutenticavel)
    }
}