using EmployeesClass;


namespace Employees;

public class AccountManager : Employee // Inheritance from Employee
{

    // Constructor with parameters (passing the parameter to the constructor of the base class)
    public AccountManager(string cpf) : base(cpf, 4000)
    {

    }
    

    // Method override de Employee (GetBonus)
    public override double GetBonus()
    {
        return this.Salary * 0.25;
    }


    // Method override de Employee (IncreaseSalary)
    public override void IncreaseSalary()
    {
        this.Salary *= 1.05;
    }

}