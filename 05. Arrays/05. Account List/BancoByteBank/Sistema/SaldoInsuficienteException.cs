using ClassOperacaoFinanceiraException;

public class SaldoInsuficienteException : OperacaoFinanceiraException
{
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
}