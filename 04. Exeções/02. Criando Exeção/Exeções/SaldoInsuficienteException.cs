using ClassOperacaoFinanceiraException;

public class SaldoInsuficienteException : OperacaoFinanceiraException // Herdando da classe Exception [criando uma exeção]
{
        public SaldoInsuficienteException(string mensagem) : base(mensagem) // Passa o parametro para o message da classe Exception
        {

        }
}