namespace Funcionarios
{

    public abstract class Funcionario // Classe abstrata
    {

        // Criação de atributos
        public string? Nome { get; set; }
        public string? Cpf { get; private set; }
        public double Salario { get; protected set; }
        public string? Senha { get; set; }
        public static int TotalDeFuncionarios { get; private set; } // Método static


        // Criação do contrutor (cpf e salario)
        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;           
        }
        

        // Criação de método abstrato (classes herdadas: Auxiliar, Designer, Diretor, GerenteDeContas)
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();


        // Método de autenticar senha
        public bool Autenticar(string senha) // Retorna True se corresponder com a senha correta
        {
            return this.Senha == senha;
        }
    }
}