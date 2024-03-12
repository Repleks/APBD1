namespace Project1;

public class Class1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");   
        Console.WriteLine(3 + 3);
        Console.Write("I will print on the same line.");
    }

    static double AverageCounter(int[] arr)
    {
        double sum = 0;
        for (int a = 0; a < arr.Length; a++)
        {
            sum += arr[a];
        }
        sum = sum / arr.Length;
        return sum;
    }
}