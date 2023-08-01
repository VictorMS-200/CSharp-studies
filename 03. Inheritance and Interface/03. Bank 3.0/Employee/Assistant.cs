using EmployeesClass;


namespace Employees;

public class Assistant : Employee // Inheritance from Employee
{

    // Constructor with parameters (passing the parameter to the constructor of the base class)
    public Assistant(string cpf) : base(cpf, 2000) 
    {

    }


    // Method override de Employee (GetBonus)
    public override double GetBonus()
    {
        return this.Salary * 0.20;
    }


    // Method override de Employee (IncreaseSalary)
    public override void IncreaseSalary()
    {
        this.Salary *= 1.10;
    }
}