namespace ClassOperacaoFinanceiraException
{
    public class OperacaoFinanceiraException : Exception // Herdando da classe Exception [criando uma exeção]
    {
        public OperacaoFinanceiraException(string mensagem) : base(mensagem) // Passa o parametro para o message da classe Exception
        {

        }
        
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) // Passa o parametro para o message e innerException da classe Exception
        { 

        } 
    }
}