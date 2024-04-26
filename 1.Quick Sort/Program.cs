using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 100);
        }

        Console.Write("Sebelum sort: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine();
        QuickSort(array, 0, array.Length - 1);

        Console.Write("Setelah sort: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine("\n");
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        int l, r, s;
        while (right > left)
        {
            l = left;
            r = right;
            s = arr[left];
            while (l < r)
            {
                while (arr[r] > s)
                {
                    r--;
                }
                arr[l] = arr[r];
                while (s >= arr[l] && l < r)
                {
                    l++;
                }
                arr[r] = arr[l];
            }
            arr[l] = s;
            QuickSort(arr, left, l - 1);
            left = l + 1;
        }
    }
}
