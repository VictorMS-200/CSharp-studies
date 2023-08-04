using Employees;


namespace classAuth;

// Interface (Ihneritance: CommercialPartner, EmployeeAuth)
public interface IAuth
{
    // Create property  
    public string? Password { get; set; }


    // Method to authenticate password
    public abstract bool Auth(string senha);
}