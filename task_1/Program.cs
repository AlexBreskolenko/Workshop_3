/*
Реализовать перемешивание массива

1 1 2 3 4 5 6 7 8 
*/

Console.Clear();

int[] array = {5, 9, 4, 2, 6, 10};

for(int i = 0; i < array.Length - 1; i++)
{
        array[i] = array[i + 1];
}

for (int i = 0; i < array.Length;i++)
{
    Console.Write(array[i] + " ");
}