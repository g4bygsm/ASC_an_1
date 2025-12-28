void CountingSort(int[] arr5)
{
    for (int n = 0; n < arr5.Length; n++)
        for (int i = 0; i < arr5[n]; i++)
            Console.Write($"{n} ");
    Console.WriteLine();
}

int[] arr4 = InitRandomArray(1000, 100);
PrintArray(arr4);

int[] arr5 = Frequency(arr4, 100);
CountingSort(arr5);