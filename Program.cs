class Qsort
{
    static void Main()
    {
        Console.Write("Enter amount of the array elements:\t");
        int amount = int.Parse(Console.ReadLine());
        int[] randomArray = new int[amount];
        Random rand = new Random();

        for (int i = 0; i <= randomArray.Length - 1; i++)
        {
            randomArray[i] = rand.Next(-100, 100);
        }

        int[] sortedArray = QuickSort(randomArray, 0, randomArray.Length - 1);
        Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");
    }

    static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }
        
        int pivotIndex = PivotIndex(array, minIndex, maxIndex);
        QuickSort(array, minIndex, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    static int PivotIndex(int[] array, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;

        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                SwapProcess(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        SwapProcess(ref array[pivot], ref array[maxIndex]);

        return pivot;
    }

    private static void SwapProcess(ref int leftItem, ref int rightItem)
    {
        int temp = leftItem;
        leftItem = rightItem;
        rightItem = temp;
    }
}
