// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool CheckDayOff (int num) {
    if ((num >5) && (num <8)) return true; return false;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (CheckDayOff(num)) Console.WriteLine("ДА"); else Console.WriteLine("нет");