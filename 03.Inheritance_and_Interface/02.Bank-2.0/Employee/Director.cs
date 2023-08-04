using EmployeesClass;


namespace Employees;

public class Director : Employee // Inheritance from Employee
{

    // Constructor with parameters (passing the parameter to the constructor of the base class)
    public Director(string cpf) : base(cpf, 5000)
    {

    }


    // Method override de Employee (GetBonus)
    public override double GetBonus()
    {
        return this.Salary * 0.50;
    }


    // Method override de Employee (IncreaseSalary)
    public override void IncreaseSalary()
    {
        this.Salary *= 1.15;
    }

}