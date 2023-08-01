using Operations;

namespace OperationSystem;

public class Operation
{
    public Sum sum { get; private set; }
    public Subtraction subtraction { get; private set; }
    public Multiplicate multiplicate { get; private set; }
    public Division division { get; private set; } 
    
    // Criação do método construtor
    public Operation()
    {
        this.sum = new Sum();
        this.subtraction = new Subtraction();
        this.multiplicate = new Multiplicate();   
        this.division = new Division();
    }
}