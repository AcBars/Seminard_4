/*Задача 30:**
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

using static System.Console;
Clear();
PrintArray();

void PrintArray()
{
    int[] array = FillArray();
    for (int i = 0; i < array.Length; i++)
        Write(array[i]);
}

int[] FillArray()
{

    int[] array1 = new int[8];
    for (int a = 0; a < array1.Length; a++)
    {

        array1[a] = new Random().Next(0, 2);

    }
    return array1;
}
