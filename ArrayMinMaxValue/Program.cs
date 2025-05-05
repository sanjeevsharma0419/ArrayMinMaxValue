namespace ArrayMinMaxValue;

public class Program
{
    public static void Main(string[] args)
    {
        // read the number of elements in the array from the user
        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());

        // read the elements of the array from the user
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // way to find the minimum and maximum value in the array using for loop
        int[] mimMaxValue = FindMinMaxValue(arr);
        Console.WriteLine($"The minimum and maximum value in the array using for loop approach are: {mimMaxValue[0]} and {mimMaxValue[1]}");

        // way to find the least value in the array using array.sort()
        int[] minMaxValueByUsingArraySort = FindMinMaxValueByArraySort(arr);
        Console.WriteLine($"The minimum and maximum value in the array using array.sort() approach are: {minMaxValueByUsingArraySort[0]} and {minMaxValueByUsingArraySort[1]}");

        // way to find the least value in the array using inbuilt array functions
        int[] minMaxValueByUsingInbuiltArrayFunction = FindMinMaxValueByInbuiltArrayFunction(arr);
        Console.WriteLine($"The minimum and maximum value in the array using in built array functions approach are: {minMaxValueByUsingInbuiltArrayFunction[0]} and {minMaxValueByUsingInbuiltArrayFunction[1]}");
    }

    private static int[] FindMinMaxValue(int[] arr)
    {
        int minValue = arr[0];
        int maxValue = arr[0];
        foreach (int value in arr)
        {
            if (value < minValue)
            {
                minValue = value;
            }
            if (value > maxValue)
            {
                maxValue = value;
            }
        }
        return [minValue, maxValue];
    }

    private static int[] FindMinMaxValueByArraySort(int[] arr)
    {
        Array.Sort(arr);
        return [arr[0], arr[arr.Length - 1]]; // or it can be [arr[0], arr[^1]] in C# 8.0 and above
    }

    private static int[] FindMinMaxValueByInbuiltArrayFunction(int[] arr)
    {
        return [arr.Min(), arr.Max()]; 
    }
}