using Funcionarios;

namespace ClassBonificacao
{
    public class GerenciadorDeBonificacao
    {
        
        // Criação de atributo
        public double TotalDeBonificacao { get; private set; }


        // Método adicionar o total de bonificação
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }
    }
}