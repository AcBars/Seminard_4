/*Задача 30:**
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

using static System.Console;
Clear();






void PrintArray (FillArray)
{
    for (int i=0; i>=7; i++)
    Write(FillArray[i]);
}

int [] FillArray (int [] array)
{
    
    int [] array1 = new int[8];
    for(int a = 0; a<8; a++)
    {
        
       array1[a]=new Random().Next(0,2);

    }
    return array1;
}
