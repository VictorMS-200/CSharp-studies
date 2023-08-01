using Funcionarios;

namespace ClassSistemaInterno
{
    public class SistemaInterno
    {

        // Método de logar com um objeto pertecente de Funcionario 
        public bool Logar(Funcionario funcionario, string senha) 
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas-vindas ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}