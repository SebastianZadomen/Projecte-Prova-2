using LibraryExercici2;
using System;
namespace ExerciciProva;
public class Exercici2
{
    public static void Main()
    {
        int[] array = { 10, -4, 6, 4, 8, 13, 2, -4 };
        //int num = Convert.ToInt32(Console.ReadLine());
        int total = Divide(array,0,7);
        Console.WriteLine($"{array}");

    }
    public static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public static int Divide(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = (low - 1);

        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return (i + 1);
    }

    public static void Order(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Divide(arr, low, high);
            Order(arr, low, pi - 1);
            Order(arr, pi + 1, high);
        }
    }
}
