/*
Реализовать перемешивание массива

1 1 2 3 4 5 6 7 8 
*/

Console.Clear();

//Метод создание массива нужной длинны
int[] CreateArray(int lengthArray)
{
    return new int[lengthArray];
}
//Метод заполнения массива 
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i;
    }
}
//Метод вывода массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " , ");
    }
}
//Метод премешивания массива
void MixArray(int[] arr)
{
    for(int i = arr.Length - 1; i >= 1 ; i--)
    {
        int j = i + 1;
        int temporary = arr[j];
        arr[j] = arr[i];
        arr[i] = temporary;
    }
}

int[] array = CreateArray(10);
FillArray(array);
PrintArray(array);
MixArray(array);
Console.WriteLine();
PrintArray(array);

/*
for (int i = data.Length - 1; i >= 1; i--)
{
   int j = random.Next(i + 1);
   // обменять значения data[j] и data[i]
   var temp = data[j];
   data[j] = data[i];
   data[i] = temp;
}
*/