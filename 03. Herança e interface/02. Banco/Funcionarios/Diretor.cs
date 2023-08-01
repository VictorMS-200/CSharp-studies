using Funcionarios;

namespace ClassDiretor
{
    public class Diretor : Funcionario // Herdando da classe Funcionario
    {

        // Membro construtor da classe (cpf)
        public Diretor(string cpf) : base(cpf, 5000) // Passa o parametro para o cpf da classe Funcionario
        {

        }


        // Método override de Funcionario (GetBonificacao)
        public override double GetBonificacao()
        {
            return this.Salario * 0.50;
        }


        // Método override de Funcionario (AumentarSalario)
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}