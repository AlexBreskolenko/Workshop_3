/*
дан массив: наполнени числами от 1 до N
Задача: сколько раз какое число встречается

1 3 1 2 1 2 4 5 1 2 5 4

1 - 4р
2 - 3р
3 - 1р
4 - 2р
5 - 2р

*/
Console.Clear();

//Метод создания массива
int[] CreateArray(int lengthArray)
{
    return new int[lengthArray];
}

//Метод заполнения массива случайными числами от 1 до 5
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,6);
    }
}
//Метод вывода массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Console.Write("На сколько элементов вы хотите создать массив ? : ");
int length = int.Parse(Console.ReadLine());

int[] array = CreateArray(length);
FillArray(array);
PrintArray(array);

int num_1 = 0, num_2 = 0, num_3 = 0, num_4 = 0, num_5 = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] == 1)
    {
        num_1++;
    }
    else if(array[i] == 2)
    {
        num_2++;
    }
    else if(array[i] == 3)
    {
        num_3++;
    }
    else if(array[i] == 4)
    {
        num_4++;
    }
    else if(array[i] == 5)
    {
        num_5++;
    }
}

Console.WriteLine();
Console.WriteLine(" 1 - " + num_1);
Console.WriteLine(" 2 - " + num_2);
Console.WriteLine(" 3 - " + num_3);
Console.WriteLine(" 4 - " + num_4);
Console.WriteLine(" 5 - " + num_5);
