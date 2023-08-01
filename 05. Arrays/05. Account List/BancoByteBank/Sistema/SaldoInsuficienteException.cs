using ClassInsufficientBalanceException;

public class SaldoInsuficienteException : OperacaoFinanceiraException
{
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
}