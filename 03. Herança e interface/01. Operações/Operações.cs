using ClassDivisao;
using ClassMultiplicacao;
using ClassSoma;
using ClassSubtracao;

namespace ClassOperacoes
{
    public class Operacoes
    {

        // Criação de atributos
        public Soma soma { get; private set; } // Atributo da classe Soma
        public Subtracao subtracao { get; private set; } // Atributo da classe Subtracao
        public Multiplicacao multiplicacao { get; private set; } // Atributo da classe Multiplicacao
        public Divisao divisao { get; private set; } // Atributo da classe Divisao
        
        // Criação do método construtor
        public Operacoes()
        {
            this.soma = new Soma();
            this.subtracao = new Subtracao();
            this.multiplicacao = new Multiplicacao();   
            this.divisao = new Divisao();
        }
    }
}