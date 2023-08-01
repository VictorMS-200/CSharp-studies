using classAuth;


namespace ClassCommercialPartner;

// Ihneritance class Employee and interface IAuth
public class CommercialPartner : IAuth
{
    // Create property
    public string? Password { get; set; }

    // Method to authenticate password
    public bool Auth(string password) // Return True if match with the correct password
    {
            return this.Password == password;
    }
}