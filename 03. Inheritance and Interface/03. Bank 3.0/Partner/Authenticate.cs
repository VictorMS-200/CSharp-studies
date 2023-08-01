namespace ClassAuth;

public class CommercialPartner
{
    // Create property
    public string? Senha { get; set; }

    // Method to authenticate password
    public bool Auth(string senha) // Return True if match with the correct password
    {
        return this.Senha == senha;
    }
}