namespace Operations;

public class Division
{
    public double Calculate(double num1, double num2)
    {
        if (num2 == 0)
        {
            return 0;
        }
        return num1 / num2;
    }
}