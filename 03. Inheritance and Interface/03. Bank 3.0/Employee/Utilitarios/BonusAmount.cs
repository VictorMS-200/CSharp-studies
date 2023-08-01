using Employees;
using EmployeesClass;


namespace ClassBonus;

public class BonusManager
{
    // Creating properties
    public double BonusAmount { get; private set; }


    // Creating method to register bonus
    public void Register(Employee employee)
    {
        this.BonusAmount += employee.GetBonus();
    }
}