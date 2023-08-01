using EmployeesClass;


namespace Employees;

public class Designer : Employee // Inheritance from Employee
{

    // Constructor with parameters (passing the parameter to the constructor of the base class)
    public Designer(string cpf) : base(cpf, 3000) 
    {

    }


    // Method override de Employee (GetBonus)
    public override double GetBonus()
    {
        return this.Salary * 0.17;
    }


    // Method override de Employee (IncreaseSalary)
    public override void IncreaseSalary()
    {
        this.Salary *= 1.11;
    }
}