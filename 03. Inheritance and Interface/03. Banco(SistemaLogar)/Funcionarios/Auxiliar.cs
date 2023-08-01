using Funcionarios;

namespace ClassAuxiliar
{
    public class Auxiliar : Funcionario  // Herdando da classe Funcionario
    {

        // Membro construtor da classe (cpf)
        public Auxiliar(string cpf):base(cpf, 2000) // Passa o parametro para o cpf da classe Funcionario
        {

        }

        // Método override de Funcionario (GetBonificacao)
        public override double GetBonificacao()
        {
            return this.Salario * 0.20;
        }

        // Método override de Funcionario (AumentarSalario)
        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}