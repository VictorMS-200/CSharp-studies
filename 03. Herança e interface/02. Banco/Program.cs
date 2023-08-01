using ClassDiretor;
using ClassAuxiliar;
using ClassDesigner;
using ClassGerente;
using ClassSistemaInterno;

public class Program
{
    private static void Main(string[] args)
    {

        UsarSistema(); // Execuar o método

        void UsarSistema()
        {

            // Criação do objeto (Mateus) da classe Diretor
            Diretor Mateus = new Diretor("123567");
            Mateus.Nome = "Mateus Pereira";
            Mateus.Senha = "456";


            // Criação do objeto (Daniel) da classe Designer
            Designer Daniel = new Designer("147852");
            Daniel.Nome = "Daniel Frontarolli";
            Daniel.Senha = "987";


            // Criação do objeto (Eduardo) da classe Auxiliar
            Auxiliar Eduardo = new Auxiliar("235689");
            Eduardo.Nome = "Eduardo Rabelo";
            Eduardo.Senha = "123";


            // Criação do objeto (João) da classe GerenteDeContas
            GerenteDeContas João = new GerenteDeContas("124578");
            João.Nome = "João Vitor Vanni";
            João.Senha = "125";


            // Criação do objeto (sistema) da classe SistemaInterno
            SistemaInterno sistema = new SistemaInterno();


            sistema.Logar(Mateus, "457"); // Senha errada
            sistema.Logar(Daniel, "987"); // Senha correta
            sistema.Logar(Eduardo, "123"); // Senha corretas
            sistema.Logar(João, "456"); // Senha errada
        }

        /*
        Output:

        Senha incorreta!
        Boas-vindas ao nosso sistema.
        Boas-vindas ao nosso sistema.
        Senha incorreta!
        */
    }
}