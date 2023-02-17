/*
// 1.Создать массив

*/
Console.Clear();

int[] CreateArray(int length)
{
    return new int[length];
}

// Распечатать массив
void Print(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        ++index;
    }
    Console.WriteLine();
}

//Заполняет массив рандомными числами
void FillArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = index;
        ++index;
    }
}

//Метод перемешивания
void MixArray(int[] arr)
{
    int size = arr.Length - 1;
    int index = 0;
    int help = arr[0];
    while (index < size)
    {
        help = arr[index];
        arr[index] = arr[index + 1];
        index++;
    }
    arr[size] = help;
}


int[] arr = CreateArray(10);
FillArray(arr);
Print(arr);
Console.WriteLine();
MixArray(arr);
Print(arr);