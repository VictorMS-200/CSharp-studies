using classAuth;
using EmployeesClass;


namespace ClasEmployeeAuth;

// Ihneritance class Employee and interface IAuth
public abstract class EmployeeAuth : Employee, IAuth
{
    // Create property
    public new string? Password { get; set; }


    // Create constructor (cpf and salary)
    protected EmployeeAuth(string cpf, double salary) : base(cpf, salary) // Pass the parameter to the cpf and salary of the Employee class
    { 

    }


    // Method to authenticate password
    public bool Auth(string password)
    {
        return this.Password == password;
    }
}