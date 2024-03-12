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
        double suma = 0;
        for (int a = 0; a < arr.Length; a++)
        {
            suma += arr[a];
        }
        suma = suma / arr.Length;
        return suma;
    }

    static int maxValue(int[] arr)
    {
        int max = 0;
        for (int a = 0; a < arr.Length; a++)
        {
            if (arr[a] > max)
            {
                max = arr[a];
            }
        }
        return max;
    }
}