
public class BancoException : Exception
{
    public BancoException() { }
    public BancoException(string message) : base("Ocorreu um erro => " + message) { }
    public BancoException(string message, Exception inner) : base(message, inner) { }
    protected BancoException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

