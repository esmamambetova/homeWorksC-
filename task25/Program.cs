// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num_b = Convert.ToInt32(Console.ReadLine());

int Vozvedenie_v_stepen(int num1, int num2) 
{
    int num = num1;
    for (int i = 1; i < num2; i++)
    {
        Console.WriteLine(i);
        num = num * num1;
    }
    Console.WriteLine(num);
    return 0;
}

Vozvedenie_v_stepen(num_a, num_b);
