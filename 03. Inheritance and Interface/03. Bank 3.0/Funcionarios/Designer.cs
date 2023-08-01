using Funcionarios;

namespace ClassDesigner
{
    public class Designer : Funcionario // Herdando da classe Funcionario
    {

        // Membro construtor da classe (cpf)
        public Designer(string cpf) : base(cpf, 3000) // Passa o parametro para o cpf da classe Funcionario
        {

        }

        // Método override de Funcionario (GetBonificacao)
        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        // Método override de Funcionario (AumentarSalario)
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}