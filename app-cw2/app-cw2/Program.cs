using System;

public class Program
{
    public static double CalculateAvg(int[] array)
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

    public static int max(int[] arr)
    {
        int max = 0;
        foreach (var i in arr)
        {
            if (i > max)
                max = i;
        }

        return max;
    }
}