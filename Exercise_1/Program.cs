/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} = {GetNumber(A, B)}");

// Способ 1 

/* int GetNumber(int x, int y)
{
    return Convert.ToInt32(Math.Pow(x, y));
}*/

// Способ 2 (через цикл)

int GetNumber(int x, int y)
{
    int result = 1;
    for (int i = 0; i < y; i++)
    {
        result = result * x; 
    }
    return result;
}