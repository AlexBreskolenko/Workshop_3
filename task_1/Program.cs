/*
Реализовать перемешивание массива

1 1 2 3 4 5 6 7 8 
*/

Console.Clear();

//Метод создание массива нужной длинны
int[] CreateArray(int lengthArray)
{
    return new int [lengthArray];
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
        Console.Write(arr[i] + " ,");
    }
}

int[] array = CreateArray(10);
FillArray(array);
PrintArray(array);