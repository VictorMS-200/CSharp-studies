using EmployeesClass;

namespace ClassInnerSystem;


public class InnerSystem
{
    // Method to log in the system (using the authenticate method from Employee class)
    public bool LogInto(Employee employee, string password) 
    {
        bool userAuth = employee.authenticate(password);
        
        // If the password is correct, the user is authenticated
        if (userAuth)
        {
            Console.WriteLine("Welcome to the system!");
            return true;
        }
        else
        {
            Console.WriteLine("Password is incorrect!");
            return false;
        }
    }
}