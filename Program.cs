int[] GetRandomArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] array = GetRandomArray(8, 0, 99);
Console.Write($"[{String.Join(", ",array)}]");