using ClassInsufficientBalanceException;

public class InsufficientBalanceException : FinancialOperationException // Herdando da classe Exception [criando uma exeção]
{
        public InsufficientBalanceException(string mensagem) : base(mensagem) // Passa o parametro para o message da classe Exception
        {

        }
}