using classAutenticavel;
using Funcionarios;

namespace ClassFuncionariosAutenticavel
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel // Herdando da classe Funcionario e da interface IAutenticavel
    {

        // Criação do contrutor (cpf e salario)
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario) // Passa o parametro para o cpf e salario da classe Funcionario
        {

        }


        // Criação de atributo
        public string? Senha { get; set; }


        // Método de autenticar senha
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}