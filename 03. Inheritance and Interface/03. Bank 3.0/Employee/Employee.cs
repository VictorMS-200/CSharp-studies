namespace EmployeesClass;

// Abstract class
public abstract class Employee 
{

    // Creating properties
    public string? Name { get; set; }
    public string? Cpf { get; private set; }
    public double Salary { get; protected set; }
    public string? Password { get; set; }
    public static int AmountOfEmployer { get; private set; } // Static member


    // Constructor with parameters
    public Employee(string cpf, double salary)
    {
        this.Salary = salary;
        this.Cpf = cpf;
        AmountOfEmployer++;           
    }
    
    // Creating abstract method (inherited classes: Assistant, Designer, Director, AccountManager)
    public abstract double GetBonus();

    public abstract void IncreaseSalary();


    // Function to change password
    public bool authenticate(string senha) // If the password is correct, return true
    {
        return this.Password == senha;
    }
}