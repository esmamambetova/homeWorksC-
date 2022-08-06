// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int GetSumNumbers (int number) 
{
    int sum = 0;
    for (int i = 0; i < number.ToString().Count(); i++)
    {
        string a1 = Convert.ToString(number.ToString()[i]);
        sum = sum + Convert.ToInt32(a1);
    }
    return sum;
}

Console.WriteLine($"Сумма всех чисел: {GetSumNumbers (num)}");