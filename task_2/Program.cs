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
int[] arr = new arr[15];
int num_1, num_2, num_3,num_4, num_5, num_6;
int[] array = {5, 3, 1, 2, 4, 6};

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
    else if(array[i] == 6)
    {
        num_6++;
    }
    Console.WriteLine();
}
