// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int GetSecondNumber(int number)
{
    return (number / 10) % 10; ;
}

bool CheckNumber(int number)
{
    if ((number > 99) && (number < 1000))
    {
        return true;
    }
    else return false;
}

while (true)
{
    Console.Write("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (CheckNumber(num))
    {
        Console.WriteLine($"Вторая цифра от числа {num}: -> {GetSecondNumber(num)}");
        break;
    }
    Console.WriteLine($"Число {num} не трехзначное, попробуйте еще раз");
}