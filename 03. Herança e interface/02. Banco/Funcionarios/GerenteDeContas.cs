using Funcionarios;

namespace ClassGerente
{
    public class GerenteDeContas : Funcionario // Herdando da classe Funcionario
    {

        // Membro construtor da classe (cpf)   
        public GerenteDeContas(string cpf) : base(cpf, 4000) // Passa o parametro para o cpf da classe Funcionario
        {

        }
        

        // Método override de Funcionario (GetBonificacao)
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }


        // Método override de Funcionario (AumentarSalario)
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

    }
}