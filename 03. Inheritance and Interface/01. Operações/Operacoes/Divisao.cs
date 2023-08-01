namespace ClassDivisao
{
    public class Divisao
    {
        public double Calcular(double num1, double num2)
        {
            if (num2 == 0)
            {
                return 0;
            }
            return num1 / num2;
        }
    }
}