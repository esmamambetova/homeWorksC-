// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int GetPolinrome (int number) {
    int n = number;
    int reverse = 0;
    while (n>0) 
    {
        int r = n % 10;
        reverse = reverse * 10 + r;
        n = n / 10;
    }
    if (reverse == number) 
    {
        return 1;
    } else {
        return -1;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (GetPolinrome(num) == 1) 
{
    Console.WriteLine("ДА");
} else 
{
    Console.WriteLine("Нет");
}
