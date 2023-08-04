using OperationSystem;

var op = new Operation();

Console.WriteLine($"The value of 50 + 20 = {op.sum.Calculate(50, 20)}");
Console.WriteLine($"The value of 61 - 11 = {op.subtraction.Calculate(61, 11)}");
Console.WriteLine($"The value of 16 * 8 = {op.multiplicate.Calculate(16, 8)}");
Console.WriteLine($"The value of 95 / 5 = {op.division.Calculate(95, 5)}");

/*
Output:

The value of 50 + 20 = 70
The value of 61 - 11 = 50
The value of 16 * 8 = 128
The value of 95 / 5 = 19
*/
