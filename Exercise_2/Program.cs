/* Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех цифр числа {number} = {GetSum(number)}");

int GetSum(int length)
{
    int sum = 0;
    for(int temp = length; temp > 0; )
    {
        sum = sum + (temp % 10);
        temp = temp / 10;
    }
    return sum;
}