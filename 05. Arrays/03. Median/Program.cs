// Create a array and set the values
Array sample = Array.CreateInstance(typeof(double), 5);

sample.SetValue(5.9, 0);
sample.SetValue(1.8, 1);
sample.SetValue(7.1, 2);
sample.SetValue(10.0, 3);
sample.SetValue(6.9, 4);

// Create a method that calculates the median of a sample of numbers of type double.
void TestMedian(Array array)
{
    // Check if the array is empty
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("The array is empty!");
    }

    // Create a copy of the array and sort it
    double[] OrderNumers = (double[]) array!.Clone();
    Array.Sort(OrderNumers);

    int lenght = OrderNumers.Length;
    int mid = lenght / 2;
    
    // Calculate the median
    double mediana = (lenght % 2 != 0) ? OrderNumers[mid] : 
    (OrderNumers[mid] + OrderNumers[mid - 1]) / 2;

    Console.WriteLine($"The median of the sample is {mediana}");
}

TestMedian(sample);
