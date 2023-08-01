using Funcionarios;
using ClassDiretor;
using ClassBonificacao;
using ClassAuxiliar;
using ClassDesigner;
using ClassGerente;
using ClassSistemaInterno;

public class Program
{
    private static void Main(string[] args)
    {
        void CalcularBonificacao()
        {

            // Criação do objeto (Mateus) da classe Diretor
            Diretor Mateus = new Diretor("123567");
            Mateus.Nome = "Mateus Pereira";


            // Criação do objeto (Daniel) da classe Designer
            Designer Daniel = new Designer("147852");
            Daniel.Nome = "Daniel Frontarolli";


            // Criação do objeto (Eduardo) da classe Auxiliar
            Auxiliar Eduardo = new Auxiliar("235689");
            Eduardo.Nome = "Eduardo Rabelo";


            // Criação do objeto (João) da classe GerenteDeContas
            GerenteDeContas João = new GerenteDeContas("124578");
            João.Nome = "João Vitor Vanni";


            // Criação do objeto (gerenciado) da classe GerenciadorDeBonificacao
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            gerenciador.Registrar(Mateus);
            gerenciador.Registrar(Daniel);
            gerenciador.Registrar(Eduardo);
            gerenciador.Registrar(João);

            Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
        }

        void UsarSistema()
        {

            // Criação do objeto (Mateus) da classe Diretor    
            Diretor Mateus = new Diretor("123567");
            Mateus.Nome = "Mateus Pereira";
            Mateus.Senha = "456";


            // Criação do objeto (João) da classe GerenteDeContas
            GerenteDeContas João = new GerenteDeContas("124578");
            João.Nome = "João Vitor Vanni";
            João.Senha = "125";


            // Criação do objeto (sistema) da classe SistemaInterno
            SistemaInterno sistema = new SistemaInterno();

            sistema.Logar(Mateus, "456"); // Senha correta
            sistema.Logar(João, "456"); // Senha erada
        }

        CalcularBonificacao();
        UsarSistema();

        /*
        Output:

        Total de Bonificação = 4410
        Boas-vindas ao nosso sistema.
        Senha incorreta!
        
        */
    }
}