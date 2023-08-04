using Operations;


namespace OperationSystem;

public class Operation
{
    // Creating properties
    public Sum sum { get; private set; }
    public Subtraction subtraction { get; private set; }
    public Multiplicate multiplicate { get; private set; }
    public Division division { get; private set; } 
    
    // Creating constructor
    public Operation()
    {
        this.sum = new Sum();
        this.subtraction = new Subtraction();
        this.multiplicate = new Multiplicate();   
        this.division = new Division();
    }
}