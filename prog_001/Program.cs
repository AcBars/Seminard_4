/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

using static System.Console;
Clear();
WriteLine("Введите число");

WriteLine($"В веденном числе {Getcount(Convert.ToInt32(ReadLine()))} цифры");












int Getcount(int a)
{
    int result = 0;
    do
    {
        a = a/10;
        result++;
    
        
    }
    while (a>=1);

    return result;
}