using System;

namespace Csharp_Studies
{
    public class Condicoes
    {
        static void Main(string[] args) {
            
            int idade = 17;
            bool acompanhado = false;
            string textoAcompanhado;

            if (acompanhado) {
                textoAcompanhado = "Você está acompanhado.";
            }
            else {
                textoAcompanhado = "Você não está acompanhado.";
            }

            if (idade >= 18 || acompanhado) 
            {
                Console.WriteLine(textoAcompanhado);
                Console.WriteLine("Liberado, pode entrar!");
            }
            else {
                Console.WriteLine(textoAcompanhado);
                Console.WriteLine("Não pode entrar!");
            }

        }
    }
}