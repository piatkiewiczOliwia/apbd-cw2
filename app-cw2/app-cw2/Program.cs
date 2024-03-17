using System;

public class Program
{
    public static double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("array is empty");
        }
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}