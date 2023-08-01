namespace ClassInsufficientBalanceException
{
    public class FinancialOperationException : Exception // Herdando da classe Exception [criando uma exeção]
    {
        public FinancialOperationException(string mensagem) : base(mensagem) // Passa o parametro para o message da classe Exception
        {

        }
        
        public FinancialOperationException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) // Passa o parametro para o message e innerException da classe Exception
        { 

        } 
    }
}